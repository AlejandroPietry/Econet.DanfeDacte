using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Tools;

namespace DacteSharp.Blocos
{
    internal class BlocoInformacoesImposto : BlocoBaseDacte
    {

        public BlocoInformacoesImposto(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            var informacoesImposto = viewModel.InformacoesImposto;

            AdicionarLinhaCamposTabelas(10, true)
                .ComCampo("CLASSIFICAÇÃO TRIBUTÁRIA DO SERVIÇO", informacoesImposto.SituacaoTributaria, AlinhamentoHorizontal.Esquerda)
                .ComCampo("BASE DE CÁLCULO", Formatador.Formatar(informacoesImposto.BaseCalculo), AlinhamentoHorizontal.Esquerda)
                .ComCampo("ALÍQ ICMS", Formatador.Formatar(informacoesImposto.AliquotaIcms), AlinhamentoHorizontal.Esquerda)
                .ComCampo("VALOR ICMS ", Formatador.Formatar(informacoesImposto.ValorIcms), AlinhamentoHorizontal.Esquerda)
                .ComCampo("% RED. BC ICMS", Formatador.Formatar(informacoesImposto.RedBcCalcIcms), AlinhamentoHorizontal.Esquerda)
                .ComLarguras(50, 10, 13, 17, 10);
        }
        public override PosicaoBloco Posicao => ViewModel.Modelo.Equals(TModCT.Item67) ? PosicaoBloco.Base : PosicaoBloco.Topo;
        public override bool PossuiContono => false;
        public override string Cabecalho => "INFORMAÇÕES RELATIVAS AO IMPOSTO";
    }
}
