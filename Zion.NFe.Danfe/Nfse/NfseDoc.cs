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
            stack.Add(CriarIdentificacaoDps());
            stack.Add(CriarLinhaPrestador());
            stack.Add(CriarLinhaTomador());
            stack.Add(CriarServicoPrestado());
            stack.Add(CriarTributacaoMunicipal());
            stack.Add(CriarTributacaoFederal());
            stack.Add(CriarTotais());
            stack.Add(CriarTotaisTributos());
            stack.Add(CriarObservacoes());

            stack.Draw(pagina.Gfx);
        }

        private CampoMultilinha CriarIdentificacaoDps()
        {
            var texto = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(ViewModel.ChaveAcesso))
                texto.Append("Chave de Acesso da NFS-e: ").AppendLine(ViewModel.ChaveAcesso);
            if (!string.IsNullOrWhiteSpace(ViewModel.CodigoVerificacao))
                texto.Append("Código de autenticação: ").AppendLine(ViewModel.CodigoVerificacao);
            return new CampoMultilinha("Identificação", texto.ToString().Trim(), EstiloPadrao);
        }

        private LinhaCampos CriarLinhaIdentificacao()
        {
            var linha = new LinhaCampos(EstiloPadrao, 0, Constantes.CampoAltura);
            linha.ComCampo("Número da NFS-e", ViewModel.Numero)
                .ComCampo("Competência", ViewModel.Competencia.HasValue ? ViewModel.Competencia.Value.ToString("dd/MM/yyyy") : string.Empty)
                .ComCampo("Data e hora de emissão", ViewModel.DataHoraEmissao.HasValue ? ViewModel.DataHoraEmissao.Value.ToString("dd/MM/yyyy HH:mm:ss") : string.Empty)
                .ComCampo("Número da DPS", ViewModel.NumeroDps)
                .ComCampo("Série da DPS", ViewModel.SerieDps)
                .ComLarguras(20, 20, 25, 20, 15);
            return linha;
        }

        private CampoMultilinha CriarLinhaPrestador()
        {
            var texto = new StringBuilder();
            texto.Append("CNPJ / CPF / NIF: ").AppendLine(ViewModel.Prestador.CnpjCpf);
            texto.Append("Inscrição Municipal: ").AppendLine(ViewModel.Prestador.IM);
            texto.Append("Telefone: ").AppendLine(ViewModel.Prestador.Telefone);
            texto.Append("Nome / Nome Empresarial: ").AppendLine(ViewModel.Prestador.RazaoSocial);
            texto.Append("E-mail: ").AppendLine(ViewModel.Prestador.Email);
            texto.Append("Endereço: ").AppendLine(BuildEndereco(ViewModel.Prestador));
            texto.Append("Município: ").AppendLine(ViewModel.Prestador.Municipio);
            texto.Append("CEP: ").AppendLine(ViewModel.Prestador.EnderecoCep);
            texto.Append("Simples Nacional na Data de Competência: ").AppendLine(ViewModel.DescricaoSimplesNacional);
            texto.Append("Regime de Apuração Tributária pelo SN: ").AppendLine(ViewModel.DescricaoRegimeEspecial);
            return new CampoMultilinha("EMITENTE DA NFS-e", texto.ToString().Trim(), EstiloPadrao);
        }

        private CampoMultilinha CriarLinhaTomador()
        {
            var texto = new StringBuilder();
            texto.Append("CNPJ / CPF / NIF: ").AppendLine(ViewModel.Tomador.CnpjCpf);
            texto.Append("Inscrição Municipal: ").AppendLine(ViewModel.Tomador.IM);
            texto.Append("Telefone: ").AppendLine(ViewModel.Tomador.Telefone);
            texto.Append("Nome / Nome Empresarial: ").AppendLine(ViewModel.Tomador.RazaoSocial);
            texto.Append("E-mail: ").AppendLine(ViewModel.Tomador.Email);
            texto.Append("Endereço: ").AppendLine(BuildEndereco(ViewModel.Tomador));
            texto.Append("Município: ").AppendLine(ViewModel.Tomador.Municipio);
            texto.Append("CEP: ").AppendLine(ViewModel.Tomador.EnderecoCep);
            return new CampoMultilinha("TOMADOR DO SERVIÇO", texto.ToString().Trim(), EstiloPadrao);
        }

        private CampoMultilinha CriarServicoPrestado()
        {
            var texto = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(ViewModel.DescricaoTributacaoNacional))
                texto.Append("Código de tributação nacional: ").AppendLine(ViewModel.DescricaoTributacaoNacional);

            if (!string.IsNullOrWhiteSpace(ViewModel.DescricaoTributacaoMunicipal))
                texto.Append("Código municipal: ").AppendLine(ViewModel.DescricaoTributacaoMunicipal);

            if (!string.IsNullOrWhiteSpace(ViewModel.MunicipioPrestacao))
                texto.Append("Local da prestação: ").AppendLine(ViewModel.MunicipioPrestacao);

            if (!string.IsNullOrWhiteSpace(ViewModel.PaisPrestacao))
                texto.Append("País da prestação: ").AppendLine(ViewModel.PaisPrestacao);

            if (!string.IsNullOrWhiteSpace(ViewModel.DiscriminacaoServico))
                texto.AppendLine(ViewModel.DiscriminacaoServico);

            if (!string.IsNullOrWhiteSpace(ViewModel.MunicipioIncidencia))
                texto.Append("Município de incidência: ").AppendLine(ViewModel.MunicipioIncidencia);

            if (!string.IsNullOrWhiteSpace(ViewModel.DescricaoSimplesNacional))
                texto.Append("Simples Nacional: ").AppendLine(ViewModel.DescricaoSimplesNacional);

            return new CampoMultilinha("SERVIÇO PRESTADO", texto.ToString().Trim(), EstiloPadrao);
        }

        private CampoMultilinha CriarTributacaoMunicipal()
        {
            var texto = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(ViewModel.DescricaoTributacaoMunicipal))
                texto.Append("Tributação do ISSQN: ").AppendLine(ViewModel.DescricaoTributacaoMunicipal);
            if (!string.IsNullOrWhiteSpace(ViewModel.PaisTomador))
                texto.Append("País Resultado da Prestação do Serviço: ").AppendLine(ViewModel.PaisTomador);
            if (!string.IsNullOrWhiteSpace(ViewModel.MunicipioIncidencia))
                texto.Append("Município de Incidência do ISSQN: ").AppendLine(ViewModel.MunicipioIncidencia);
            if (!string.IsNullOrWhiteSpace(ViewModel.DescricaoRegimeEspecial))
                texto.Append("Regime Especial de Tributação: ").AppendLine(ViewModel.DescricaoRegimeEspecial);
            if (!string.IsNullOrWhiteSpace(ViewModel.DescricaoSimplesNacional))
                texto.Append("Tipo de Imunidade: ").AppendLine(ViewModel.DescricaoSimplesNacional);
            if (!string.IsNullOrWhiteSpace(ViewModel.DescricaoRetencaoIssqn))
                texto.Append("Retenção do ISSQN: ").AppendLine(ViewModel.DescricaoRetencaoIssqn);
            texto.Append("Suspensão da Exigibilidade do ISSQN: ").AppendLine("-");
            texto.Append("Número Processo Suspensão: ").AppendLine("-");
            texto.Append("Benefício Municipal: ").AppendLine("-");
            texto.Append("Valores:").AppendLine();
            texto.Append("Valor do serviço: ").AppendLine(FormatCurrency(ViewModel.ValorServico));
            texto.Append("Base de cálculo: ").AppendLine(FormatCurrency(ViewModel.BaseCalculo));
            texto.Append("Alíquota: ").AppendLine(FormatPercent(ViewModel.AliquotaIssqn));
            texto.Append("ISSQN: ").AppendLine(FormatCurrency(ViewModel.ValorIssqn));
            texto.Append("Valor de cálculo do BM: ").AppendLine(FormatCurrency(ViewModel.ValorCalcBm));
            texto.Append("Base de cálculo do BM: ").AppendLine(FormatCurrency(ViewModel.BaseCalculoBm));

            return new CampoMultilinha("TRIBUTAÇÃO MUNICIPAL", texto.ToString().Trim(), EstiloPadrao);
        }

        private CampoMultilinha CriarTributacaoFederal()
        {
            var texto = new StringBuilder();
            texto.Append("IRRF: ").AppendLine(FormatCurrency(ViewModel.ValorIrff));
            texto.Append("Contribuições: ").AppendLine(FormatCurrency(ViewModel.ValorContribuicoes));
            texto.Append("PIS / COFINS: ").AppendLine(FormatCurrency(ViewModel.ValorPisCofins));
            if (!string.IsNullOrWhiteSpace(ViewModel.DescricaoRetencaoFederal))
                texto.Append("Descrição Contrib. Sociais - Retidas: ").AppendLine(ViewModel.DescricaoRetencaoFederal);
            return new CampoMultilinha("TRIBUTAÇÃO FEDERAL", texto.ToString().Trim(), EstiloPadrao);
        }

        private CampoMultilinha CriarTotais()
        {
            var texto = new StringBuilder();
            texto.Append("Valor do serviço: ").AppendLine(FormatCurrency(ViewModel.ValorServico));
            texto.Append("Desconto Condicionado: ").AppendLine(FormatCurrency(ViewModel.ValorDescontoCondicionado));
            texto.Append("Desconto Incondicionado: ").AppendLine(FormatCurrency(ViewModel.ValorDescontoIncondicionado));
            texto.Append("ISSQN Retido: ").AppendLine(ViewModel.DescricaoRetencaoIssqn ?? "-");
            texto.Append("Total das Retenções Federais: ").AppendLine(FormatCurrency(ViewModel.ValorRetencoes));
            texto.Append("PIS/COFINS - Débito Apur. Própria: ").AppendLine(FormatCurrency(ViewModel.ValorPisCofins));
            texto.Append("Retenções: ").AppendLine(FormatCurrency(ViewModel.ValorRetencoes));
            texto.Append("Valor líquido: ").AppendLine(FormatCurrency(ViewModel.ValorLiquido));
            return new CampoMultilinha("VALOR TOTAL DA NFS-e", texto.ToString().Trim(), EstiloPadrao);
        }

        private CampoMultilinha CriarTotaisTributos()
        {
            var texto = new StringBuilder();
            texto.Append("Federais: ").AppendLine(FormatCurrency(ViewModel.ValorTotalTributosFederais));
            texto.Append("Estaduais: ").AppendLine(FormatCurrency(ViewModel.ValorTotalTributosEstaduais));
            texto.Append("Municipais: ").AppendLine(FormatCurrency(ViewModel.ValorTotalTributosMunicipais));
            return new CampoMultilinha("TOTAIS DE TRIBUTOS", texto.ToString().Trim(), EstiloPadrao);
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

            return new CampoMultilinha("INFORMAÇÕES COMPLEMENTARES", texto.ToString().Trim(), EstiloPadrao);
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

        private static string BuildEndereco(Zion.NFe.Danfe.Modelo.EmpresaViewModel empresa)
        {
            if (empresa == null) return string.Empty;

            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(empresa.EnderecoLogadrouro)) sb.Append(empresa.EnderecoLogadrouro);
            if (!string.IsNullOrWhiteSpace(empresa.EnderecoNumero)) sb.Append(", ").Append(empresa.EnderecoNumero);
            if (!string.IsNullOrWhiteSpace(empresa.EnderecoComplemento)) sb.Append(" - ").Append(empresa.EnderecoComplemento);
            if (!string.IsNullOrWhiteSpace(empresa.EnderecoBairro)) sb.Append(" - ").Append(empresa.EnderecoBairro);
            if (!string.IsNullOrWhiteSpace(empresa.Municipio)) sb.Append(" - ").Append(empresa.Municipio);
            if (!string.IsNullOrWhiteSpace(empresa.EnderecoUf)) sb.Append(" - ").Append(empresa.EnderecoUf);
            return sb.ToString();
        }

        private static string FormatCurrency(decimal? value)
        {
            if (!value.HasValue) return string.Empty;
            return value.Value.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private static string FormatPercent(decimal? value)
        {
            if (!value.HasValue) return string.Empty;
            return value.Value.ToString("0.00") + "%";
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
