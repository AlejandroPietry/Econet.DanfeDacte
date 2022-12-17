using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoPrevisaoFluxoCarga : BlocoBaseDacte
    {
        public BlocoPrevisaoFluxoCarga(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            var tipo = viewModel.Modal;
            var fluxo = viewModel.DadosFluxoViewModel;
            //if (fluxo == null)
            //    fluxo = new DadosFluxoViewModel();
            AdicionarLinhaCampos(true)
            .ComCampo("SIGLA OU CÓD.INT.DA FILIAL/PORTO/ESTAÇÃO/AEROPORTO DE ORIGEM", fluxo.Origem, AlinhamentoHorizontal.Esquerda)
            .ComCampo("SIGLA OU CÓD.INT.DA FILIAL/PORTO/ESTAÇÃO/AEROPORTO DE PASSAGEM", fluxo.Passagem, AlinhamentoHorizontal.Esquerda)
            .ComCampo("SIGLA OU CÓD.INT.DA FILIAL/PORTO/ESTAÇÃO/AEROPORTO DE DESTINO", fluxo.Destino, AlinhamentoHorizontal.Esquerda)
            .ComLargurasIguais();
        }
        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "PREVISÃO DO FLUXO DA CARGA";
    }
}
