using org.pdfclown.documents.contents.xObjects;
using System;
using System.Collections.Generic;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp
{
    internal class ValorPrestacaoServico : ElementoBase
    {
        private TCTeInfCteVPrestComp componente;
        private List<TCTeInfCteVPrestComp> lista;

        public XObject Logo { get; set; }


        public ValorPrestacaoServico(Estilo estilo, TCTeInfCteVPrestComp componente) : base(estilo)
        {
            this.componente = componente;
        }

        public ValorPrestacaoServico(Estilo estilo, List<TCTeInfCteVPrestComp> lista) : base(estilo)
        {
            this.lista = lista;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);
            var rp = BoundingBox.InflatedRetangle(0.75F);
            Fonte f3 = Estilo.CriarFonteRegular(6);
            var list = new List<TCTeInfCteVPrestComp>();
            list.Add(componente);
            var componentes = lista == null ? list : lista;
            TextStack ts;

            ts = new TextStack(rp) { LineHeightScale = 1.5F };

            ts.AddLine($"{Strings.Nome.PadRight(25, ' ')}{Strings.Valor.PadLeft(39, ' ')}", f3);
            foreach (var indiceComp in componentes)
            {
                ts.AddLine($"{indiceComp.xNome.PadRight(25, ' ')}{(indiceComp.vComp != " " ? Formatador.Formatar(Convert.ToDouble(indiceComp.vComp.Replace(".", ","))).PadLeft(31, ' ') : indiceComp.vComp)}", f3);
            }
            ts.AlinhamentoHorizontal = AlinhamentoHorizontal.Esquerda;
            ts.AlinhamentoVertical = AlinhamentoVertical.Topo;
            ts.Draw(gfx);
        }

        private void AddTS()
        {

        }


    }
}
