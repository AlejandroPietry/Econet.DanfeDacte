using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using org.pdfclown.documents.contents.xObjects;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    internal class NomeAssinaturaCanhotoAereo : ElementoBase
    {
        public DacteViewModel ViewModel { get; private set; }
        public XObject Logo { get; set; }

        public NomeAssinaturaCanhotoAereo(Estilo estilo) : base(estilo)
        {
        }
        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);
            var rp = BoundingBox.InflatedRetangle(0.75F);
            Fonte f2 = Estilo.CriarFonteNegrito(12);
            Fonte f3 = Estilo.CriarFonteRegular(5);
            gfx.DrawString($"{("NOME")}{("ASSINATURA").PadLeft(110)}", rp, f3, AlinhamentoHorizontal.Esquerda);
            var ts = new TextStack(rp) { LineHeightScale = 1.5F }
                .AddLine(" ", f3)
                .AddLine(" ", f3)
                .AddLine($"{("DATA/HORA")}{("RG").PadLeft(92)}", f3);
            ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda;
            ts.AlinhamentoVertical = AlinhamentoVertical.Centro;
            ts.Draw(gfx);
        }
    }
}
