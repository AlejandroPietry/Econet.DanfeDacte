using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System.Drawing;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    class IndicadorGlobalizado : ElementoBase
    {
        public RectangleF RetanguloNumeroFolhas { get; private set; }
        public DacteViewModel ViewModel { get; private set; }

        public IndicadorGlobalizado(Estilo estilo, DacteViewModel viewModel) : base(estilo)
        {
            ViewModel = viewModel;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);
            const float offsetTitulo = 0.8F;
            const float offsetOpcoes = 0.8F;
            const float offsetRetangulos = 2.6F;
            const float offsetX = 2.0F;

            var r = BoundingBox.InflatedRetangle(1);
            var f1 = Estilo.CriarFonteNegrito(14);
            var f2 = Estilo.CriarFonteNegrito(8F);
            var f3 = Estilo.CriarFonteRegular(6);

            gfx.DrawString("INDICADOR DO CT-E GLOBALIZADO", r.MoveDown(offsetTitulo), f3, AlinhamentoHorizontal.Centro);
            r = r.CutTop(f1.AlturaLinha);
            r = r.MoveDown(offsetOpcoes);

            var retanguloSim = new RectangleF(r.X, r.Y - 2 - offsetRetangulos, 6, f1.AlturaLinha - 1);
            gfx.DrawRectangle(retanguloSim);
            gfx.DrawString(ViewModel.IndicadorGlobalizado ? "X" : "", retanguloSim.MoveDown(offsetX), f2, AlinhamentoHorizontal.Centro, AlinhamentoVertical.Centro);
            var labelSim = new RectangleF(retanguloSim.X + 8, r.Y - 2, 6, f1.AlturaLinha - 1);
            gfx.DrawString("SIM", labelSim, f2, AlinhamentoHorizontal.Centro);

            var retanguloNao = new RectangleF(r.X + 18, r.Y - 2 - offsetRetangulos, 6, f1.AlturaLinha - 1);
            gfx.DrawString(!ViewModel.IndicadorGlobalizado ? "X" : "", retanguloNao.MoveDown(offsetX), f2, AlinhamentoHorizontal.Centro, AlinhamentoVertical.Centro);
            gfx.DrawRectangle(retanguloNao);
            var labelNão = new RectangleF(retanguloNao.X + 8, r.Y - 2, 6, f1.AlturaLinha - 1);
            gfx.DrawString("NÃO", labelNão, f2, AlinhamentoHorizontal.Centro);

        }
    }
}
