using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoSeguroViagemOS : BlocoBaseDacte
    {

        public BlocoSeguroViagemOS(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            var modeloSeg = viewModel.DadosInformacoesOS.SeguroViagem;

            AdicionarLinhaCamposTabelas(10, true)
                .ComCampo("RESPONSÁVEL", modeloSeg.Responsavel, AlinhamentoHorizontal.Esquerda)
                .ComCampo("NOME DA SEGURADORA", modeloSeg.NomeSeguradora, AlinhamentoHorizontal.Esquerda)
                .ComCampo("NÚMERO DA APÓLICE", modeloSeg.NroApolice, AlinhamentoHorizontal.Esquerda)
                .ComLargurasIguais();
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "SEGURO DA VIAGEM";
    }
}
