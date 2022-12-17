using DacteSharp.Blocos;
using ECONET.EcoNFe2.Negocio.Dacte;
using org.pdfclown.documents;
using org.pdfclown.documents.contents.composition;
using System;
using System.Drawing;
using System.Linq;
using Zion.NFe.Danfe;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    internal class DactePagina
    {
        public Dacte Dacte { get; private set; }
        public Page PdfPage { get; private set; }
        public PrimitiveComposer PrimitiveComposer { get; private set; }
        public Gfx Gfx { get; private set; }
        public RectangleF NumeroFolhas { get; set; }
        public RectangleF RetanguloCorpo { get; set; }
        public RectangleF RetanguloDesenhavel { get; private set; }
        public RectangleF RetanguloCreditos { get; private set; }
        public RectangleF Retangulo { get; private set; }

        public DactePagina(Dacte dacte)
        {
            Dacte = dacte ?? throw new ArgumentNullException(nameof(dacte));
            PdfPage = new Page(Dacte.PdfDocument);
            Dacte.PdfDocument.Pages.Add(PdfPage);

            PrimitiveComposer = new PrimitiveComposer(PdfPage);
            Gfx = new Gfx(PrimitiveComposer);

            PrimitiveComposer = new PrimitiveComposer(PdfPage);
            Gfx = new Gfx(PrimitiveComposer);

            if (Dacte.ViewModel.Orientacao == Orientacao.Retrato)
                Retangulo = new RectangleF(0, 0, Constantes.A4Largura, Constantes.A4Altura);
            else
                Retangulo = new RectangleF(0, 0, Constantes.A4Altura, Constantes.A4Largura);

            RetanguloDesenhavel = Retangulo.InflatedRetangle(Dacte.ViewModel.Margem);
            RetanguloCreditos = new RectangleF(RetanguloDesenhavel.X, RetanguloDesenhavel.Bottom + Dacte.EstiloPadrao.PaddingSuperior, RetanguloDesenhavel.Width, Retangulo.Height - RetanguloDesenhavel.Height - Dacte.EstiloPadrao.PaddingSuperior);
            PdfPage.Size = new SizeF(Retangulo.Width.ToPoint(), Retangulo.Height.ToPoint());
        }

        public void DesenharCreditos()
        {
            Gfx.DrawString(string.Format("Impresso em {0} as {1}", DateTime.Now.ToString("dd/MM/yyy"), DateTime.Now.ToString("hh:mm:ss")), RetanguloCreditos, Dacte.EstiloPadrao.CriarFonteItalico(6), AlinhamentoHorizontal.Esquerda);
        }

        private void DesenharCanhoto()
        {
            if (Dacte.ViewModel.QuantidadeCanhotos == 0) return;
            var canhoto = Dacte.Canhoto;
            canhoto.SetPosition(RetanguloDesenhavel.Location);

            if (Dacte.ViewModel.Orientacao == Orientacao.Retrato)
            {
                canhoto.Width = RetanguloDesenhavel.Width;

                for (int i = 0; i < Dacte.ViewModel.QuantidadeCanhotos; i++)
                {
                    canhoto.Draw(Gfx);
                    canhoto.Y += canhoto.Height;
                }

                RetanguloDesenhavel = RetanguloDesenhavel.CutTop(canhoto.Height * Dacte.ViewModel.QuantidadeCanhotos);
            }
            else
            {
                canhoto.Width = RetanguloDesenhavel.Height;
                Gfx.PrimitiveComposer.BeginLocalState();
                Gfx.PrimitiveComposer.Rotate(90, new PointF(0, canhoto.Width + canhoto.X + canhoto.Y).ToPointMeasure());

                for (int i = 0; i < Dacte.ViewModel.QuantidadeCanhotos; i++)
                {
                    canhoto.Draw(Gfx);
                    canhoto.Y += canhoto.Height;
                }

                Gfx.PrimitiveComposer.End();
                RetanguloDesenhavel = RetanguloDesenhavel.CutLeft(canhoto.Height * Dacte.ViewModel.QuantidadeCanhotos);

            }
        }

        private void DesenharCanhotoAereo()
        {
            if (Dacte.ViewModel.QuantidadeCanhotos == 0) return;
            var canhoto = Dacte.CanhotoAereo;
            canhoto.SetPosition(RetanguloDesenhavel.Location);

            if (Dacte.ViewModel.Orientacao == Orientacao.Retrato)
            {
                canhoto.Width = RetanguloDesenhavel.Width;

                for (int i = 0; i < Dacte.ViewModel.QuantidadeCanhotos; i++)
                {
                    canhoto.Draw(Gfx);
                    canhoto.Y += canhoto.Height;
                }

                RetanguloDesenhavel = RetanguloDesenhavel.CutTop(canhoto.Height * Dacte.ViewModel.QuantidadeCanhotos);
            }
            else
            {
                canhoto.Width = RetanguloDesenhavel.Height;
                Gfx.PrimitiveComposer.BeginLocalState();
                Gfx.PrimitiveComposer.Rotate(90, new PointF(0, canhoto.Width + canhoto.X + canhoto.Y).ToPointMeasure());

                for (int i = 0; i < Dacte.ViewModel.QuantidadeCanhotos; i++)
                {
                    canhoto.Draw(Gfx);
                    canhoto.Y += canhoto.Height;
                }

                Gfx.PrimitiveComposer.End();
                RetanguloDesenhavel = RetanguloDesenhavel.CutLeft(canhoto.Height * Dacte.ViewModel.QuantidadeCanhotos);

            }
        }


        public void DesenhaNumeroPaginas(int n, int total)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException(nameof(n));
            if (total <= 0) throw new ArgumentOutOfRangeException(nameof(n));
            if (n > total) throw new ArgumentOutOfRangeException("O número da página atual deve ser menor que o total.");
            //Dacte.ViewModel.NumeroPaginas = ($"{n}/{total}");
            //Gfx.DrawString(($"{n}/{total}"), NumeroFolhas, Dacte.EstiloPadrao.CriarFonteItalico(6), AlinhamentoHorizontal.Esquerda);

        }

        public void DesenharAvisoHomologacao()
        {
        }

        public void DesenharBlocos(bool isPrimeirapagina = false)
        {
            try
            {

                if (isPrimeirapagina && Dacte.ViewModel.QuantidadeCanhotos > 0)
                {
                    if (Dacte.Canhoto != null)
                        DesenharCanhoto();
                    else
                        DesenharCanhotoAereo();
                }

                var blocos = isPrimeirapagina ? Dacte._Blocos : Dacte._Blocos.Where(x => x.VisivelSomentePrimeiraPagina == false);

                foreach (var bloco in blocos)
                {
                    bloco.Width = RetanguloDesenhavel.Width;

                    if (bloco.Posicao == PosicaoBloco.Topo)
                    {
                        bloco.SetPosition(RetanguloDesenhavel.Location);
                        RetanguloDesenhavel = RetanguloDesenhavel.CutTop(bloco.Height);
                    }
                    else
                    {
                        bloco.SetPosition(RetanguloDesenhavel.X, RetanguloDesenhavel.Bottom - bloco.Height);
                        RetanguloDesenhavel = RetanguloDesenhavel.CutBottom(bloco.Height);
                    }

                    bloco.Draw(Gfx);

                    if (bloco is BlocoIdentificacaoEmitenteDacte)
                    {
                        var rf = (bloco as BlocoIdentificacaoEmitenteDacte).RetanguloNumeroFolhas;
                        NumeroFolhas = rf;
                    }
                }

                RetanguloCorpo = RetanguloDesenhavel;
                Gfx.Flush();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
