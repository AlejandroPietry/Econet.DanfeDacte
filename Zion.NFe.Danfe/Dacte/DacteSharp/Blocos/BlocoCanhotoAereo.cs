using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;

namespace DacteSharp.Blocos
{
    internal class BlocoCanhotoAereo : BlocoBaseDacte
    {
        public const float TextoRecebimentoAltura = 10;
        public const float AlturaLinha2 = 12;

        public BlocoCanhotoAereo(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            Fonte f3 = Estilo.CriarFonteRegular(8);
            Fonte f2 = Estilo.CriarFonteRegular(5);
            Estilo es = estilo;
            es.CriarFonteNegrito(12);
            var textoRecebimento = new TextoSimples(estilo, viewModel.TextoRecebimento) { Height = TextoRecebimentoAltura, TamanhoFonte = 8, AlinhamentoHorizontal = AlinhamentoHorizontal.Centro };
            var nomeAssinatura = new NomeAssinaturaCanhotoAereo(estilo) { Height = 8, Width = 30 };
            var textoCanhotoaereo = new TextoCanhotoAereo(estilo) { Height = 7, Width = 30 };
            var blocoColuna1 = AdicionarLinhaCamposTabelas(5)
               .ComElemento(new Campo("EXPEDIDOR/REMETENTE", null, es, AlinhamentoHorizontal.Centro))
               .ComElemento(new Campo(" ", null, estilo, AlinhamentoHorizontal.Centro))
               .ComLarguras(85f, 15f);

            var dest = AdicionarLinhaCamposTabelas(5)
               .ComElemento(new Campo("DESTINATÁRIO/RECEBEDOR", null, es, AlinhamentoHorizontal.Centro))
               .ComElemento(new Campo(" ", null, estilo, AlinhamentoHorizontal.Centro))
               .ComLarguras(85f, 15f);

            var coluna1 = new VerticalStack();
            coluna1.Add(blocoColuna1, dest);

            var linhaColunas = new FlexibleLine() { Height = coluna1.Height }
                .ComElemento(coluna1)
                .ComElemento(nomeAssinatura)
                .ComLarguras(19, 81);

            var Linhainformacoes = AdicionarLinhaCamposTabelas(8)
              .ComElemento(new Campo("NUMERO OPERACIONAL", null, estilo, AlinhamentoHorizontal.Centro))
              .ComElemento(new Campo("CHAVE DE ACESSO", null, estilo, AlinhamentoHorizontal.Centro))
              .ComElemento(new Campo("DATA E HORA DA EMISSÃO ", null, estilo, AlinhamentoHorizontal.Centro))
              .ComLarguras(30, 35, 35);

            MainVerticalStack.Add(textoCanhotoaereo, linhaColunas, Linhainformacoes, new LinhaTracejada(2));
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override string Cabecalho => "DECLARO QUE RECEBI OS VOLUMES DESTE CONHECIMENTO EM PERFEITO ESTADO PELO QUE DOU POR CUMPRIDO O PRESENTE CONTRATO DE TRANSPORTE";

    }
}
