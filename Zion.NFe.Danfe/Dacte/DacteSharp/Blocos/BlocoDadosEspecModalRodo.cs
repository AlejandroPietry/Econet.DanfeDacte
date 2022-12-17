using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoDadosEspecModalRodo : BlocoBaseDacte
    {
        public BlocoDadosEspecModalRodo(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            var modeloModal = viewModel.DadosModalRodoviario;
            AdicionarLinhaCamposTabelas(7, true)
                .ComCampo("RNTRC DA EMPRESA", modeloModal.RNTRC, AlinhamentoHorizontal.Esquerda)
                .ComCampo(null, "ESTE CONHECIMENTO DE TRANSPORTE ATENDE À LEGISLAÇÃO DE TRANSPORTE RODOVIÁRIO EM VIGOR", AlinhamentoHorizontal.Centro)
                .ComLarguras(18, 82);
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "DADOS ESPECÍFICOS DO MODAL RODOVIÁRIO";
    }
}
