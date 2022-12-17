using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System.Linq;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoNaturezaCarga : BlocoBaseDacte
    {
        public BlocoNaturezaCarga(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            var modeloModal = viewModel.InformacoesDadosModalAereo;
            var cabecalhoNaturezaCarga = new CabecalhoCampo(estilo, "NATUREZA DA CARGA");

            var cabecalho = AdicionarLinhaCamposTabelas(2, true)
                 .ComElemento(cabecalhoNaturezaCarga)
                 .ComLarguras(100);
            var dadosNaturezaCarga = AdicionarLinhaCamposTabelas(6, true)
            .ComCampo("DIMENSÃO", modeloModal.NaturezaCarga != null ? modeloModal.NaturezaCarga.First().Dimensao : null, AlinhamentoHorizontal.Centro)
            .ComCampo("INFORMAÇÕES DE MANUSEIO", modeloModal.NaturezaCarga != null ? modeloModal.NaturezaCarga.First().InformacoesManuseio : null, AlinhamentoHorizontal.Centro)
            .ComLarguras(60, 40);

        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "INFORMAÇÕES ESPECÍFICAS DO MODAL AÉREO";
    }
}
