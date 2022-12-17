using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    class InicioTerminoPrestacao : ElementoBase
    {
        public InicioTerminoPrestacao(Estilo estilo) : base(estilo)
        {

        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            var r = BoundingBox.InflatedRetangle(1);
            var f3 = Estilo.CriarFonteRegular(8);

            gfx.DrawString("TÉRMINO DA PRESTAÇÃO - DATA/HORA", r, f3, AlinhamentoHorizontal.Centro);
            r = r.CutTop(f3.AlturaLinha);

            TextStack ts = new TextStack(r)
            {
                AlinhamentoHorizontal = AlinhamentoHorizontal.Centro,
                AlinhamentoVertical = AlinhamentoVertical.Centro,
                LineHeightScale = 1F
            }
            .AddLine(" ", f3)
            .AddLine("INÍCIO DA PRESTAÇÃO - DATA/HORA ", f3)
            .AddLine(" ", f3);

            ts.Draw(gfx);
        }
    }
}