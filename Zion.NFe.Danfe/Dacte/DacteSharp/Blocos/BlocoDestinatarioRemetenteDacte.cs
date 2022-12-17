using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace DacteSharp.Blocos
{
    internal class BlocoDestinatarioRemetenteDacte : BlocoBaseDacte
    {
        public const float LarguraCampoChaveNFe = 93F;
        public const float AlturaLinha1 = 30;
        public const float AlturaColuna3Linha1 = 12.9F;
        Rementente remetenteEmitente;
        Destinatario destinatario;
        Expedidor expedidor;
        Recebedor recebedor;

        public BlocoDestinatarioRemetenteDacte(DacteViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {

            remetenteEmitente = new Rementente(estilo, ViewModel);
            destinatario = new Destinatario(estilo, ViewModel);
            expedidor = new Expedidor(estilo, viewModel);
            recebedor = new Recebedor(estilo, viewModel);

            FlexibleLine fl1 = new FlexibleLine() { Height = 23.5F }
                        .ComElemento(remetenteEmitente)
                        .ComElemento(destinatario)
                        .ComLarguras(50F, 50F);
            MainVerticalStack.Add(fl1);

            FlexibleLine fl2 = new FlexibleLine() { Height = 23.5F }
                        .ComElemento(expedidor)
                        .ComElemento(recebedor)
                        .ComLarguras(50F, 50F);
            MainVerticalStack.Add(fl2);
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Topo;

    }

}
