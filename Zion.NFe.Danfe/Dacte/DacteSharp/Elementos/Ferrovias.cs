using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    internal class Ferrovias : ElementoBase
    {
        public Ferrovias(Estilo estilo) : base(estilo)
        {
        }
        public override void Draw(Gfx gfx)
        {
            Fonte f3 = Estilo.CriarFonteRegular(6);
            base.Draw(gfx);
            var rp = BoundingBox.InflatedRetangle(1F);
            var ts = new TextStack(rp) { LineHeightScale = 1.3F, AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda }
             .AddLine($"CNPJ{("COD.INTERNO").PadLeft(90, ' ')}", f3)
             .AddLine(" ", f3)
             .AddLine(" ", f3)
             .AddLine($"IE{("RAZÃO SOCIAL").PadLeft(97, ' ')}", f3);
            ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda;
            ts.AlinhamentoVertical = AlinhamentoVertical.Centro;
            ts.Draw(gfx);
        }
    }
}
