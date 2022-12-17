using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    class Carimbo : ElementoBase
    {

        public Carimbo(Estilo estilo) : base(estilo)
        {

        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            var r = BoundingBox.InflatedRetangle(1);

            var f1 = Estilo.CriarFonteNegrito(14);
            var f2 = Estilo.CriarFonteNegrito(11F);
            var f3 = Estilo.CriarFonteRegular(8);

            //gfx.DrawString("CT-E", r, f1, AlinhamentoHorizontal.Centro);

            r = r.CutTop(f1.AlturaLinha);

            TextStack ts = new TextStack(r)
            {
                AlinhamentoHorizontal = AlinhamentoHorizontal.Centro,
                AlinhamentoVertical = AlinhamentoVertical.Centro,
                LineHeightScale = 1F
            }
            .AddLine(" ", f3)
            .AddLine(" ", f3)
            .AddLine(" ", f3)
            .AddLine(" ", f3)
            .AddLine("ASSINATURA / CARIMBO", f3);

            ts.Draw(gfx);

        }
    }
}