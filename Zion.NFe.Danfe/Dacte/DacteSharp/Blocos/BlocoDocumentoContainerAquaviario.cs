
using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System;
using System.Drawing;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp.Blocos
{
    internal class BlocoDocumentoContainerAquaviario : ElementoBase
    {
        public CabecalhoBloco CabecalhoBloco { get; private set; }
        public Tabela Tabela { get; private set; }
        public Tabela Tabela2 { get; private set; }
        public DacteViewModel ViewModel { get; private set; }

        public BlocoDocumentoContainerAquaviario(DacteViewModel viewModel, Estilo estilo) : base(estilo)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
            CabecalhoBloco = new CabecalhoBloco(estilo, "DETALHAMENTO DO CONTAINER - INFORMAÇÕES ESPECÍFICAS DO MODAL AQUAVIÁRIO(I)");

            var ae = AlinhamentoHorizontal.Esquerda;
            var ad = AlinhamentoHorizontal.Direita;

            Tabela = new Tabela(Estilo);
            Tabela2 = new Tabela(Estilo);

            if (ViewModel.IsRetrato)
            {
                Tabela
                .ComColuna(16.6f, ae, "LACRE")
                .ComColuna(16.6f, ae, "IDENTIFICAÇÃO DO CONTAINER");
            }

            Tabela.AjustarLarguraColunas();
            foreach (var index in ViewModel.InformacoesModalAquaviario.listaContainer)
            {
                var texto = string.Concat(index.lacre, " -", index.idContainer);
            }


            //foreach (var p in viewModel.DocumentosOriginarios)
            //{
            //    var linha = new List<String>
            //    {
            //        p.tipoDoc,
            //        p.cnpj,
            //        p.nfeChave
            //    };

            //    Tabela.AdicionarLinha(linha);
            //}
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

        public Boolean CompletamenteDesenhada => Tabela.LinhaAtual == 100;
        public override bool PossuiContono => false;
    }
}
