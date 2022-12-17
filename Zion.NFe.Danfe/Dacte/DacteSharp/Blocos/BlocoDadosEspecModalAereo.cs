using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System.Linq;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoDadosEspecModalAereo : BlocoBaseDacte
    {
        public BlocoDadosEspecModalAereo(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            var modeloModal = viewModel.InformacoesDadosModalAereo;
            var cabecalhoNaturezaCarga = new CabecalhoCampo(estilo, "NATUREZA DA CARGA");

            var dadosRetirada = new DadosRetiradaCargaAereo(estilo, modeloModal.Retira) { Height = 10, Width = 30 };
            AdicionarLinhaCamposTabelas(7, true)
            .ComCampo("NÚMERO OPERACIONAL DO CONHECIMENTO AÉREO", modeloModal.NumeroOperacional, AlinhamentoHorizontal.Centro)
            .ComCampo("CLASSE", modeloModal.ClasseCL, AlinhamentoHorizontal.Esquerda)
            .ComCampo("CÓDIGO DA TARIFA", modeloModal.CodigoTarifa, AlinhamentoHorizontal.Centro)
            .ComCampo("VALOR DA TARIFA", modeloModal.ValorTarifa, AlinhamentoHorizontal.Centro)
            .ComLarguras(31f, 24, 24, 21);

            AdicionarLinhaCamposTabelas(8, true)
            .ComCampo("NÚMERO DE MINUTA", modeloModal.NumeroMinuta, AlinhamentoHorizontal.Centro)
            .ComElemento(dadosRetirada)
            .ComElemento(new Campo("DADOS RELATIVOS A RETIRADA DA CARGA", modeloModal.DadosRelativosRetiradCarga, estilo, AlinhamentoHorizontal.Centro))
            .ComLarguras(35, 20, 45);

            var dadosServico = AdicionarLinhaCamposTabelas(6)
                .ComCampo("CARACTERÍSTICA ADICIONAL DO SERVIÇO", modeloModal.CaracteristicaAdicionalServiço, AlinhamentoHorizontal.Centro)
                .ComCampo("DATA PREVISTA DE ENTREGA", modeloModal.DataPrevista, AlinhamentoHorizontal.Centro)
                .ComLarguras(60, 40);
            AdicionarLinhaCamposTabelas(3, true)
                .ComElemento(cabecalhoNaturezaCarga)
                .ComLarguras(0);
            var dadosNaturezaCarga = AdicionarLinhaCamposTabelas(6)
                .ComCampo("DIMENSÃO", modeloModal.NaturezaCarga != null ? modeloModal.NaturezaCarga.First().Dimensao : null, AlinhamentoHorizontal.Centro)
                .ComCampo("INFORMAÇÕES DE MANUSEIO", modeloModal.NaturezaCarga != null ? modeloModal.NaturezaCarga.First().InformacoesManuseio : null, AlinhamentoHorizontal.Centro)
                .ComLarguras(40, 60);

            FlexibleLine fl1 = new FlexibleLine() { Height = 7 }
                   .ComElemento(dadosServico)
                   .ComElemento(dadosNaturezaCarga)
                   .ComLarguras(40, 60);
            MainVerticalStack.Add(fl1);

        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "INFORMAÇÕES ESPECÍFICAS DO MODAL AÉREO";
    }
}
