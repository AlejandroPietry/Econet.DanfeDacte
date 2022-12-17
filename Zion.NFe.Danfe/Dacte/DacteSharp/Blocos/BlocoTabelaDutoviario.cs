using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Modelo;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp.Blocos
{
    internal class BlocoTabelaDutoviario : ElementoBase
    {
        public CabecalhoBloco CabecalhoBloco { get; private set; }
        public Tabela Tabela { get; private set; }
        public DacteViewModel ViewModel { get; private set; }

        public BlocoTabelaDutoviario(DanfeViewModel viewModel, Estilo estilo) : base(estilo)
        {
            CabecalhoBloco = new CabecalhoBloco(estilo, "DADOS DOS PRODUTOS / SERVIÇOS");

            var ad = AlinhamentoHorizontal.Direita;
            var ac = AlinhamentoHorizontal.Centro;
            var ae = AlinhamentoHorizontal.Esquerda;

            Tabela = new Tabela(Estilo);

            Tabela
            .ComColuna(35f, ac, "OBSERVAÇÕES")
            .ComColuna(25, ae, "EMITENTE")
            .ComColuna(20F, ac, "SÉRIE")
            .ComColuna(20F, ac, "NÚMERO");

            Tabela.AjustarLarguraColunas();

            foreach (var p in ViewModel.InformacoesModalDutoviario)
            {
                var linha = new List<String>
                {
                    p.Observacoes,
                    p.Emitente,
                    p.Serie,
                    p.Numero

                };

                Tabela.AdicionarLinha(linha);
            }
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            Tabela.SetPosition(RetanguloTabela.Location);
            Tabela.SetSize(RetanguloTabela.Size);
            Tabela.Draw(gfx);

            CabecalhoBloco.SetPosition(X, Y);
            CabecalhoBloco.Width = Width;
            CabecalhoBloco.Draw(gfx);
        }


        public RectangleF RetanguloTabela => BoundingBox.CutTop(CabecalhoBloco.Height);
        public Boolean CompletamenteDesenhada => Tabela.LinhaAtual == ViewModel.InformacoesModalDutoviario.Count;
        public override bool PossuiContono => false;
    }

}
