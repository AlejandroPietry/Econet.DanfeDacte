using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoDadosEspecMultimodal : BlocoBaseDacte
    {
        public BlocoDadosEspecMultimodal(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            var modeloModal = viewModel.InformacoesMultiModal;
            var dadosTipoNegociacao = new TipoNegociacao(estilo, modeloModal) { Height = 8, Width = 30 };
            AdicionarLinhaCamposTabelas(8, true)
                .ComCampo("COTM", modeloModal.COTM, AlinhamentoHorizontal.Esquerda)
                .ComElemento(dadosTipoNegociacao)
                .ComLargurasIguais();

        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "INFORMAÇÕES ESPECÍFICAS DO TRANSPORTE MULTIMODAL DE CARGAS";
    }
}
