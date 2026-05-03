using org.pdfclown.documents;
using org.pdfclown.documents.contents.composition;
using System;
using System.Drawing;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace Zion.NFe.Danfe.Nfse
{
    internal class NfsePagina
    {
        public NfseDoc Nfse { get; }
        public Page PdfPage { get; }
        public PrimitiveComposer PrimitiveComposer { get; }
        public Gfx Gfx { get; }
        public RectangleF Retangulo { get; }
        public RectangleF RetanguloDesenhavel { get; private set; }
        public RectangleF RetanguloCabecalho { get; }
        public RectangleF RetanguloCorpo { get; private set; }
        public RectangleF RetanguloRodape { get; }

        public NfsePagina(NfseDoc nfse)
        {
            Nfse = nfse ?? throw new ArgumentNullException(nameof(nfse));
            PdfPage = new Page(Nfse.PdfDocument);
            Nfse.PdfDocument.Pages.Add(PdfPage);

            PrimitiveComposer = new PrimitiveComposer(PdfPage);
            Gfx = new Gfx(PrimitiveComposer);

            Retangulo = new RectangleF(0, 0, Constantes.A4Largura, Constantes.A4Altura);
            if (Nfse.ViewModel.IsHomologacao)
                Retangulo = new RectangleF(0, 0, Constantes.A4Largura, Constantes.A4Altura);

            RetanguloDesenhavel = Retangulo.InflatedRetangle(Nfse.ViewModel.Margem);
            RetanguloCabecalho = new RectangleF(RetanguloDesenhavel.X, RetanguloDesenhavel.Y, RetanguloDesenhavel.Width, 25);
            RetanguloRodape = new RectangleF(RetanguloDesenhavel.X, RetanguloDesenhavel.Bottom - 15, RetanguloDesenhavel.Width, 15);
            RetanguloCorpo = new RectangleF(RetanguloDesenhavel.X, RetanguloCabecalho.Bottom + 2, RetanguloDesenhavel.Width, RetanguloDesenhavel.Height - RetanguloCabecalho.Height - RetanguloRodape.Height - 4);

            PdfPage.Size = new SizeF(Retangulo.Width.ToPoint(), Retangulo.Height.ToPoint());
        }

        public void DesenharCabecalho()
        {
            var titleFont = Nfse.EstiloPadrao.CriarFonteNegrito(18);
            var smallFont = Nfse.EstiloPadrao.CriarFonteRegular(7);

            if (Nfse.LogoObject != null)
            {
                var logoRect = new RectangleF(RetanguloCabecalho.X, RetanguloCabecalho.Y, 30, RetanguloCabecalho.Height - 2);
                Gfx.ShowXObject(Nfse.LogoObject, logoRect);
            }

            var titleRect = new RectangleF(RetanguloCabecalho.X + 32, RetanguloCabecalho.Y, RetanguloCabecalho.Width * 0.3f, RetanguloCabecalho.Height);
            Gfx.DrawString("NFS-e", titleRect, titleFont, AlinhamentoHorizontal.Esquerda, AlinhamentoVertical.Centro);
            Gfx.DrawString(Nfse.ViewModel.IsHomologacao ? "AMBIENTE DE HOMOLOGAÇÃO" : "AMBIENTE DE PRODUÇÃO", new RectangleF(RetanguloCabecalho.X, RetanguloCabecalho.Y, RetanguloCabecalho.Width, RetanguloCabecalho.Height), smallFont, AlinhamentoHorizontal.Direita, AlinhamentoVertical.Centro);
        }

        public void DesenharRodape(int numeroPagina, int totalPaginas)
        {
            var font = Nfse.EstiloPadrao.CriarFonteRegular(6);
            Gfx.DrawString($"Folha {numeroPagina}/{totalPaginas}", RetanguloRodape, font, AlinhamentoHorizontal.Direita, AlinhamentoVertical.Centro);
        }

        public void DesenharMarcaDagua()
        {
            if (!Nfse.ViewModel.IsHomologacao) return;

            var ts = new Elementos.TextStack(RetanguloCorpo)
            {
                AlinhamentoHorizontal = AlinhamentoHorizontal.Centro,
                AlinhamentoVertical = AlinhamentoVertical.Centro,
                LineHeightScale = 0.9F
            }
            .AddLine("SEM VALOR FISCAL", Nfse.EstiloPadrao.CriarFonteRegular(36))
            .AddLine("AMBIENTE DE HOMOLOGAÇÃO", Nfse.EstiloPadrao.CriarFonteRegular(20));

            Gfx.PrimitiveComposer.BeginLocalState();
            Gfx.PrimitiveComposer.SetFillColor(new org.pdfclown.documents.contents.colorSpaces.DeviceRGBColor(0.35, 0.35, 0.35));
            ts.Draw(Gfx);
            Gfx.PrimitiveComposer.End();
        }

        public void DesenharLimites()
        {
            Gfx.StrokeRectangle(RetanguloCabecalho, 0.25f);
            Gfx.StrokeRectangle(RetanguloRodape, 0.25f);
        }
    }
}
