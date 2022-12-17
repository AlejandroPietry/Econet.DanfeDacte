using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp.Blocos
{
    internal class BlocoCanhotoDacte : BlocoBaseDacte
    {
        public const float TextoRecebimentoAltura = 10;
        public const float AlturaLinha2 = 12;

        public BlocoCanhotoDacte(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            Fonte f3 = Estilo.CriarFonteRegular(8);
            var retangulo = BoundingBox.InflatedRetangle(1F, 0.5F, 4);
            var textoRecebimento = new TextoSimples(estilo, viewModel.TextoRecebimento) { Height = TextoRecebimentoAltura, TamanhoFonte = 8, AlinhamentoHorizontal = AlinhamentoHorizontal.Centro };
            var nfe = new NumeroNfSerie(estilo, viewModel.CTeNumero.ToString(), viewModel.Serie.ToString()) { Height = AlturaLinha2, Width = 30 };
            var carimbo = new Carimbo(estilo) { Height = AlturaLinha2, Width = 30 };
            var inicFim = new InicioTerminoPrestacao(estilo) { Height = AlturaLinha2, Width = 30 };

            var blocolinha1 = AdicionarLinhaCamposTabelas(10)
               .ComElemento(new Campo("NOME", null, estilo, AlinhamentoHorizontal.Centro))
               .ComLargurasIguais();

            var rg = AdicionarLinhaCamposTabelas(10)
                .ComElemento(new Campo("RG", null, estilo, AlinhamentoHorizontal.Centro))
               .ComLargurasIguais();

            var coluna1 = new VerticalStack();
            coluna1.Add(blocolinha1, rg);

            var coluna2 = new VerticalStack();
            coluna2.Add(carimbo);

            var linha = new FlexibleLine() { Height = coluna1.Height }
                 .ComElemento(coluna1)
                 .ComElemento(carimbo)
                 .ComElemento(inicFim)
                 .ComElemento(nfe)
                 .ComLarguras(0, 30, 35, 15);

            MainVerticalStack.Add(linha, new LinhaTracejada(2));
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override string Cabecalho => "DECLARO QUE RECEBI OS VOLUMES DESTE CONHECIMENTO EM PERFEITO ESTADO PELO QUE DOU POR CUMPRIDO O PRESENTE CONTRATO DE TRANSPORTE";

    }
}
