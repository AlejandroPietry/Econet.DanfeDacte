using org.pdfclown.documents;
using org.pdfclown.documents.contents.fonts;
using org.pdfclown.files;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Drawing;
using System.Text;
using PdfFile = org.pdfclown.files.File;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Nfse.Modelo;
using Zion.NFe.Danfe.Tools.Extensions;

namespace Zion.NFe.Danfe.Nfse
{
        /// <summary>
        /// Documento PDF da NFS-e usando o mesmo motor de composição do DANFE/DACTE.
        /// </summary>
        public class NfseDoc : IDisposable
        {
            public NfseViewModel ViewModel { get; }
        public PdfFile File { get; }
        internal Document PdfDocument { get; }
        internal Estilo EstiloPadrao { get; }

        private readonly List<NfsePagina> _Paginas;
        private readonly StandardType1Font _FonteRegular;
        private readonly StandardType1Font _FonteNegrito;
        private readonly StandardType1Font _FonteItalico;
        private readonly StandardType1Font.FamilyEnum _FonteFamilia;
        private bool _FoiGerado;
        private org.pdfclown.documents.contents.xObjects.XObject _LogoObject;
        internal org.pdfclown.documents.contents.xObjects.XObject LogoObject => _LogoObject;

        public NfseDoc(NfseViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));

            File = new PdfFile();
            PdfDocument = File.Document;
            _Paginas = new List<NfsePagina>();

            _FonteFamilia = StandardType1Font.FamilyEnum.Times;
            _FonteRegular = new StandardType1Font(PdfDocument, _FonteFamilia, false, false);
            _FonteNegrito = new StandardType1Font(PdfDocument, _FonteFamilia, true, false);
            _FonteItalico = new StandardType1Font(PdfDocument, _FonteFamilia, false, true);

            EstiloPadrao = new Estilo(_FonteRegular, _FonteNegrito, _FonteItalico, 6, 9);
            AdicionarMetadata();
        }

        public void AdicionarLogoImagem(Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));

            var img = org.pdfclown.documents.contents.entities.Image.Get(stream);
            if (img == null) throw new InvalidOperationException("O logotipo não pode ser carregado, certifique-se que a imagem esteja no formato JPEG não progressivo.");
            _LogoObject = img.ToXObject(PdfDocument);
        }

        public void AdicionarLogoImagem(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException(nameof(path));

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                AdicionarLogoImagem(fs);
            }
        }

        private void AdicionarMetadata()
        {
            var info = PdfDocument.Information;
            info[new org.pdfclown.objects.PdfName("ChaveAcesso")] = ViewModel.ChaveAcesso;
            info[new org.pdfclown.objects.PdfName("TipoDocumento")] = "NFSe";
            info.CreationDate = DateTime.Now;
            info.Title = "NFS-e (Nota Fiscal de Serviço Eletrônica)";
        }

        public void Gerar()
        {
            if (_FoiGerado) throw new InvalidOperationException("A NFS-e já foi gerada.");

            var pagina = new NfsePagina(this);
            _Paginas.Add(pagina);

            DesenharConteudo(pagina);
            pagina.DesenharCabecalho();
            pagina.DesenharLimites();
            pagina.DesenharMarcaDagua();
            pagina.DesenharRodape(1, 1);

            _FoiGerado = true;
        }

        private void DesenharConteudo(NfsePagina pagina)
        {
            var stack = new VerticalStack(pagina.RetanguloCorpo.Width)
            {
                X = pagina.RetanguloCorpo.X,
                Y = pagina.RetanguloCorpo.Y
            };

            stack.Add(CriarLinhaIdentificacao());
            stack.Add(CriarLinhaPrestador());
            stack.Add(CriarLinhaTomador());
            stack.Add(CriarDiscriminacao());
            stack.Add(CriarLinhaValores());
            stack.Add(CriarObservacoes());

            stack.Draw(pagina.Gfx);
        }

        private LinhaCampos CriarLinhaIdentificacao()
        {
            var linha = new LinhaCampos(EstiloPadrao, 0, Constantes.CampoAltura);
            linha.ComCampo("Número", ViewModel.Numero)
                .ComCampo("Série", ViewModel.Serie)
                .ComCampo("Emissão", ViewModel.DataHoraEmissao.HasValue ? ViewModel.DataHoraEmissao.Value.ToString("dd/MM/yyyy HH:mm:ss") : string.Empty)
                .ComCampo("Ambiente", ViewModel.IsHomologacao ? "Homologação" : "Produção")
                .ComLarguras(20, 20, 30, 30);
            return linha;
        }

        private CampoMultilinha CriarLinhaPrestador()
        {
            return new CampoMultilinha("Prestador", FormatEmpresa(ViewModel.Prestador), EstiloPadrao);
        }

        private CampoMultilinha CriarLinhaTomador()
        {
            return new CampoMultilinha("Tomador", FormatEmpresa(ViewModel.Tomador), EstiloPadrao);
        }

        private CampoMultilinha CriarDiscriminacao()
        {
            var texto = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(ViewModel.DiscriminacaoServico))
                texto.AppendLine(ViewModel.DiscriminacaoServico);

            if (!string.IsNullOrWhiteSpace(ViewModel.MunicipioPrestacao))
                texto.Append("Município da prestação: ").AppendLine(ViewModel.MunicipioPrestacao);

            if (!string.IsNullOrWhiteSpace(ViewModel.MunicipioIncidencia))
                texto.Append("Município de incidência: ").AppendLine(ViewModel.MunicipioIncidencia);

            return new CampoMultilinha("Discriminação do serviço", texto.ToString().Trim(), EstiloPadrao);
        }

        private LinhaCampos CriarLinhaValores()
        {
            var linha = new LinhaCampos(EstiloPadrao, 0, Constantes.CampoAltura);
            linha.ComCampo("Valor do serviço", FormatCurrency(ViewModel.ValorServico))
                .ComCampo("Deduções", FormatCurrency(ViewModel.ValorDeducoes))
                .ComCampo("Líquido", FormatCurrency(ViewModel.ValorLiquido))
                .ComCampo("ISSQN", FormatCurrency(ViewModel.ValorIssqn))
                .ComLarguras(25, 25, 25, 25);
            return linha;
        }

        private CampoMultilinha CriarObservacoes()
        {
            var texto = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(ViewModel.CodigoVerificacao))
                texto.Append("Código de verificação: ").AppendLine(ViewModel.CodigoVerificacao);

            if (!string.IsNullOrWhiteSpace(ViewModel.ProtocoloAutorizacao))
                texto.Append("Protocolo: ").AppendLine(ViewModel.ProtocoloAutorizacao);

            if (!string.IsNullOrWhiteSpace(ViewModel.InformacoesComplementares))
                texto.Append(ViewModel.InformacoesComplementares);

            return new CampoMultilinha("Informações complementares", texto.ToString().Trim(), EstiloPadrao);
        }

        private static string FormatEmpresa(Zion.NFe.Danfe.Modelo.EmpresaViewModel empresa)
        {
            if (empresa == null) return string.Empty;

            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(empresa.RazaoSocial)) sb.AppendLine(empresa.RazaoSocial);
            if (!string.IsNullOrWhiteSpace(empresa.NomeFantasia)) sb.AppendLine(empresa.NomeFantasia);
            if (!string.IsNullOrWhiteSpace(empresa.CnpjCpf)) sb.AppendLine($"CNPJ/CPF: {empresa.CnpjCpf}");
            if (!string.IsNullOrWhiteSpace(empresa.IM)) sb.AppendLine($"IM: {empresa.IM}");
            if (!string.IsNullOrWhiteSpace(empresa.EnderecoLinha1)) sb.AppendLine(empresa.EnderecoLinha1);
            if (!string.IsNullOrWhiteSpace(empresa.EnderecoLinha2)) sb.AppendLine(empresa.EnderecoLinha2);
            if (!string.IsNullOrWhiteSpace(empresa.EnderecoLinha3)) sb.AppendLine(empresa.EnderecoLinha3);
            if (!string.IsNullOrWhiteSpace(empresa.Email)) sb.AppendLine(empresa.Email);
            if (!string.IsNullOrWhiteSpace(empresa.Telefone)) sb.AppendLine($"Fone: {empresa.Telefone}");

            return sb.ToString().Trim();
        }

        private static string FormatCurrency(decimal? value)
        {
            if (!value.HasValue) return string.Empty;
            return value.Value.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        public void Salvar(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException(nameof(path));
            File.Save(path, SerializationModeEnum.Incremental);
        }

        public void Salvar(Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));
            File.Save(new org.pdfclown.bytes.Stream(stream), SerializationModeEnum.Incremental);
        }

        public byte[] ObterPdfBytes(Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));
            var pdfStream = new org.pdfclown.bytes.Stream(stream);
            File.Save(pdfStream, SerializationModeEnum.Incremental);
            return pdfStream.ToByteArray();
        }

        public void Dispose()
        {
            File.Dispose();
        }
    }
}
