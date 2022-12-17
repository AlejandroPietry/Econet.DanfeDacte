using org.pdfclown.documents.contents.xObjects;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    internal class ValorPrestacaoServicoLinhas : ElementoBase
    {
        public TCTeInfCteVPrestComp ViewModel { get; private set; }
        public XObject Logo { get; set; }

        public ValorPrestacaoServicoLinhas(Estilo estilo, TCTeInfCteVPrestComp viewModel) : base(estilo)
        {
            ViewModel = viewModel;
            Logo = null;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);
            var rp = BoundingBox.InflatedRetangle(0.75F);
            Fonte f3 = Estilo.CriarFonteRegular(6);
            var componentes = ViewModel;
            TextStack ts;

            ts = new TextStack(rp) { LineHeightScale = 1.5F };

            ts.AddLine($"{Strings.Nome.PadRight(25, ' ')}{Strings.Valor.PadLeft(39, ' ')}", f3);
            ts.AddLine($"{componentes.xNome.PadRight(25, ' ')}{componentes.vComp.PadLeft(31, ' ')}", f3);

            ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda;
            ts.AlinhamentoVertical = AlinhamentoVertical.Topo;
            ts.Draw(gfx);
        }

        private void AddTS()
        {

        }


    }
}
