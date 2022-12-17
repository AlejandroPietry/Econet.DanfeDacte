using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System.Linq;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Tools;

namespace DacteSharp.Blocos
{
    internal class BlocoDadosEspecModalDutoviario : BlocoBaseDacte
    {
        public BlocoDadosEspecModalDutoviario(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            var modeloModal = viewModel.InformacoesModalDutoviario.FirstOrDefault();
            AdicionarLinhaCamposTabelas(8, true)
            .ComCampo("VALOR UNITÁRIO", modeloModal.ValorUnitario, AlinhamentoHorizontal.Esquerda)
            .ComCampo("VALOR DO FRETE", modeloModal.ValorFrete, AlinhamentoHorizontal.Centro)
            .ComCampo("OUTROS", modeloModal.Outros, AlinhamentoHorizontal.Centro)
            .ComCampo("BASE DE CÁLCULO", Formatador.Formatar(modeloModal.BaseCalculo), AlinhamentoHorizontal.Centro)
            .ComCampo("ALÍQUOTA", Formatador.Formatar(modeloModal.Aliquota), AlinhamentoHorizontal.Centro)
            .ComLargurasIguais();

            AdicionarLinhaCamposTabelas(8, true)
            .ComCampo("VALOR DO IMPOSTO", Formatador.Formatar(modeloModal.ValorImposto), AlinhamentoHorizontal.Esquerda)
            .ComCampo("VALOR TOTAL DO FRETE", modeloModal.ValorTotalFrete, AlinhamentoHorizontal.Centro)
            .ComCampo("OBSERVAÇÕES", modeloModal.Observacoes, AlinhamentoHorizontal.Centro)
            .ComCampo("EMITENTE", modeloModal.Emitente, AlinhamentoHorizontal.Esquerda)
            .ComCampo("SÉRIE", modeloModal.Serie, AlinhamentoHorizontal.Centro)
            .ComCampo("NÚMERO", modeloModal.Numero, AlinhamentoHorizontal.Centro)
            .ComLarguras(12, 20, 16.6f, 18.2f, 16.6f, 16.6f);
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
        public override string Cabecalho => "INFORMAÇÕES ESPECÍFICAS DO MODAL DUTOVIÁRIO";
    }
}
