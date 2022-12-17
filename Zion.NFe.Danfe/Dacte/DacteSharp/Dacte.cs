using DacteSharp;
using DacteSharp.Blocos;
using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using org.pdfclown.documents;
using org.pdfclown.documents.contents.fonts;
using org.pdfclown.files;
using System;
using System.Collections.Generic;
using Zion.NFe.Danfe.Dacte.ModelCte;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;

namespace ECONET.EcoNFe2.Negocio.Dacte
{
    public class Dacte : IDisposable
    {
        public DacteViewModel ViewModel { get; private set; }
        public File File { get; private set; }
        internal Document PdfDocument { get; private set; }
        internal BlocoCanhotoDacte Canhoto { get; private set; }
        internal BlocoCanhotoAereo CanhotoAereo { get; private set; }
        internal BlocoIdentificacaoEmitenteDacte IdentificacaoEmitente { get; private set; }
        internal List<BlocoBaseDacte> _Blocos;
        internal Estilo EstiloPadrao { get; private set; }
        internal List<DactePagina> Paginas { get; private set; }
        private StandardType1Font _FonteRegular;
        private StandardType1Font _FonteNegrito;
        private StandardType1Font _FonteItalico;
        private StandardType1Font.FamilyEnum _FonteFamilia;
        private Boolean _FoiGerado;
        private org.pdfclown.documents.contents.xObjects.XObject _LogoObject = null;

        public Dacte(DacteViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
            _Blocos = new List<BlocoBaseDacte>();
            File = new File();
            PdfDocument = File.Document;
            ViewModel.Orientacao = Orientacao.Retrato;

            // De acordo com o item 7.7, a fonte deve ser Times New Roman ou Courier New.
            _FonteFamilia = StandardType1Font.FamilyEnum.Times;
            _FonteRegular = new StandardType1Font(PdfDocument, _FonteFamilia, false, false);
            _FonteNegrito = new StandardType1Font(PdfDocument, _FonteFamilia, true, false);
            _FonteItalico = new StandardType1Font(PdfDocument, _FonteFamilia, false, true);

            EstiloPadrao = CriarEstilo();
            var mod = viewModel.Modelo;
            var tipo = viewModel.Modal;
            Paginas = new List<DactePagina>();

            CarregarTipoDacte(mod, tipo);

            AdicionarMetadata();

            _FoiGerado = false;
        }

        private void CarregarTipoDacte(TModCT mod, TModTransp tipo)
        {
            try
            {
                switch (tipo)
                {
                    case TModTransp.Item01:
                        if (mod == TModCT.Item57)
                            CarregaRodo();
                        else if (mod == TModCT.Item67)
                            CarregaRodoOS();
                        break;
                    case TModTransp.Item02:
                        if (mod == TModCT.Item57)
                            CarregaAereo();
                        break;
                    case TModTransp.Item03:
                        if (mod == TModCT.Item57)
                            CarregaAquaviario();
                        break;
                    case TModTransp.Item04:
                        if (mod == TModCT.Item57)
                            CarregaFerroviario();
                        break;
                    case TModTransp.Item05:
                        if (mod == TModCT.Item57)
                            CarregaDutoviario();
                        break;
                    case TModTransp.Item06:
                        if (mod == TModCT.Item57)
                            CarregaMultimodal();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void CarregaMultimodal()
        {
            Canhoto = CriarBloco<BlocoCanhotoDacte>();
            IdentificacaoEmitente = AdicionarBloco<BlocoIdentificacaoEmitenteDacte>();
            AdicionarBloco<BlocoPrestacao>();
            AdicionarBloco<BlocoDestinatarioRemetenteDacte>();
            AdicionarBloco<BlocoTomador>();
            AdicionarBloco<BlocoInformacoesCarga>();
            AdicionarBloco<BlocoComponentesPrestacaoServico>();
            AdicionarBloco<BlocoUsoEmissorFisco>();
            //blocos que ficam na base do relatório(ordem desc)
            AdicionarBloco<BlocoDadosInformacoesSeguroMultimodal>();
            AdicionarBloco<BlocoDadosEspecMultimodal>();
            AdicionarBloco<BlocoObservacoes>();
            AdicionarBloco<BlocoPrevisaoFluxoCarga>();
            AdicionarBloco<BlocoInformacoesImposto>();
        }

        private void CarregaDutoviario()
        {
            Canhoto = CriarBloco<BlocoCanhotoDacte>();
            IdentificacaoEmitente = AdicionarBloco<BlocoIdentificacaoEmitenteDacte>();
            AdicionarBloco<BlocoPrestacao>();
            AdicionarBloco<BlocoDestinatarioRemetenteDacte>();
            AdicionarBloco<BlocoTomador>();
            AdicionarBloco<BlocoInformacoesCarga>();
            AdicionarBloco<BlocoComponentesPrestacaoServico>();
            AdicionarBloco<BlocoUsoEmissorFisco>();
            //blocos que ficam na base do relatório(ordem desc)
            AdicionarBloco<BlocoDadosEspecModalDutoviario>();
            AdicionarBloco<BlocoObservacoes>();
            AdicionarBloco<BlocoPrevisaoFluxoCarga>();
            AdicionarBloco<BlocoInformacoesImposto>();
        }

        private void CarregaFerroviario()
        {
            Canhoto = CriarBloco<BlocoCanhotoDacte>();
            IdentificacaoEmitente = AdicionarBloco<BlocoIdentificacaoEmitenteDacte>();
            AdicionarBloco<BlocoPrestacao>();
            AdicionarBloco<BlocoDestinatarioRemetenteDacte>();
            AdicionarBloco<BlocoTomador>();
            AdicionarBloco<BlocoInformacoesCarga>();
            AdicionarBloco<BlocoComponentesPrestacaoServico>();
            AdicionarBloco<BlocoUsoEmissorFisco>();
            //blocos que ficam na base do relatório(ordem desc)
            AdicionarBloco<BlocoDadosEspecModalFerroviario>();
            AdicionarBloco<BlocoObservacoes>();
            AdicionarBloco<BlocoPrevisaoFluxoCarga>();
            AdicionarBloco<BlocoInformacoesImposto>();
        }

        private void CarregaAquaviario()
        {
            Canhoto = CriarBloco<BlocoCanhotoDacte>();
            IdentificacaoEmitente = AdicionarBloco<BlocoIdentificacaoEmitenteDacte>();
            AdicionarBloco<BlocoPrestacao>();
            AdicionarBloco<BlocoDestinatarioRemetenteDacte>();
            AdicionarBloco<BlocoTomador>();
            AdicionarBloco<BlocoInformacoesCarga>();
            AdicionarBloco<BlocoComponentesPrestacaoServico>();
            AdicionarBloco<BlocoUsoEmissorFisco>();
            //blocos que ficam na base do relatório(ordem desc)
            AdicionarBloco<BlocoDadosEspecModalAquaviario>();
            AdicionarBloco<BlocoObservacoes>();
            AdicionarBloco<BlocoPrevisaoFluxoCarga>();
            AdicionarBloco<BlocoInformacoesImposto>();
        }

        private void CarregaAereo()
        {
            CanhotoAereo = CriarBloco<BlocoCanhotoAereo>();
            IdentificacaoEmitente = AdicionarBloco<BlocoIdentificacaoEmitenteDacte>();
            AdicionarBloco<BlocoPrestacao>();
            AdicionarBloco<BlocoDestinatarioRemetenteDacte>();
            AdicionarBloco<BlocoTomador>();
            AdicionarBloco<BlocoInformacoesCarga>();
            AdicionarBloco<BlocoComponentesPrestacaoServico>();
            AdicionarBloco<BlocoUsoEmissorFisco>();
            //blocos que ficam na base do relatório(ordem desc)
            AdicionarBloco<BlocoDadosEspecModalAereo>();
            AdicionarBloco<BlocoObservacoes>();
            AdicionarBloco<BlocoPrevisaoFluxoCarga>();
            AdicionarBloco<BlocoInformacoesImposto>();

        }
        /// <summary>
        /// Bloco referente a carregamento de Modal Rodoviário OS
        /// </summary>
        private void CarregaRodoOS()
        {
            Canhoto = CriarBloco<BlocoCanhotoDacte>();
            IdentificacaoEmitente = AdicionarBloco<BlocoIdentificacaoEmitenteDacte>();
            AdicionarBloco<BlocoPrestacao>();
            AdicionarBloco<BlocoTomador>();
            AdicionarBloco<BlocoUsoEmissorFisco>();
            //blocos que ficam na base do relatório(ordem desc)
            AdicionarBloco<BlocoInformacoesModalRodoOS>();
            AdicionarBloco<BlocoSeguroViagemOS>();
            AdicionarBloco<BlocoObservacoes>();
            AdicionarBloco<BlocoInformacoesImposto>();
            AdicionarBloco<BlocoComponentesPrestacaoServico>();
        }

        private void CarregaRodo()
        {
            Canhoto = CriarBloco<BlocoCanhotoDacte>();
            IdentificacaoEmitente = AdicionarBloco<BlocoIdentificacaoEmitenteDacte>();
            AdicionarBloco<BlocoPrestacao>();
            AdicionarBloco<BlocoDestinatarioRemetenteDacte>();
            AdicionarBloco<BlocoTomador>();
            AdicionarBloco<BlocoInformacoesCarga>();
            AdicionarBloco<BlocoComponentesPrestacaoServico>();
            AdicionarBloco<BlocoUsoEmissorFisco>();
            //blocos que ficam na base do relatório(ordem desc)
            AdicionarBloco<BlocoDadosEspecModalRodo>();
            AdicionarBloco<BlocoObservacoes>();
            AdicionarBloco<BlocoPrevisaoFluxoCarga>();
            AdicionarBloco<BlocoInformacoesImposto>();

        }


        public void AdicionarLogoImagem(System.IO.Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));

            var img = org.pdfclown.documents.contents.entities.Image.Get(stream);
            if (img == null) throw new InvalidOperationException("O logotipo não pode ser carregado, certifique-se que a imagem esteja no formato JPEG não progressivo.");
            _LogoObject = img.ToXObject(PdfDocument);
        }

        public void AdicionarLogoPdf(System.IO.Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));

            using (var pdfFile = new org.pdfclown.files.File(new org.pdfclown.bytes.Stream(stream)))
            {
                _LogoObject = pdfFile.Document.Pages[0].ToXObject(PdfDocument);
            }
        }

        public void AdicionarLogoImagem(String path)
        {
            if (String.IsNullOrWhiteSpace(path)) throw new ArgumentException(nameof(path));

            using (var fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                AdicionarLogoImagem(fs);
            }
        }

        public void AdicionarLogoPdf(String path)
        {
            if (String.IsNullOrWhiteSpace(path)) throw new ArgumentException(nameof(path));

            using (var fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                AdicionarLogoPdf(fs);
            }
        }

        private void AdicionarMetadata()
        {
            var info = PdfDocument.Information;
            info[new org.pdfclown.objects.PdfName("ChaveAcesso")] = ViewModel.CTeNumero;
            info[new org.pdfclown.objects.PdfName("TipoDocumento")] = "DACTE";
            info.CreationDate = DateTime.Now;
            info.Title = "DACTE (Documento Auxiliar do Conhecimento de Transporte Eletrônico)";
        }

        private Estilo CriarEstilo(float tFonteCampoCabecalho = 6, float tFonteCampoConteudo = 10)
        {
            return new Estilo(_FonteRegular, _FonteNegrito, _FonteItalico, tFonteCampoCabecalho, tFonteCampoConteudo);
        }

        public void Gerar()
        {
            if (_FoiGerado) throw new InvalidOperationException("O Dacte já foi gerado.");
            IdentificacaoEmitente.Logo = _LogoObject;
            ViewModel.NumeroPaginas = 1;
            var tabela = new BlocoDocumentosOriginarios(ViewModel, EstiloPadrao);
            int i = 1;
            while (true)
            {
                ViewModel.NumeroPaginas = Paginas.Count + 1;
                DactePagina p = CriarPagina();
                tabela.SetPosition(p.RetanguloCorpo.Location.X, p.RetanguloCorpo.Location.Y);
                tabela.SetSize(p.RetanguloCorpo.Size.Width, p.RetanguloCorpo.Size.Height);
                tabela.Draw(p.Gfx);
                p.Gfx.Stroke();
                p.Gfx.Flush();
                if (tabela.CompletamenteDesenhada) break;
                i++;
            }
            PreencherNumeroFolhas();
            _FoiGerado = true;

        }
        public byte[] ObterPdfBytes(System.IO.Stream stream)
        {
            org.pdfclown.bytes.Stream stream2 = new org.pdfclown.bytes.Stream(stream);
            this.File.Save(stream2, SerializationModeEnum.Incremental);
            return stream2.ToByteArray();
        }
        private DactePagina CriarPagina()
        {
            DactePagina p = new DactePagina(this);
            Paginas.Add(p);
            p.DesenharBlocos(Paginas.Count == 1);
            p.DesenharCreditos();
            //if (ViewModel.TipoAmbiente == 2 || ViewModel.TipoAmbiente == 0)
            //    p.DesenharAvisoHomologacao();
            return p;
        }

        internal T CriarBloco<T>() where T : BlocoBaseDacte
        {
            return (T)Activator.CreateInstance(typeof(T), ViewModel, EstiloPadrao);
        }

        internal T CriarBloco<T>(Estilo estilo) where T : BlocoBaseDacte
        {
            return (T)Activator.CreateInstance(typeof(T), ViewModel, estilo);
        }

        internal T AdicionarBloco<T>() where T : BlocoBaseDacte
        {
            var bloco = CriarBloco<T>();
            _Blocos.Add(bloco);
            return bloco;
        }

        internal T AdicionarBloco<T>(Estilo estilo) where T : BlocoBaseDacte
        {
            var bloco = CriarBloco<T>(estilo);
            _Blocos.Add(bloco);
            return bloco;
        }

        internal void AdicionarBloco(BlocoBaseDacte bloco)
        {
            _Blocos.Add(bloco);
        }

        internal void PreencherNumeroFolhas()
        {
            int nFolhas = Paginas.Count;
            for (int i = 0; i < Paginas.Count; i++)
            {
                Paginas[i].DesenhaNumeroPaginas(i + 1, nFolhas);
            }
        }

        public void Salvar(String path)
        {
            if (String.IsNullOrWhiteSpace(path)) throw new ArgumentException(nameof(path));

            File.Save(path, SerializationModeEnum.Incremental);
        }

        public void Salvar(System.IO.Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));

            File.Save(new org.pdfclown.bytes.Stream(stream), SerializationModeEnum.Incremental);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    File.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }


        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Danfe() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }

}
