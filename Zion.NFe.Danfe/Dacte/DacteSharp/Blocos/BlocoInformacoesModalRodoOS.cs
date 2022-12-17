using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoInformacoesModalRodoOS : BlocoBaseDacte
    {

        public BlocoInformacoesModalRodoOS(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            //if (viewModel.DadosInformacoesOS == null)
            //{
            //    viewModel.DadosInformacoesOS = new DacteViewModel.DadosModalRodoviarioOS();
            //    viewModel.DadosInformacoesOS.DadosModal = new rodoOS();
            //    viewModel.DadosInformacoesOS.SeguroViagem = new DacteViewModel.SeguroViagem();
            //}

            var modeloRod = viewModel.DadosInformacoesOS.DadosModal;
            var registroEstadual = string.Empty;
            var taf = string.Empty;
            if (Item1ChoiceType.NroRegEstadual.Equals(modeloRod.ItemElementName))
                registroEstadual = modeloRod.Item;
            if (Item1ChoiceType.NroRegEstadual.Equals(modeloRod.ItemElementName))
                taf = modeloRod.Item;
            AdicionarLinhaCamposTabelas(10, true)
                .ComCampo("TERMO DE AUTORIZAÇÃO DE FRETAMENTO", taf, AlinhamentoHorizontal.Esquerda)
                .ComCampo("Nº DE REGISTRO ESTADUAL", registroEstadual, AlinhamentoHorizontal.Esquerda)
                .ComCampo("PLACA DO VEÍCULO", modeloRod.veic.placa, AlinhamentoHorizontal.Esquerda)
                .ComCampo("RENAVAM DO VEÍCULO", modeloRod.veic.RENAVAM, AlinhamentoHorizontal.Esquerda)
                .ComCampo("CNPJ/CPF", modeloRod.Item, AlinhamentoHorizontal.Esquerda)
                .ComLarguras(25, 20, 20, 20, 15);
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "INFORMAÇÕES ESPECÍFICAS DO MODAL RODOVIÁRIO";
    }
}
