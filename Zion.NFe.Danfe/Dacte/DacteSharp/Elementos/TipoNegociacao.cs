using System;
using System.Drawing;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    class TipoNegociacao : ElementoBase
    {
        public RectangleF RetanguloNumeroFolhas { get; private set; }
        public multimodal ViewModel { get; private set; }

        public TipoNegociacao(Estilo estilo, multimodal viewModel) : base(estilo)
        {
            ViewModel = viewModel;
        }

        public override void Draw(Gfx gfx)
        {
            try
            {
                base.Draw(gfx);
                var r = BoundingBox.InflatedRetangle(1);
                var f1 = Estilo.CriarFonteNegrito(14);
                var f2 = Estilo.CriarFonteRegular(6);
                var f3 = Estilo.CriarFonteRegular(6);
                var f4 = Estilo.CriarFonteRegular(10);

                gfx.DrawString("INDICADOR NEGOCIÁVEL", r, f3, AlinhamentoHorizontal.Esquerda);
                r = r.CutTop(f1.AlturaLinha);

                var retanguloSim = new RectangleF(r.X, r.Y - 2, 6, f1.AlturaLinha - 1);
                gfx.DrawRectangle(retanguloSim);
                gfx.DrawString((int)ViewModel.indNegociavel == 1 ? "X" : "", retanguloSim, f4, AlinhamentoHorizontal.Centro);
                var labelSim = new RectangleF(retanguloSim.X + 11, retanguloSim.Y + 1, 6, f1.AlturaLinha);
                gfx.DrawString("NEGOCIÁVEL", labelSim, f2, AlinhamentoHorizontal.Centro);

                var retanguloNao = new RectangleF(r.X + 22, r.Y - 2, 6, f1.AlturaLinha - 1);
                gfx.DrawString((int)ViewModel.indNegociavel == 0 ? "X" : "", retanguloNao, f4, AlinhamentoHorizontal.Centro);
                gfx.DrawRectangle(retanguloNao);
                var labelNão = new RectangleF(retanguloNao.X + 13, retanguloNao.Y + 1, 6, f1.AlturaLinha);
                gfx.DrawString("NÃO NEGOCIÁVEL", labelNão, f2, AlinhamentoHorizontal.Centro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                gfx.Flush();
            }
        }
    }
}