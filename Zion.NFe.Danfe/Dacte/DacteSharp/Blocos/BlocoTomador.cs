using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoTomador : BlocoBaseDacte
    {
        public const float LarguraCampoChaveNFe = 93F;
        public const float AlturaLinha1 = 30;
        public const float AlturaColuna3Linha1 = 12.9F;
        Tomador tomador;
        public BlocoTomador(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            tomador = new Tomador(estilo, ViewModel);
            FlexibleLine fl1 = new FlexibleLine() { Height = 12.5F }
                        .ComElemento(tomador)
                        .ComLarguras(100F);
            MainVerticalStack.Add(fl1);
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Topo;

    }

}
