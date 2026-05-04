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
            var titleFont = Nfse.EstiloPadrao.CriarFonteNegrito(12);
            var subtitleFont = Nfse.EstiloPadrao.CriarFonteRegular(8);
            var smallFont = Nfse.EstiloPadrao.CriarFonteRegular(6);
            var keyFont = Nfse.EstiloPadrao.CriarFonteNegrito(8);
            var keyValueFont = Nfse.EstiloPadrao.CriarFonteNegrito(10);

            if (Nfse.LogoObject != null)
            {
                var logoRect = new RectangleF(RetanguloCabecalho.X, RetanguloCabecalho.Y + 1, 18, RetanguloCabecalho.Height - 2);
                Gfx.ShowXObject(Nfse.LogoObject, logoRect);
            }

            var leftRect = new RectangleF(RetanguloCabecalho.X + 20, RetanguloCabecalho.Y, RetanguloCabecalho.Width * 0.52f, RetanguloCabecalho.Height);
            var leftStack = new TextStack(leftRect)
            {
                AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda,
                AlinhamentoVertical = AlinhamentoVertical.Topo,
                LineHeightScale = 0.9F
            }
            .AddLine("DANFSe v1.0", titleFont)
            .AddLine("Documento Auxiliar da NFS-e", subtitleFont)
            .AddLine("Prefeitura da Cidade de São Paulo", smallFont)
            .AddLine("Secretaria Municipal da Fazenda", smallFont)
            .AddLine("Telefone (11)156", smallFont);
            leftStack.Draw(Gfx);

            var rightRect = new RectangleF(RetanguloCabecalho.X + (RetanguloCabecalho.Width * 0.56f), RetanguloCabecalho.Y, RetanguloCabecalho.Width * 0.42f, RetanguloCabecalho.Height);
            var rightStack = new TextStack(rightRect)
            {
                AlinhamentoHorizontal = AlinhamentoHorizontal.Direita,
                AlinhamentoVertical = AlinhamentoVertical.Topo,
                LineHeightScale = 0.95F
            }
            .AddLine("Chave de Acesso da NFS-e", keyFont)
            .AddLine(Nfse.ViewModel.ChaveAcesso ?? string.Empty, keyValueFont)
            .AddLine("Texto de autenticação", smallFont)
            .AddLine(Nfse.ViewModel.CodigoVerificacao ?? string.Empty, smallFont);
            rightStack.Draw(Gfx);

            var ambienteFont = Nfse.EstiloPadrao.CriarFonteRegular(6);
            Gfx.DrawString(Nfse.ViewModel.IsHomologacao ? "AMBIENTE DE HOMOLOGAÇÃO" : "AMBIENTE DE PRODUÇÃO", new RectangleF(RetanguloCabecalho.X, RetanguloCabecalho.Bottom - 5, RetanguloCabecalho.Width, 5), ambienteFont, AlinhamentoHorizontal.Direita, AlinhamentoVertical.Topo);
        }

        public void DesenharRodape(int numeroPagina, int totalPaginas)
        {
            var font = Nfse.EstiloPadrao.CriarFonteRegular(6);
            Gfx.DrawString($"Folha {numeroPagina}/{totalPaginas}", RetanguloRodape, font, AlinhamentoHorizontal.Direita, AlinhamentoVertical.Centro);
        }

        public void DesenharMarcaDagua()
        {
            if (!Nfse.ViewModel.ExibirMarcaDaguaModelo && !Nfse.ViewModel.IsHomologacao) return;

            var ts = new Elementos.TextStack(RetanguloCorpo)
            {
                AlinhamentoHorizontal = AlinhamentoHorizontal.Centro,
                AlinhamentoVertical = AlinhamentoVertical.Centro,
                LineHeightScale = 0.9F
            }
            .AddLine("MODELO", Nfse.EstiloPadrao.CriarFonteRegular(42))
            .AddLine("SEM VALOR FISCAL", Nfse.EstiloPadrao.CriarFonteRegular(20));

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
