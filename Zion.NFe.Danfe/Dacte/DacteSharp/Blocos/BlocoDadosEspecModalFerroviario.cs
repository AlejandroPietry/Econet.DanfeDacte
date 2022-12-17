using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoDadosEspecModalFerroviario : BlocoBaseDacte
    {
        public BlocoDadosEspecModalFerroviario(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            var modeloModal = viewModel.InformacoesModalFerroviario;
            AdicionarLinhaCamposTabelas(10, true)
             .ComCampo("TIPO DE TRÁFEGO", modeloModal.TipoTrafego, AlinhamentoHorizontal.Esquerda)
             .ComCampo("FLUXO FERROVIÁRIO", modeloModal.FluxoFerroviario, AlinhamentoHorizontal.Centro)
             .ComCampo("FERROVIA RESPONSÁVEL PELO FATURAMENTO", modeloModal.FerroviaRespFaturamento, AlinhamentoHorizontal.Centro)
             .ComCampo("FERROVIA EMITENTE DO CT-E", modeloModal.FerroviaEmitente, AlinhamentoHorizontal.Centro)
             .ComCampo("VALOR DO FRETE", modeloModal.ValorFrete, AlinhamentoHorizontal.Centro)
             .ComLarguras(18.5F, 18.5F, 26, 18.5F, 18.5F);

            var cabecalhoFerroviasEnvolvidas = new CabecalhoCampo(estilo, "INFORMAÇÕES DAS FERROVIAS ENVOLVIDAS");
            //INCLUI CABEÇALHO PARA BLOCO DE FERROVIAS ENVOLVIDAS
            AdicionarLinhaCamposTabelas(3, true)
                .ComElemento(cabecalhoFerroviasEnvolvidas)
                .ComLarguras(100);

            var ferroviasEnvolvidas = new Ferrovias(estilo);
            var ferroviasEnvolvidas2 = new Ferrovias(estilo);
            FlexibleLine fl1 = new FlexibleLine() { Height = 10 }
                        .ComElemento(ferroviasEnvolvidas)
                        .ComElemento(ferroviasEnvolvidas2)
                        .ComLarguras(50, 50);
            MainVerticalStack.Add(fl1);
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "INFORMAÇÕES ESPECÍFICAS DO MODAL FERROVIÁRIO";
    }
}
