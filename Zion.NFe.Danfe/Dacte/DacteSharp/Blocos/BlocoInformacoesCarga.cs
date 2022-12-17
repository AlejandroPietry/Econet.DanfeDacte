using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoInformacoesCarga : BlocoBaseDacte
    {

        public BlocoInformacoesCarga(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            var informacoesCarga = viewModel.InformacaoCteNorm;
            //if (informacoesCarga == null)
            //informacoesCarga = new DacteViewModel.InformacoesProdutoCarga();
            var pb = new CabecalhoCampo(campoEstilo, $"PESO BRUTO {informacoesCarga.TipoMedidaPesoBruto}");
            var pc = new CabecalhoCampo(campoEstilo, $"PESO BASE CÁLCULO {informacoesCarga.TipoMedidaPesoBaseCalculo}");
            var pa = new CabecalhoCampo(campoEstilo, $"PESO AFERIDO {informacoesCarga.TipoMedidaPesoAferido}");
            var cb = new CabecalhoCampo(campoEstilo, "CUBAGEM(M3)");
            var qt = new CabecalhoCampo(campoEstilo, $"QTDE{informacoesCarga.TipoMedidaQuantidade}");

            var modeloModal = viewModel.DadosModalRodoviario;

            AdicionarLinhaCamposTabelas(8, true)
                .ComCampo("PRODUTO PREDOMINANTE", informacoesCarga.ProdutoPredominante != null ? informacoesCarga.ProdutoPredominante : " ", AlinhamentoHorizontal.Esquerda)
                .ComCampo("OUTRAS CARACTERÍSTICAS DA CARGA", informacoesCarga.OutrasCaracteristicasCarga != null ? informacoesCarga.OutrasCaracteristicasCarga : " ", AlinhamentoHorizontal.Esquerda)
                .ComCampo("VALOR TOTAL DA CARGA", informacoesCarga.ValorTotalCarga != null ? informacoesCarga.ValorTotalCarga.ToString() : " ", AlinhamentoHorizontal.Esquerda)
                .ComLarguras(60, 22, 18);

            AdicionarLinhaCamposTabelas(3, true)
                .ComElemento(pb)
                .ComElemento(pc)
                .ComElemento(pa)
                .ComElemento(cb)
                .ComElemento(qt)
                .ComLarguras(20, 20, 20, 22, 18);

            AdicionarLinhaCamposTabelas(6, true)
                .ComCampo("", informacoesCarga.PesoBruto, AlinhamentoHorizontal.Esquerda)
                .ComCampo("", informacoesCarga.PesoBaseCalculo, AlinhamentoHorizontal.Esquerda)
                .ComCampo("", informacoesCarga.PesoAferido, AlinhamentoHorizontal.Esquerda)
                .ComCampo("", informacoesCarga.Cubagem, AlinhamentoHorizontal.Esquerda)
                .ComCampo("", informacoesCarga.Quantidade, AlinhamentoHorizontal.Esquerda)
                .ComLarguras(20, 20, 20, 22, 18);
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Topo;
    }
}
