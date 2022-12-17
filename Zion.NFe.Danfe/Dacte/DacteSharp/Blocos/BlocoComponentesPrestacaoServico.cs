using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Tools;

namespace DacteSharp.Blocos
{
    internal class BlocoComponentesPrestacaoServico : BlocoBaseDacte
    {
        public Tabela TabelaPrest { get; private set; }
        ValorPrestacaoServico valorPrestacaoServico;
        public BlocoComponentesPrestacaoServico(DacteViewModel viewModel, Estilo campoEstilo) : base(viewModel, campoEstilo)
        {
            var componentes = viewModel.Componente;

            componentes = componentes ?? throw new ArgumentNullException(nameof(componentes));
            FlexibleLine fl1 = new FlexibleLine();
            fl1.Height = 16;
            int aux = 0;
            var novo = 0;
            var totalComponentes = 4 - componentes.Comp.Count;
            var lista = new List<TCTeInfCteVPrestComp>();
            foreach (var componente in componentes.Comp)
            {
                if (aux >= 4)
                {
                    var componenteMaisLinhas = new TCTeInfCteVPrestComp();
                    if (novo >= 4)
                        novo = 0;
                    if (lista != null)
                    {
                        lista.Add(componente);
                        lista.Add(componentes.Comp[novo]);
                        var listaTab = new List<TCTeInfCteVPrestComp>();
                        listaTab.Add(componente);
                        listaTab.Add(componentes.Comp[novo]);
                        valorPrestacaoServico = new ValorPrestacaoServico(campoEstilo, listaTab);
                        fl1.ComElemento(valorPrestacaoServico);
                    }
                    novo++;
                }
                aux++;
            }

            var listaIndex = componentes.Comp.Where(x => !lista.Any(n => n.xNome.Equals(x.xNome))).ToList();
            foreach (var comp in listaIndex)
            {
                valorPrestacaoServico = new ValorPrestacaoServico(campoEstilo, comp);
                fl1.ComElemento(valorPrestacaoServico);
            }

            if (totalComponentes > 0)
            {
                var component = new TCTeInfCteVPrestComp();
                for (int i = 0; i < totalComponentes; i++)
                {
                    component.vComp = " ";
                    component.xNome = " ";
                    valorPrestacaoServico = new ValorPrestacaoServico(campoEstilo, component);
                    fl1.ComElemento(valorPrestacaoServico);
                }
            }

            var vlrTotal = AdicionarLinhaCamposTabelas(8)
               .ComElemento(new Campo("VALOR TOTAL DO SERVIÇO", Formatador.Formatar(double.Parse(componentes.vTPrest.Replace(".", ","))), campoEstilo, AlinhamentoHorizontal.Centro))
               .ComLargurasIguais();

            var vlrReceber = AdicionarLinhaCamposTabelas(8)
                .ComElemento(new Campo("VALOR A RECEBER", Formatador.Formatar(double.Parse(componentes.vRec.Replace(".", ","))), campoEstilo, AlinhamentoHorizontal.Centro))
               .ComLargurasIguais();

            var coluna1 = new VerticalStack();
            coluna1.Add(vlrTotal, vlrReceber);

            fl1.ComElemento(coluna1);
            fl1.ComLargurasIguais();
            MainVerticalStack.Add(fl1);
        }

        public Boolean CompletamenteDesenhada => TabelaPrest.LinhaAtual == ViewModel.Componente.Comp.Count;
        public override bool PossuiContono => false;
        public override PosicaoBloco Posicao => ViewModel.Modelo.Equals(TModCT.Item67) ? PosicaoBloco.Base : PosicaoBloco.Topo;
        public override string Cabecalho => "COMPONENTES DO VALOR DA PRESTAÇÃO DO SERVIÇO";
    }
}
