using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoDadosEspecModalAquaviario : BlocoBaseDacte
    {
        public BlocoDadosEspecModalAquaviario(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            var modeloModal = viewModel.InformacoesModalAquaviario;
            AdicionarLinhaCamposTabelas(10, true)
             .ComCampo("IDENTIFICAÇÃO DO NAVIO/REBOCADOR", modeloModal.IndentificacaoNavio, AlinhamentoHorizontal.Centro)
             .ComCampo("IDENTIFICAÇÃO DA BALSA", modeloModal.IdentificacaoBalsa, AlinhamentoHorizontal.Centro)
             .ComCampo("VLR. DO AFRMM", modeloModal.ValorAfrmm, AlinhamentoHorizontal.Centro)
             .ComLargurasIguais();

        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "INFORMAÇÕES ESPECÍFICAS DO MODAL AQUAVIÁRIO";
    }
}
