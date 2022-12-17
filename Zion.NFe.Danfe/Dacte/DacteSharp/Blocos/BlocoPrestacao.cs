using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoPrestacao : BlocoBaseDacte
    {
        public BlocoPrestacao(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            AdicionarLinhaCamposTabelas(10, true)
                .ComCampo("INÍCIO DA PRESTAÇÃO", viewModel.OrigemPrestacao, AlinhamentoHorizontal.Centro)
                .ComCampo("TÉRMINO DA PRESTAÇÃO", ViewModel.DestinoPrestacao, AlinhamentoHorizontal.Centro)
                .ComLargurasIguais();
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Topo;
        public override bool PossuiContono => false;
    }
}