using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoDadosInformacoesSeguroMultimodal : BlocoBaseDacte
    {
        public BlocoDadosInformacoesSeguroMultimodal(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            var modeloModal = viewModel.InformacoesMultiModal.seg;

            AdicionarLinhaCamposTabelas(10, true)
                .ComCampo("CNPJ DA SEGURADORA", modeloModal.infSeg.CNPJ, AlinhamentoHorizontal.Esquerda)
                .ComCampo("NOME DA SEGURADORA", modeloModal.infSeg.xSeg, AlinhamentoHorizontal.Esquerda)
                .ComCampo("NÚMERO DA APÓLICE", modeloModal.nApol, AlinhamentoHorizontal.Esquerda)
                .ComCampo("NÚMERO DA AVERBAÇÃO", modeloModal.nAver, AlinhamentoHorizontal.Esquerda)
                .ComLargurasIguais();

        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "INFORMAÇÕES DO SEGURO DO MULTIMODAL";
    }
}
