using org.pdfclown.documents.contents.composition;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using Zion.NFe.Danfe.Enumeracoes;

namespace Zion.NFe.Danfe.Tools.Extensions
{
    internal static class Extentions
    {
        private const float PointFactor = 72F / 25.4F;

        /// <summary>
        /// Converts Millimeters to Point
        /// </summary>
        /// <param name="mm"></param>
        /// <returns></returns>
        public static float ToPoint(this float mm)
        {
            return PointFactor * mm;
        }

        /// <summary>
        /// Converts Point to Millimeters
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static float ToMm(this float point)
        {
            return point / PointFactor;
        }

        /// <summary>
        /// Converts Point to Millimeters
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static SizeF ToMm(this SizeF s)
        {
            return new SizeF(s.Width.ToMm(), s.Height.ToMm());
        }

        /// <summary>
        /// Converts Point to Millimeters
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static SizeF ToPointMeasure(this SizeF s)
        {
            return new SizeF(s.Width.ToPoint(), s.Height.ToPoint());
        }

        /// <summary>
        /// Converts Millimeters to Point
        /// </summary>
        /// <param name="mm"></param>
        /// <returns></returns>
        public static double ToPoint(this double mm)
        {
            return PointFactor * mm;
        }

        /// <summary>
        /// Converts Point to Millimeters
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static double ToMm(this double point)
        {
            return point / PointFactor;
        }

        public static RectangleF InflatedRetangle(this RectangleF rect, float top, float button, float horizontal)
        {
            return new RectangleF(rect.X + horizontal, rect.Y + top, rect.Width - 2 * horizontal, rect.Height - top - button);
        }

        public static RectangleF InflatedRetangle(this RectangleF rect, float value) => rect.InflatedRetangle(value, value, value);

        public static RectangleF ToPointMeasure(this RectangleF r) => new RectangleF(r.X.ToPoint(), r.Y.ToPoint(), r.Width.ToPoint(), r.Height.ToPoint());

        public static RectangleF CutTop(this RectangleF r, float height) => new RectangleF(r.X, r.Y + height, r.Width, r.Height - height);
        public static RectangleF CutBottom(this RectangleF r, float height) => new RectangleF(r.X, r.Y, r.Width, r.Height - height);
        public static RectangleF CutLeft(this RectangleF r, float width) => new RectangleF(r.X + width, r.Y, r.Width - width, r.Height);

        public static PointF ToPointMeasure(this PointF r) => new PointF(r.X.ToPoint(), r.Y.ToPoint());

        public static StringBuilder AppendChaveValor(this StringBuilder sb, string chave, string valor)
        {
            if (sb.Length > 0) sb.Append(' ');
            return sb.Append(chave).Append(": ").Append(valor);
        }

        public static XAlignmentEnum ToPdfClownAlignment(this AlinhamentoHorizontal ah)
        {
            switch (ah)
            {
                case AlinhamentoHorizontal.Esquerda:
                    return XAlignmentEnum.Left;
                case AlinhamentoHorizontal.Centro:
                    return XAlignmentEnum.Center;
                case AlinhamentoHorizontal.Direita:
                    return XAlignmentEnum.Right;
            }

            throw new InvalidOperationException();
        }

        public static YAlignmentEnum ToPdfClownAlignment(this AlinhamentoVertical av)
        {
            switch (av)
            {
                case AlinhamentoVertical.Topo:
                    return YAlignmentEnum.Top;
                case AlinhamentoVertical.Centro:
                    return YAlignmentEnum.Middle;
                case AlinhamentoVertical.Base:
                    return YAlignmentEnum.Bottom;
            }

            throw new InvalidOperationException();
        }
        /// <summary>
        /// Retorna uma string no formato AAAA-MM-DD
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ParaDataString(this DateTime data)
        {
            return data == DateTime.MinValue ? null : data.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Retorna uma string no formato AAAA-MM-DDThh:mm:ssTZD (UTC - Universal Coordinated Time)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ParaDataHoraStringUtc(this DateTime data)
        {
            return data == DateTime.MinValue ? null : data.ToString("yyyy-MM-ddTHH:mm:sszzz");
        }

        /// <summary>
        /// Retorna uma string no formato AAAA-MM-DDThh:mm:dd 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ParaDataHoraStringSemUtc(this DateTime data)
        {
            return data == DateTime.MinValue ? null : data.ToString("yyyy-MM-ddTHH:mm:dd");
        }

        /// <summary>
        /// Retorna uma string no formato AAAA-MM-DDThh:mm:dd 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ParaDataHoraStringSemUtc(this DateTime? data)
        {
            return ParaDataHoraStringSemUtc(data.GetValueOrDefault());
        }

        /// <summary>
        /// Retorna uma string no formato AAAA-MM-DDThh:mm:ssTZD (UTC - Universal Coordinated Time)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ParaDataHoraStringUtc(this DateTime? data)
        {
            return ParaDataHoraStringUtc(data.GetValueOrDefault());
        }

        /// <summary>
        /// Retorna uma string no formato AAAA-MM-DD HH:mm:ss
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ParaDataHoraString(this DateTime data)
        {
            return data.ToString("yyyyMMddHHmmss");
        }

        public static string ParaHoraString(this TimeSpan hora)
        {
            return hora.ToString(@"hh\:mm\:ss");
        }

        public static decimal Arredondar(this decimal valor, int casasDecimais)
        {
            var valorNovo = decimal.Round(valor, casasDecimais, MidpointRounding.AwayFromZero);
            var valorNovoStr = valorNovo.ToString("F" + casasDecimais, CultureInfo.CurrentCulture);
            return decimal.Parse(valorNovoStr);
        }

        public static decimal? Arredondar(this decimal? valor, int casasDecimais)
        {
            if (valor == null) return null;
            return Arredondar(valor.Value, casasDecimais);
        }

        public static decimal ArredondarParaBaixo(this decimal valor, int casasDecimais)
        {
            var divisor = (decimal)Math.Pow(10, casasDecimais);
            var dividendo = (int)Math.Truncate(divisor * valor);
            return dividendo / divisor;
        }

        /// <summary>
        ///     Copia o valor das propriedades comuns entre dois objetos
        /// </summary>
        /// <typeparam name="TOrigem"></typeparam>
        /// <typeparam name="TDestino"></typeparam>
        /// <param name="objetoOrigem"></param>
        /// <param name="objetoDestino"></param>
        public static void CopiarPropriedades<TDestino, TOrigem>(this TDestino objetoDestino, TOrigem objetoOrigem) where TDestino : class where TOrigem : class
        {
            if (objetoOrigem != null)
            {
                foreach (var attributo in objetoOrigem.GetType().GetProperties().Where(p => p.CanRead))
                {
                    var propertyInfo = objetoDestino.GetType().GetProperty(attributo.Name, BindingFlags.Public | BindingFlags.Instance);
                    if (propertyInfo != null && propertyInfo.CanWrite)
                        propertyInfo.SetValue(objetoDestino, attributo.GetValue(objetoOrigem, null), null);
                }
            }
        }
    }
}
