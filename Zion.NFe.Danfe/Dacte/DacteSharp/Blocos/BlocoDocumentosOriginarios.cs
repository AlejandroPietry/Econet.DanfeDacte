
using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Graphics;
using Zion.NFe.Danfe.Tools.Extensions;

namespace DacteSharp.Blocos
{
    internal class BlocoDocumentosOriginarios : ElementoBase
    {
        #region Prop
        public CabecalhoBloco CabecalhoBloco { get; private set; }
        public Tabela Tabela1 { get; private set; }
        public Tabela Tabela2 { get; private set; }
        public Tabela TabelaOriginariosPaginacao { get; private set; }
        public Tabela TabelaFerroviarioModal { get; private set; }
        public Tabela TabelaAquaviario { get; private set; }
        public Tabela TabelaPrestacaoServicoOs { get; private set; }
        public DacteViewModel ViewModel { get; private set; }
        #endregion

        #region BlocoDocumentos Originarios
        public BlocoDocumentosOriginarios(DacteViewModel viewModel, Estilo estilo) : base(estilo)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
            CabecalhoBloco = new CabecalhoBloco(estilo, (ViewModel.Modal.Equals(TModTransp.Item01) && ViewModel.Modelo.Equals(TModCT.Item57)) ? "INFORMAÇÕES DA PRESTAÇÃO DO SERVIÇO" : "DOCUMENTOS ORIGINÁRIOS");

            var ae = AlinhamentoHorizontal.Esquerda;
            Tabela1 = new Tabela(Estilo);
            Tabela2 = new Tabela(Estilo);
            CarregaCabecalhoTabela(ae);
            Tabela1.AjustarLarguraColunas();
            Tabela2.AjustarLarguraColunas();

            bool coluna1 = true;
            var col1 = new List<String>();
            var col2 = new List<String>();
            CarregaTipoTabelaDocumentosOriginarios(viewModel, ref coluna1, ref col1, ref col2);
        }
        #endregion

        #region Carrega Tipo Tabela Documentos Originarios
        private void CarregaTipoTabelaDocumentosOriginarios(DacteViewModel viewModel, ref bool coluna1, ref List<string> col1, ref List<string> col2)
        {
            if (ViewModel.DocumentosOriginarios != null && viewModel.DocumentosOriginarios.Count > 0)
            {

                switch (ViewModel.Modal)
                {
                    case TModTransp.Item01:
                        CarregaDocumentosOriginarios(viewModel, ref coluna1, ref col1, ref col2);
                        break;
                    case TModTransp.Item02:
                        CarregaDocumentosOriginarios(viewModel, ref coluna1, ref col1, ref col2);
                        break;
                    case TModTransp.Item03:
                        MontarTabelaAquaviario(viewModel, col1);
                        break;
                    case TModTransp.Item04:
                        MontarTabelaFerroviaria(viewModel, ref coluna1, ref col1, ref col2);
                        break;
                    case TModTransp.Item05:
                        CarregaDocumentosOriginarios(viewModel, ref coluna1, ref col1, ref col2);
                        break;
                    case TModTransp.Item06:
                        CarregaDocumentosOriginarios(viewModel, ref coluna1, ref col1, ref col2);
                        break;
                    default:
                        break;
                }
            }
            else if (ViewModel.Modal.Equals(TModTransp.Item01) && ViewModel.Modelo.Equals(TModCT.Item67))
                MontarTabelaRodoviarioOS(viewModel, ref coluna1, ref col1, ref col2);
            else if (ViewModel.Modal.Equals(TModTransp.Item03))
                MontarTabelaAquaviario(viewModel, col1);
        }
        #endregion

        #region Montar Tabela Ferroviaria
        private void MontarTabelaFerroviaria(DacteViewModel viewModel, ref bool coluna1, ref List<string> col1, ref List<string> col2)
        {
            TabelaOriginariosPaginacao = new Tabela(Estilo);
            TabelaOriginariosPaginacao
                .ComColuna(25f, AlinhamentoHorizontal.Esquerda, "TIPO DOCUMENTO")
                .ComColuna(25f, AlinhamentoHorizontal.Esquerda, "CNPJ/CPF EMITENTE")
                .ComColuna(25f, AlinhamentoHorizontal.Esquerda, "SÉRIE")
                .ComColuna(25f, AlinhamentoHorizontal.Esquerda, "Nº DOCUMENTO");

            TabelaOriginariosPaginacao.AjustarLarguraColunas();
            CarregaDocumentosOriginariosFerroviario(viewModel, ref coluna1, ref col1, ref col2);
        }
        #endregion

        #region  Montar Tabela RodoviarioOS
        private void MontarTabelaRodoviarioOS(DacteViewModel viewModel, ref bool coluna1, ref List<string> col1, ref List<string> col2)
        {

            TabelaPrestacaoServicoOs = new Tabela(Estilo);
            TabelaPrestacaoServicoOs
                .ComColuna(20f, AlinhamentoHorizontal.Esquerda, "QUANTIDADE")
                .ComColuna(80f, AlinhamentoHorizontal.Esquerda, "DESCRIÇÃO DO SERVIÇO PRESTADO");
            TabelaPrestacaoServicoOs.AjustarLarguraColunas();
            CarregaInformacoesPrestacaoServico(viewModel, ref col1);

        }
        #endregion

        #region Carrega Informações Prestação do Serviço
        private void CarregaInformacoesPrestacaoServico(DacteViewModel viewModel, ref List<string> col1)
        {
            //if (viewModel.PrestacoesServicosOS == null)
            //    viewModel.PrestacoesServicosOS = new DacteViewModel.PrestacaoServico();

            col1 = new List<String>
            {
               string.IsNullOrEmpty(viewModel.PrestacoesServicosOS.Quantidade) ? "-" :viewModel.PrestacoesServicosOS.Quantidade,
               string.IsNullOrEmpty(viewModel.PrestacoesServicosOS.DescricaoServico) ? "-" : viewModel.PrestacoesServicosOS.DescricaoServico
            };
            TabelaPrestacaoServicoOs.AdicionarLinha(col1);
        }
        #endregion

        #region Montar Tabela Aquaviario
        private List<string> MontarTabelaAquaviario(DacteViewModel viewModel, List<string> col1)
        {
            TabelaAquaviario = new Tabela(Estilo);
            TabelaAquaviario
                .ComColuna(15f, AlinhamentoHorizontal.Esquerda, "TP DOC")
                .ComColuna(15f, AlinhamentoHorizontal.Esquerda, "CNPJ/CPF EMITENTE")
                .ComColuna(25f, AlinhamentoHorizontal.Esquerda, "SÉRIE/NRO.DOCUMENTO")
                .ComColuna(25f, AlinhamentoHorizontal.Esquerda, "NRO.LACRE")
                .ComColuna(20f, AlinhamentoHorizontal.Esquerda, "NRO.CONTEINER");
            TabelaAquaviario.AjustarLarguraColunas();
            CarregaDocumentosOriginariosAquaviario(viewModel, ref col1);
            return col1;
        }
        #endregion

        #region Carrega Documento sOriginarios Aquaviario
        /// <summary>
        /// No caso de modal aquaviário, fica dispensada a impressão do quadro DOCUMENTOS
        /// ORIGINÁRIOS, no que se refere às informações advindas do grupo infNF – informações
        /// das NF ou, infNFe – informações das NF-e ou, infOutros – informações dos demais
        /// documentos, desde que, em sua substituição, seja impresso na parte do DACTE que trata
        /// especificamente do modal aquaviário o conteúdo das informações requeridas no grupo
        /// detCont – Grupo de informações de detalhamento dos contêiner
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="col1"></param>
        private void CarregaDocumentosOriginariosAquaviario(DacteViewModel viewModel, ref List<string> col1)
        {
            if (viewModel.InformacoesModalAquaviario.listaContainer != null)
            {
                foreach (var docOrigin in viewModel.InformacoesModalAquaviario.listaContainer)
                {
                    col1 = new List<String>
                        {
                          docOrigin.tipoDocumento,
                          docOrigin.cnpjEmit,
                          docOrigin.SerieNro,
                          docOrigin.lacre,
                          docOrigin.idContainer
                        };
                    TabelaAquaviario.AdicionarLinha(col1);
                }
            }
        }
        #endregion

        #region Carrega Cabecalho de Tabela Documentos Originários
        private void CarregaCabecalhoTabela(AlinhamentoHorizontal ae)
        {
            if (ViewModel.IsRetrato)
            {
                Tabela1
                .ComColuna(50f, ae, $"{("TIPO DOC")}{("CNPJ/CHAVE/OBS").PadLeft(30, ' ')}{("SÉRIE/NRO. DOCUMENTO").PadLeft(85, ' ')}");
                Tabela2
                .ComColuna(Tabela1.Width + 50f, ae, $"{("TIPO DOC")}{("CNPJ/CHAVE/OBS").PadLeft(30, ' ')}{("SÉRIE/NRO. DOCUMENTO").PadLeft(85, ' ')}");
            }
        }
        #endregion

        #region Carrega Documentos Originarios
        /// <summary>
        /// Carregamento dos documentos originários, distribuindo valores entre a coluna 1 e 2 com paginação
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="coluna1">Booleano para identificar qual coluna será preenchida </param>
        /// <param name="col1">Lista de string para coluna 1 da tabela</param>
        /// <param name="col2">Lista de string para coluna 2 da tabela</param>
        private void CarregaDocumentosOriginarios(DacteViewModel viewModel, ref bool coluna1, ref List<string> col1, ref List<string> col2)
        {
            foreach (var p in viewModel.DocumentosOriginarios)
            {
                if (coluna1)
                {
                    col1 = new List<String>
                        {
                            $"{string.Concat(p.tipoDoc!=null? p.tipoDoc.PadRight(30,' '): string.Empty.PadRight(60,' '), p.chave!=null? p.chave.PadLeft(35, ' ') :string.Empty.PadLeft(40,' '), p.nfeChave != null ? p.nfeChave.PadLeft(28, ' '): string.Empty.PadLeft(40,' '))}"
                        };
                    Tabela1.AdicionarLinha(col1);
                    coluna1 = false;
                }
                else if (!coluna1)
                {
                    col2 = new List<String>
                        {
                            $"{string.Concat(p.tipoDoc!=null? p.tipoDoc.PadRight(30,' '): string.Empty.PadRight(60,' '), p.chave!=null? p.chave.PadLeft(35, ' ') :string.Empty.PadLeft(40,' '), p.nfeChave != null ? p.nfeChave.PadLeft(28, ' '): string.Empty.PadLeft(40,' '))}"
                        };
                    Tabela2.AdicionarLinha(col2);
                    coluna1 = true;
                }
            }
        }
        #endregion

        #region Carrega Documentos Originarios Ferroviario
        /// <summary>
        /// Primeira página com 8 registros, nas páginas seguintes carregamento de outra tabela
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="coluna1"></param>
        /// <param name="col1"></param>
        /// <param name="col2"></param>
        private void CarregaDocumentosOriginariosFerroviario(DacteViewModel viewModel, ref bool coluna1, ref List<string> col1, ref List<string> col2)
        {
            foreach (var p in viewModel.DocumentosOriginarios)
            {
                //soma de total dos valores da primeira página. 8 registros
                var totalRegistros = Tabela1.Linhas.Count + Tabela2.Linhas.Count;

                if (totalRegistros <= 5)
                {
                    if (coluna1)
                    {
                        col1 = new List<String>
                        {
                            $"{string.Concat(p.tipoDoc!=null? p.tipoDoc.PadRight(30,' '): string.Empty.PadRight(60,' '), p.chave!=null? p.chave.PadLeft(35, ' ') :string.Empty.PadLeft(40,' '), p.nfeChave != null ? p.nfeChave.PadLeft(28, ' '): string.Empty.PadLeft(40,' '))}"
                        };
                        Tabela1.AdicionarLinha(col1);
                        coluna1 = false;
                    }
                    else if (!coluna1)
                    {
                        col2 = new List<String>
                        {
                            $"{string.Concat(p.tipoDoc!=null? p.tipoDoc.PadRight(30,' '): string.Empty.PadRight(60,' '), p.chave!=null? p.chave.PadLeft(35, ' ') :string.Empty.PadLeft(40,' '), p.nfeChave != null ? p.nfeChave.PadLeft(28, ' '): string.Empty.PadLeft(40,' '))}"
                        };
                        Tabela2.AdicionarLinha(col2);
                        coluna1 = true;
                    }
                }
                else
                {
                    col1 = new List<String>
                    {
                        p.tipoDoc,
                        p.chave,
                        p.nfeChave,
                        p.doc
                    };
                    TabelaOriginariosPaginacao.AdicionarLinha(col1);
                }
            }
        }
        #endregion

        #region Draw
        /// <summary>
        /// Após montagem das tabelas é desenhado de acordo com as dimensões do Retângulo
        /// 
        /// </summary>
        /// <param name="gfx"></param>
        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);
            var rp2 = BoundingBox.CutTop(CabecalhoBloco.Height);
            var rectEs = new RectangleF(RetanguloTabela.X + 101F, RetanguloTabela.Y, RetanguloTabela.Width, RetanguloTabela.Height);
            var rectPos = new RectangleF(RetanguloTabela.X, RetanguloTabela.Y, RetanguloTabela.Width, RetanguloTabela.Height);

            if (ViewModel.Modal == TModTransp.Item01 && ViewModel.Modelo.Equals(TModCT.Item67))
            {
                TabelaPrestacaoServicoOs.SetPosition(RetanguloTabela.Location);
                TabelaPrestacaoServicoOs.SetSize(RetanguloTabela.Size);
                TabelaPrestacaoServicoOs.Draw(gfx);
            }
            else if (ViewModel.Modal == TModTransp.Item03)
            {
                TabelaAquaviario.SetPosition(RetanguloTabela.Location);
                TabelaAquaviario.SetSize(RetanguloTabela.Size);
                TabelaAquaviario.Draw(gfx);
            }
            else if (ViewModel.Modal == TModTransp.Item04)
                CarregaTabelaPagFerroviario(gfx, rectPos, rectEs);
            else
            {
                Tabela1.SetPosition(RetanguloTabela.Location);
                Tabela1.SetSize(RetanguloTabela.Size);
                Tabela1.Draw(gfx);
                Tabela2.SetPosition(rectEs.Location);
                Tabela2.SetSize(RetanguloTabela.Size);
                Tabela2.Draw(gfx);
            }
            CabecalhoBloco.SetPosition(X, Y);
            CabecalhoBloco.Width = Width;
            CabecalhoBloco.Draw(gfx);
        }
        #endregion

        #region Carrega Tabela Ferroviário
        /// <summary>
        /// Montagem para desenho de tabela de modal Ferroviário paginado.
        /// Conforme leiaute é necessário o carregamento diferenciado de tabelas de modal Ferroviário em paginação
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="rectPos"></param>
        /// <param name="rectEs"></param>
        private void CarregaTabelaPagFerroviario(Gfx gfx, RectangleF rectPos, RectangleF rectEs)
        {
            if (ViewModel.NumeroPaginas == 1)
            {
                Tabela1.SetPosition(RetanguloTabela.Location);
                Tabela1.SetSize(RetanguloTabela.Size);
                Tabela1.Draw(gfx);
                Tabela2.SetPosition(rectEs.Location);
                Tabela2.SetSize(RetanguloTabela.Size);
                Tabela2.Draw(gfx);
            }
            else
            {
                TabelaOriginariosPaginacao.SetPosition(rectPos.Location);
                TabelaOriginariosPaginacao.SetSize(RetanguloTabela.Size);
                TabelaOriginariosPaginacao.Draw(gfx);
            }
        }
        #endregion

        public RectangleF RetanguloTabela => BoundingBox.CutTop(CabecalhoBloco.Height);

        public Boolean CompletamenteDesenhada => TotalQuantidadeTabelas();

        private bool TotalQuantidadeTabelas()
        {

            switch (ViewModel.Modal)
            {
                case TModTransp.Item01:
                    if (ViewModel.Modelo.Equals(TModCT.Item67))
                        return TabelaPrestacaoServicoOs.LinhaAtual == (ViewModel.DadosInformacoesOS != null ? 1 : 0);
                    else
                        return Tabela1.LinhaAtual + Tabela2.LinhaAtual == (ViewModel.DocumentosOriginarios != null ? ViewModel.DocumentosOriginarios.Count : 0);
                case TModTransp.Item02:
                    return Tabela1.LinhaAtual + Tabela2.LinhaAtual == (ViewModel.DocumentosOriginarios != null ? ViewModel.DocumentosOriginarios.Count : 0);
                case TModTransp.Item03:
                    return TabelaAquaviario.LinhaAtual == (ViewModel.InformacoesModalAquaviario.listaContainer != null ? ViewModel.InformacoesModalAquaviario.listaContainer.Count : 0);
                case TModTransp.Item04:
                    if (Tabela1.LinhaAtual + Tabela2.LinhaAtual == 6)
                        return TabelaOriginariosPaginacao.LinhaAtual + 6 == (ViewModel.DocumentosOriginarios != null ? ViewModel.DocumentosOriginarios.Count : 0);
                    else
                        return Tabela1.LinhaAtual + Tabela2.LinhaAtual == (ViewModel.DocumentosOriginarios != null ? ViewModel.DocumentosOriginarios.Count : 0);
                default:
                    return Tabela1.LinhaAtual + Tabela2.LinhaAtual == (ViewModel.DocumentosOriginarios != null ? ViewModel.DocumentosOriginarios.Count : 0);
            }
        }
        public override bool PossuiContono => true;
    }
}
