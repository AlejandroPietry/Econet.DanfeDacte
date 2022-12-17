using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;

namespace DacteSharp.Blocos
{
    internal class BlocoUsoEmissorFisco : BlocoBaseDacte
    {
        public BlocoUsoEmissorFisco(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            Fonte f2 = Estilo.CriarFonteRegular(5);
            var cabecalhoUso = new CabecalhoCampo(campoEstilo, "USO EXCLUSIVO DO EMISSOR DO CT-E");
            var cabecalhoReservado = new CabecalhoCampo(campoEstilo, "RESERVADO AO FISCO");

            var modeloModal = viewModel.DadosModalObservacao;
            AdicionarLinhaCamposTabelas(3, true)
            .ComElemento(cabecalhoUso)
            .ComElemento(cabecalhoReservado)
            .ComLarguras(63, 37);

            AdicionarLinhaCamposTabelas(10, true)
           .ComElemento(new Campo(" ", modeloModal.ObsUsoEmissor, Estilo, AlinhamentoHorizontal.Centro))
           .ComElemento(new Campo(" ", modeloModal.ObsReservadoFisco, Estilo, AlinhamentoHorizontal.Centro))
           .ComLarguras(63, 37);

        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override bool PossuiContono => false;
    }
}
