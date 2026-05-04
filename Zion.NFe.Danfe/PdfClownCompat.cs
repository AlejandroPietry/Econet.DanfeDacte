using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;

namespace org.pdfclown.bytes
{
    internal class Stream : IDisposable
    {
        public System.IO.Stream BaseStream { get; }

        public Stream(System.IO.Stream stream)
        {
            BaseStream = stream ?? throw new ArgumentNullException(nameof(stream));
        }

        public byte[] ToByteArray()
        {
            if (BaseStream is MemoryStream memoryStream)
            {
                return memoryStream.ToArray();
            }

            if (!BaseStream.CanSeek)
            {
                using var copy = new MemoryStream();
                BaseStream.CopyTo(copy);
                return copy.ToArray();
            }

            var originalPosition = BaseStream.Position;
            try
            {
                BaseStream.Position = 0;
                using var copy = new MemoryStream();
                BaseStream.CopyTo(copy);
                return copy.ToArray();
            }
            finally
            {
                BaseStream.Position = originalPosition;
            }
        }

        public MemoryStream CreateReadStream()
        {
            return new MemoryStream(ToByteArray(), writable: false);
        }

        public void Dispose()
        {
        }
    }
}

namespace org.pdfclown.objects
{
    internal sealed class PdfName
    {
        public PdfName(string value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Value { get; }
    }
}

namespace org.pdfclown.documents.contents
{
    internal sealed class LineDash
    {
        public LineDash(double[] dashArray)
        {
            DashArray = dashArray ?? throw new ArgumentNullException(nameof(dashArray));
        }

        public double[] DashArray { get; }
    }
}

namespace org.pdfclown.documents.contents.colorSpaces
{
    internal sealed class DeviceRGBColor
    {
        public DeviceRGBColor(double red, double green, double blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public double Red { get; }
        public double Green { get; }
        public double Blue { get; }
    }
}

namespace org.pdfclown.documents.contents.fonts
{
    internal abstract class Font
    {
        public abstract double GetWidth(string text, float size);
        public abstract double GetWidth(char c, float size);
        public abstract double GetLineHeight(float size);
        internal abstract XFont CreateFont(float size);
    }

    internal sealed class StandardType1Font : Font
    {
        private static readonly object Sync = new object();
        private static bool _fontResolverConfigured;

        private readonly string _fontName;
        private readonly XFontStyle _fontStyle;

        public enum FamilyEnum
        {
            Courier,
            Times
        }

        public StandardType1Font(org.pdfclown.documents.Document _, FamilyEnum family, bool bold, bool italic)
        {
            EnsureFontResolver();
            _fontStyle = ResolveStyle(bold, italic);
            _fontName = ResolveFontName(family);
        }

        public override double GetWidth(string text, float size)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            using var gfx = XGraphics.CreateMeasureContext(new XSize(1000, 1000), XGraphicsUnit.Point, XPageDirection.Downwards);
            var measured = gfx.MeasureString(text, CreateFont(size));
            return measured.Width;
        }

        public override double GetWidth(char c, float size)
        {
            return GetWidth(c.ToString(), size);
        }

        public override double GetLineHeight(float size)
        {
            var font = CreateFont(size);
            return font.GetHeight();
        }

        internal override XFont CreateFont(float size)
        {
            return new XFont(_fontName, size, _fontStyle);
        }

        private static void EnsureFontResolver()
        {
            if (_fontResolverConfigured)
            {
                return;
            }

            lock (Sync)
            {
                if (_fontResolverConfigured)
                {
                    return;
                }

                GlobalFontSettings.FontResolver = new CrossPlatformFontResolver();
                _fontResolverConfigured = true;
            }
        }

        private static XFontStyle ResolveStyle(bool bold, bool italic)
        {
            if (bold && italic)
            {
                return XFontStyle.BoldItalic;
            }

            if (bold)
            {
                return XFontStyle.Bold;
            }

            if (italic)
            {
                return XFontStyle.Italic;
            }

            return XFontStyle.Regular;
        }

        private static string ResolveFontName(FamilyEnum family)
        {
            return family switch
            {
                FamilyEnum.Courier => "Courier New",
                _ => "Times New Roman"
            };
        }

        private sealed class CrossPlatformFontResolver : IFontResolver
        {
            private const string DefaultFallbackFont = "Zion Embedded Lato";
            private const string EmbeddedRegular = "ZionEmbeddedLato-Regular";
            private const string EmbeddedBold = "ZionEmbeddedLato-Bold";
            private const string EmbeddedItalic = "ZionEmbeddedLato-Italic";
            private const string EmbeddedBoldItalic = "ZionEmbeddedLato-BoldItalic";

            private static readonly IReadOnlyDictionary<string, string> EmbeddedResources = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                [EmbeddedRegular] = "Zion.NFe.Danfe.Fonts.Lato-Regular.ttf",
                [EmbeddedBold] = "Zion.NFe.Danfe.Fonts.Lato-Bold.ttf",
                [EmbeddedItalic] = "Zion.NFe.Danfe.Fonts.Lato-Italic.ttf",
                [EmbeddedBoldItalic] = "Zion.NFe.Danfe.Fonts.Lato-BoldItalic.ttf"
            };

            private readonly PdfSharpCore.Utils.FontResolver _resolver = new PdfSharpCore.Utils.FontResolver
            {
                NullIfFontNotFound = true
            };

            public string DefaultFontName => DefaultFallbackFont;

            public byte[] GetFont(string faceName)
            {
                if (EmbeddedResources.TryGetValue(faceName, out var resourceName))
                {
                    return ReadEmbeddedFont(resourceName);
                }

                return _resolver.GetFont(faceName) ?? ReadEmbeddedFont(EmbeddedResources[EmbeddedRegular]);
            }

            public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
            {
                foreach (var candidate in GetCandidates(familyName))
                {
                    try
                    {
                        var resolved = PlatformFontResolver.ResolveTypeface(candidate, isBold, isItalic);
                        if (resolved != null)
                        {
                            return resolved;
                        }
                    }
                    catch (FileNotFoundException)
                    {
                    }
                    catch (InvalidOperationException)
                    {
                    }
                }

                return new FontResolverInfo(GetEmbeddedFaceName(isBold, isItalic));
            }

            private static string GetEmbeddedFaceName(bool isBold, bool isItalic)
            {
                if (isBold && isItalic)
                {
                    return EmbeddedBoldItalic;
                }

                if (isBold)
                {
                    return EmbeddedBold;
                }

                if (isItalic)
                {
                    return EmbeddedItalic;
                }

                return EmbeddedRegular;
            }

            private static byte[] ReadEmbeddedFont(string resourceName)
            {
                var assembly = typeof(StandardType1Font).GetTypeInfo().Assembly;
                using var stream = assembly.GetManifestResourceStream(resourceName);
                if (stream == null)
                {
                    throw new FileNotFoundException($"Fonte embutida não encontrada: {resourceName}", resourceName);
                }

                using var memoryStream = new MemoryStream();
                stream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }

            private static IEnumerable<string> GetCandidates(string familyName)
            {
                if (string.Equals(familyName, DefaultFallbackFont, StringComparison.OrdinalIgnoreCase))
                {
                    yield break;
                }

                if (string.Equals(familyName, "Times New Roman", StringComparison.OrdinalIgnoreCase))
                {
                    yield return "Times New Roman";
                    yield return "Liberation Serif";
                    yield return "Nimbus Roman";
                    yield return "DejaVu Serif";
                    yield return "FreeSerif";
                    yield break;
                }

                if (string.Equals(familyName, "Courier New", StringComparison.OrdinalIgnoreCase))
                {
                    yield return "Courier New";
                    yield return "Liberation Mono";
                    yield return "Nimbus Mono PS";
                    yield return "DejaVu Sans Mono";
                    yield return "FreeMono";
                    yield break;
                }

                yield return familyName;
                yield return "DejaVu Sans";
            }
        }
    }
}

namespace org.pdfclown.documents.contents.xObjects
{
    internal class XObject
    {
        internal XObject(object nativeObject, SizeF sizeInPoints)
        {
            NativeObject = nativeObject ?? throw new ArgumentNullException(nameof(nativeObject));
            Size = sizeInPoints;
        }

        internal object NativeObject { get; }
        public SizeF Size { get; }
    }
}

namespace org.pdfclown.documents.contents.entities
{
    internal sealed class Image
    {
        private readonly byte[] _bytes;

        private Image(byte[] bytes)
        {
            _bytes = bytes;
        }

        public static Image Get(System.IO.Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            using var copy = new MemoryStream();
            stream.CopyTo(copy);
            if (copy.Length == 0)
            {
                return null;
            }

            return new Image(copy.ToArray());
        }

        public org.pdfclown.documents.contents.xObjects.XObject ToXObject(org.pdfclown.documents.Document _)
        {
            var bytes = _bytes.ToArray();
            var image = XImage.FromStream(() => new MemoryStream(bytes, writable: false));
            return new org.pdfclown.documents.contents.xObjects.XObject(
                image,
                new SizeF((float)image.PointWidth, (float)image.PointHeight));
        }
    }
}

namespace org.pdfclown.documents
{
    internal sealed class Document
    {
        internal Document(PdfDocument innerDocument, byte[] sourcePdfBytes = null)
        {
            InnerDocument = innerDocument ?? throw new ArgumentNullException(nameof(innerDocument));
            SourcePdfBytes = sourcePdfBytes;
            Pages = new PageCollection(this);
            Information = new DocumentInformation(this);
        }

        internal PdfDocument InnerDocument { get; }
        internal byte[] SourcePdfBytes { get; }

        public PageCollection Pages { get; }
        public DocumentInformation Information { get; }
    }

    internal sealed class PageCollection
    {
        private readonly Document _document;

        public PageCollection(Document document)
        {
            _document = document;
        }

        public Page this[int index]
            => new Page(_document, _document.InnerDocument.Pages[index], index);

        public void Add(Page page)
        {
            if (page == null)
            {
                throw new ArgumentNullException(nameof(page));
            }

            if (page.InnerPage == null)
            {
                page.Attach(_document.InnerDocument.AddPage());
            }
        }
    }

    internal sealed class Page
    {
        private readonly Document _owner;
        private readonly int _pageIndex;

        internal Page(Document owner)
        {
            _owner = owner;
            _pageIndex = -1;
        }

        internal Page(Document owner, PdfPage innerPage, int pageIndex)
        {
            _owner = owner;
            InnerPage = innerPage;
            _pageIndex = pageIndex;
        }

        internal PdfPage InnerPage { get; private set; }

        public SizeF Size
        {
            get => InnerPage == null
                ? SizeF.Empty
                : new SizeF((float)InnerPage.Width, (float)InnerPage.Height);
            set
            {
                if (InnerPage == null)
                {
                    throw new InvalidOperationException("A página ainda não foi adicionada ao documento.");
                }

                InnerPage.Width = value.Width;
                InnerPage.Height = value.Height;
            }
        }

        internal void Attach(PdfPage page)
        {
            InnerPage = page;
        }

        public org.pdfclown.documents.contents.xObjects.XObject ToXObject(Document _)
        {
            if (_owner?.SourcePdfBytes == null)
            {
                throw new PlatformNotSupportedException("Conversão de página para XObject só é suportada para PDFs carregados por stream.");
            }

            var pdfForm = XPdfForm.FromStream(new MemoryStream(_owner.SourcePdfBytes, writable: false));
            if (_pageIndex >= 0)
            {
                pdfForm.PageIndex = _pageIndex;
            }

            return new org.pdfclown.documents.contents.xObjects.XObject(
                pdfForm,
                new SizeF((float)pdfForm.PointWidth, (float)pdfForm.PointHeight));
        }
    }

    internal sealed class DocumentInformation
    {
        private readonly Document _document;

        public DocumentInformation(Document document)
        {
            _document = document;
        }

        public string this[org.pdfclown.objects.PdfName name]
        {
            get
            {
                var customValue = _document.InnerDocument.CustomValues[NormalizeKey(name.Value)];
                return customValue?.Value == null ? null : System.Text.Encoding.UTF8.GetString(customValue.Value);
            }
            set
            {
                _document.InnerDocument.CustomValues[NormalizeKey(name.Value)] = new PdfSharpCore.Pdf.PdfCustomValue(System.Text.Encoding.UTF8.GetBytes(value ?? string.Empty));
            }
        }

        public DateTime CreationDate
        {
            get => _document.InnerDocument.Info.CreationDate;
            set => _document.InnerDocument.Info.CreationDate = value;
        }

        public string Creator
        {
            get => _document.InnerDocument.Info.Creator;
            set => _document.InnerDocument.Info.Creator = value;
        }

        public string Title
        {
            get => _document.InnerDocument.Info.Title;
            set => _document.InnerDocument.Info.Title = value;
        }

        private static string NormalizeKey(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Nome de metadata inválido.", nameof(value));
            }

            return value[0] == '/' ? value : "/" + value;
        }
    }
}

namespace org.pdfclown.files
{
    internal enum SerializationModeEnum
    {
        Incremental
    }

    public sealed class File : IDisposable
    {
        internal File()
        {
            Document = new org.pdfclown.documents.Document(new PdfDocument());
        }

        internal File(org.pdfclown.bytes.Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            using var readStream = stream.CreateReadStream();
            var sourceBytes = readStream.ToArray();
            var document = PdfReader.Open(new MemoryStream(sourceBytes, writable: false), PdfDocumentOpenMode.Import);
            Document = new org.pdfclown.documents.Document(document, sourceBytes);
        }

        internal org.pdfclown.documents.Document Document { get; }

        internal void Save(string path, SerializationModeEnum _)
        {
            Document.InnerDocument.Save(path);
        }

        internal void Save(org.pdfclown.bytes.Stream stream, SerializationModeEnum _)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            Document.InnerDocument.Save(stream.BaseStream, closeStream: false);
        }

        public void Dispose()
        {
            Document.InnerDocument.Dispose();
        }
    }
}

namespace org.pdfclown.documents.contents.composition
{
    internal enum XAlignmentEnum
    {
        Left,
        Center,
        Right
    }

    internal enum YAlignmentEnum
    {
        Top,
        Middle,
        Bottom
    }

    internal sealed class PrimitiveComposer
    {
        private readonly XGraphics _graphics;
        private readonly Stack<XGraphicsState> _states = new Stack<XGraphicsState>();
        private readonly List<Action<XPen, XBrush>> _pendingOperations = new List<Action<XPen, XBrush>>();

        private org.pdfclown.documents.contents.fonts.Font _font;
        private float _fontSize;
        private XColor _strokeColor = XColors.Black;
        private XColor _fillColor = XColors.Black;
        private double _lineWidth = 1;
        private double[] _dashPattern;

        public PrimitiveComposer(org.pdfclown.documents.Page page)
        {
            if (page == null)
            {
                throw new ArgumentNullException(nameof(page));
            }

            _graphics = XGraphics.FromPdfPage(page.InnerPage);
        }

        public void SetFont(org.pdfclown.documents.contents.fonts.Font font, float size)
        {
            _font = font ?? throw new ArgumentNullException(nameof(font));
            _fontSize = size;
        }

        public void ShowText(string text, PointF point)
        {
            var font = _font?.CreateFont(_fontSize) ?? throw new InvalidOperationException("Fonte não configurada.");
            _graphics.DrawString(text ?? string.Empty, font, new XSolidBrush(_fillColor), point.X, point.Y);
        }

        public void ShowXObject(org.pdfclown.documents.contents.xObjects.XObject xObject, PointF point, SizeF size)
        {
            if (xObject == null)
            {
                throw new ArgumentNullException(nameof(xObject));
            }

            switch (xObject.NativeObject)
            {
                case XImage image:
                    _graphics.DrawImage(image, point.X, point.Y, size.Width, size.Height);
                    break;
                default:
                    throw new NotSupportedException($"XObject '{xObject.NativeObject.GetType().FullName}' não suportado.");
            }
        }

        public void SetLineWidth(float width)
        {
            _lineWidth = width;
        }

        public void DrawRectangle(RectangleF rectangle)
        {
            _pendingOperations.Add((pen, brush) => _graphics.DrawRectangle(pen, brush, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height));
        }

        public void DrawLine(PointF start, PointF end)
        {
            _pendingOperations.Add((pen, _) => _graphics.DrawLine(pen, start.X, start.Y, end.X, end.Y));
        }

        public void Stroke()
        {
            var pen = CreatePen();
            foreach (var operation in _pendingOperations)
            {
                operation(pen, null);
            }

            _pendingOperations.Clear();
        }

        public void Fill()
        {
            var brush = new XSolidBrush(_fillColor);
            foreach (var operation in _pendingOperations)
            {
                operation(CreateTransparentPen(), brush);
            }

            _pendingOperations.Clear();
        }

        public void Flush()
        {
        }

        public void BeginLocalState()
        {
            _states.Push(_graphics.Save());
        }

        public void End()
        {
            if (_states.Count == 0)
            {
                return;
            }

            _pendingOperations.Clear();
            _graphics.Restore(_states.Pop());
        }

        public void Rotate(double angle, PointF point)
        {
            _graphics.RotateAtTransform(angle, new XPoint(point.X, point.Y));
        }

        public void SetFillColor(org.pdfclown.documents.contents.colorSpaces.DeviceRGBColor color)
        {
            _fillColor = XColor.FromArgb(
                255,
                Clamp(color.Red),
                Clamp(color.Green),
                Clamp(color.Blue));
        }

        public void SetStrokeColor(org.pdfclown.documents.contents.colorSpaces.DeviceRGBColor color)
        {
            _strokeColor = XColor.FromArgb(
                255,
                Clamp(color.Red),
                Clamp(color.Green),
                Clamp(color.Blue));
        }

        public void SetLineDash(org.pdfclown.documents.contents.LineDash dash)
        {
            _dashPattern = dash?.DashArray;
        }

        private XPen CreatePen()
        {
            var pen = new XPen(_strokeColor, _lineWidth);
            if (_dashPattern != null && _dashPattern.Length > 0)
            {
                pen.DashPattern = _dashPattern;
            }

            return pen;
        }

        private XPen CreateTransparentPen()
        {
            var pen = new XPen(XColors.Transparent, 0);
            if (_dashPattern != null && _dashPattern.Length > 0)
            {
                pen.DashPattern = _dashPattern;
            }

            return pen;
        }

        private static int Clamp(double component)
        {
            var scaled = component <= 1 ? component * 255D : component;
            return Math.Max(0, Math.Min(255, (int)Math.Round(scaled)));
        }
    }
}
