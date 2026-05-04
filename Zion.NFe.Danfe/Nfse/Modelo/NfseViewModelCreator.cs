using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Zion.NFe.Danfe.Modelo;
using Zion.NFe.Danfe.Tools;

namespace Zion.NFe.Danfe.Nfse.Modelo
{
    /// <summary>
    /// Converte XML de NFS-e em modelo pronto para renderização.
    /// </summary>
    public static class NfseViewModelCreator
    {
        public static NfseViewModel CriarDeStringXml(string xml)
        {
            if (xml == null) throw new ArgumentNullException(nameof(xml));

            using (var sr = new StringReader(xml))
            {
                return CriarDeArquivoXmlInternal(sr);
            }
        }

        public static NfseViewModel CriarDeArquivoXml(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException(nameof(path));

            using (var sr = new StreamReader(path, Encoding.UTF8, true))
            {
                return CriarDeArquivoXmlInternal(sr);
            }
        }

        public static NfseViewModel CriarDeArquivoXml(Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));

            using (var sr = new StreamReader(stream, Encoding.UTF8, true))
            {
                return CriarDeArquivoXmlInternal(sr);
            }
        }

        private static NfseViewModel CriarDeArquivoXmlInternal(TextReader reader)
        {
            try
            {
                var doc = XDocument.Load(reader, LoadOptions.PreserveWhitespace);
                return CreateFromXml(doc);
            }
            catch (XmlException ex)
            {
                throw new Exception(string.Format("Não foi possível interpretar o Xml. Linha {0} Posição {1}.", ex.LineNumber, ex.LinePosition), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Não foi possível interpretar o texto Xml.", ex);
            }
        }

        public static NfseViewModel CreateFromXml(XDocument document)
        {
            if (document == null) throw new ArgumentNullException(nameof(document));
            var root = document.Root ?? throw new XmlException("O Xml não contém elemento raiz.");

            var infNFSe = FindElement(root, "infNFSe") ?? root;
            var dps = FindElement(infNFSe, "DPS");
            var infDps = dps != null ? FindElement(dps, "InfDPS") : FindElement(infNFSe, "InfDPS");

            var model = new NfseViewModel
            {
                Numero = FirstValue(infNFSe, "nNFSe") ?? FirstValue(infDps, "nDPS"),
                Serie = FirstValue(infDps, "serie"),
                NumeroDps = FirstValue(infDps, "nDPS"),
                SerieDps = FirstValue(infDps, "serie"),
                ChaveAcesso = FirstAttributeValue(infNFSe, "Id") ?? FirstAttributeValue(infDps, "Id") ?? FirstValue(infNFSe, "Id") ?? FirstValue(infDps, "Id"),
                CodigoVerificacao = FirstValue(infNFSe, "cVerif") ?? FirstValue(infDps, "cVerif"),
                TipoAmbiente = FirstInt(infNFSe, 1, "ambGer", "tpAmb"),
                DataHoraEmissao = FirstDateTime(infNFSe, "dhProc"),
                Competencia = FirstDateTime(infDps, "dCompet"),
                ProtocoloAutorizacao = BuildProtocolo(FirstValue(FindElement(infNFSe, "infProt") ?? infNFSe, "nProt"), FirstDateTime(FindElement(infNFSe, "infProt") ?? infNFSe, "dhRecbto")),
                MunicipioPrestacao = FirstValue(infDps, "cLocPrestacao") ?? FirstValue(infNFSe, "xLocPrestacao"),
                MunicipioIncidencia = FirstValue(infNFSe, "cLocIncid") ?? FirstValue(infNFSe, "xLocIncid"),
                PaisPrestacao = FirstValue(infDps, "serv", "locPrest", "cPaisPrestacao"),
                PaisTomador = FirstValue(FindElement(infDps, "toma"), "end", "endExt", "cPais"),
                NaturezaTributacaoMunicipal = BuildTributacaoMunicipal(infDps),
                DescricaoRetencaoIssqn = BuildDescricaoRetencaoIssqn(infDps),
                DescricaoRetencaoFederal = BuildDescricaoRetencaoFederal(infDps),
            };

            if (dps != null)
            {
                var prest = FindElement(dps, "prest");
                var toma = FindElement(dps, "toma");
                var serv = FindElement(dps, "serv");
                var valores = FindElement(dps, "valores");

                model.Prestador = BuildEmpresa(prest);
                model.Tomador = BuildEmpresa(toma);
                model.DiscriminacaoServico = FirstValue(serv, "xDescServ") ?? FirstValue(serv, "xDiscr") ?? FirstValue(serv, "xInfComp");
                model.InformacoesComplementares = FirstValue(serv, "xInfComp") ?? FirstValue(infDps, "xInfComp") ?? FirstValue(infNFSe, "xOutInf");
                model.ValorServico = FirstDecimal(valores, "vServPrest", "vServ");
                model.ValorDescontoCondicionado = FirstDecimal(valores, "vDescCondIncond", "vDescCond");
                model.ValorDescontoIncondicionado = FirstDecimal(valores, "vDescCondIncond", "vDescIncond");
                model.ValorDeducoes = FirstDecimal(valores, "vDescCondIncond", "vDescIncond");
                model.ValorLiquido = FirstDecimal(valores, "vLiq");
                model.ValorIssqn = FirstDecimal(valores, "vISSQN");
                model.AliquotaIssqn = FirstDecimal(valores, "pAliqAplic");
                model.BaseCalculo = FirstDecimal(infNFSe, "vBC") ?? FirstDecimal(valores, "vBC");
                model.ValorRetencoes = FirstDecimal(infNFSe, "vTotalRet") ?? FirstDecimal(valores, "vTotalRet");
                model.DescricaoTributacaoNacional = BuildTributacaoNacional(infDps, infNFSe);
                model.DescricaoTributacaoMunicipal = BuildTributacaoMunicipal(infDps);
                model.DescricaoSimplesNacional = BuildSimplesNacional(infDps);
                model.DescricaoRegimeEspecial = BuildRegimeEspecial(infDps);
                model.ValorTotalTributosFederais = FirstDecimal(infDps, "valores", "trib", "totTrib", "vTotTrib", "vTotTribFed");
                model.ValorTotalTributosEstaduais = FirstDecimal(infDps, "valores", "trib", "totTrib", "vTotTrib", "vTotTribEst");
                model.ValorTotalTributosMunicipais = FirstDecimal(infDps, "valores", "trib", "totTrib", "vTotTrib", "vTotTribMun");
            }
            else
            {
                model.Prestador = BuildEmpresa(FindElement(infNFSe, "emit"));
                model.Tomador = BuildEmpresa(FindElement(infNFSe, "toma"));
                model.DiscriminacaoServico = FirstValue(infNFSe, "xDiscr") ?? FirstValue(infNFSe, "xDescServ");
                model.InformacoesComplementares = FirstValue(infNFSe, "xOutInf");
                model.ValorServico = FirstDecimal(infNFSe, "vServ");
                model.ValorDescontoCondicionado = FirstDecimal(infNFSe, "vDescCond");
                model.ValorDescontoIncondicionado = FirstDecimal(infNFSe, "vDescIncond");
                model.ValorDeducoes = FirstDecimal(infNFSe, "vDeducoes");
                model.ValorLiquido = FirstDecimal(infNFSe, "vLiq");
                model.ValorIssqn = FirstDecimal(infNFSe, "vISSQN");
                model.AliquotaIssqn = FirstDecimal(infNFSe, "pAliqAplic");
                model.BaseCalculo = FirstDecimal(infNFSe, "vBC");
                model.ValorRetencoes = FirstDecimal(infNFSe, "vTotalRet");
            }

            if (string.IsNullOrWhiteSpace(model.ChaveAcesso))
            {
                throw new XmlException("A NFS-e não contém identificador acessível para renderização.");
            }

            return model;
        }

        private static EmpresaViewModel BuildEmpresa(XElement element)
        {
            var model = new EmpresaViewModel();
            if (element == null) return model;

            model.RazaoSocial = FirstValue(element, "xNome") ?? FirstValue(element, "xRazaoSocial");
            model.NomeFantasia = FirstValue(element, "xFant");
            model.CnpjCpf = FormatDocument(FirstValue(element, "CNPJ") ?? FirstValue(element, "CPF") ?? FirstValue(element, "cnpj") ?? FirstValue(element, "cpf"));
            model.IM = FirstValue(element, "IM");
            model.Ie = FirstValue(element, "IE");
            model.Email = FirstValue(element, "email");
            model.Telefone = FirstValue(element, "fone");

            var endereco = FindElement(element, "enderNac") ?? FindElement(element, "end") ?? FindElement(element, "ender");
            if (endereco != null)
            {
                model.EnderecoLogadrouro = FirstValue(endereco, "xLgr");
                model.EnderecoNumero = FirstValue(endereco, "nro");
                model.EnderecoComplemento = FirstValue(endereco, "xCpl");
                model.EnderecoBairro = FirstValue(endereco, "xBairro");
                model.Municipio = FirstValue(endereco, "xMun") ?? FirstValue(endereco, "xCidade");
                model.EnderecoUf = FirstValue(endereco, "UF") ?? FirstValue(endereco, "uf");
                model.EnderecoCep = FirstValue(endereco, "CEP");

                var endNac = FindElement(endereco, "endNac") ?? endereco;
                if (string.IsNullOrWhiteSpace(model.Municipio))
                {
                    var codMunicipio = FirstValue(endNac, "cMun");
                    if (!string.IsNullOrWhiteSpace(codMunicipio))
                        model.Municipio = codMunicipio;
                }
            }

            return model;
        }

        private static XElement FindElement(XElement container, string localName)
        {
            if (container == null) return null;
            return container.Elements().FirstOrDefault(x => x.Name.LocalName == localName)
                ?? container.Descendants().FirstOrDefault(x => x.Name.LocalName == localName);
        }

        private static string FirstValue(XElement container, params string[] path)
        {
            var el = FindPath(container, path);
            return el?.Value?.Trim();
        }

        private static string FirstAttributeValue(XElement container, string attributeName)
        {
            if (container == null) return null;
            return container.Attribute(attributeName)?.Value?.Trim();
        }

        private static int FirstInt(XElement container, int defaultValue, params string[] path)
        {
            var value = FirstValue(container, path);
            if (int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var i))
                return i;

            return defaultValue;
        }

        private static decimal? FirstDecimal(XElement container, params string[] path)
        {
            var value = FirstValue(container, path);
            if (string.IsNullOrWhiteSpace(value)) return null;

            if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var d))
                return d;

            if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.GetCultureInfo("pt-BR"), out d))
                return d;

            return null;
        }

        private static DateTime? FirstDateTime(XElement container, params string[] path)
        {
            var value = FirstValue(container, path);
            if (string.IsNullOrWhiteSpace(value)) return null;

            if (DateTimeOffset.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out var dto))
                return dto.DateTime;

            if (DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out var dt))
                return dt;

            if (DateTime.TryParse(value, CultureInfo.GetCultureInfo("pt-BR"), DateTimeStyles.AllowWhiteSpaces, out dt))
                return dt;

            return null;
        }

        private static XElement FindPath(XElement container, params string[] path)
        {
            if (container == null || path == null || path.Length == 0) return null;

            XElement current;
            var index = 0;

            if (container.Name.LocalName == path[0])
            {
                current = container;
                index = 1;
            }
            else
            {
                current = container.Descendants().FirstOrDefault(x => x.Name.LocalName == path[0]);
                index = 1;
            }

            if (current == null) return null;

            for (; index < path.Length; index++)
            {
                current = current.Elements().FirstOrDefault(x => x.Name.LocalName == path[index]);
                if (current == null) return null;
            }

            return current;
        }

        private static string BuildProtocolo(string numero, DateTime? dataHora)
        {
            if (string.IsNullOrWhiteSpace(numero) && !dataHora.HasValue)
                return null;

            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(numero))
                sb.Append(numero);

            if (dataHora.HasValue)
            {
                if (sb.Length > 0) sb.Append(" - ");
                sb.Append(dataHora.Value.ToString("dd/MM/yyyy HH:mm:ss"));
            }

            return sb.ToString();
        }

        private static string FormatDocument(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;
            var digits = new string(value.Where(char.IsDigit).ToArray());
            if (digits.Length == 11 || digits.Length == 14)
                return Formatador.FormatarCpfCnpj(digits);
            return value;
        }

        private static string BuildTributacaoNacional(XElement infDps, XElement infNFSe)
        {
            var cTribNac = FirstValue(infDps, "serv", "cServ", "cTribNac") ?? FirstValue(infNFSe, "xTribNac");
            var xTribNac = FirstValue(infNFSe, "xTribNac");
            if (string.IsNullOrWhiteSpace(cTribNac) && string.IsNullOrWhiteSpace(xTribNac)) return null;
            if (string.IsNullOrWhiteSpace(cTribNac)) return xTribNac;
            if (string.IsNullOrWhiteSpace(xTribNac)) return cTribNac;
            return $"{cTribNac} - {xTribNac}";
        }

        private static string BuildTributacaoMunicipal(XElement infDps)
        {
            var tribMun = FindElement(infDps, "tribMun");
            var trib = FirstValue(tribMun, "tribISSQN");
            if (string.IsNullOrWhiteSpace(trib)) return null;
            switch (trib.Trim())
            {
                case "1":
                    return "Operação tributável";
                case "2":
                    return "Imunidade";
                case "3":
                    return "Exportação de serviço";
                case "4":
                    return "Não incidência";
                default:
                    return trib;
            }
        }

        private static string BuildDescricaoRetencaoIssqn(XElement infDps)
        {
            var tribMun = FindElement(infDps, "tribMun");
            var tpRet = FirstValue(tribMun, "tpRetISSQN");
            if (string.IsNullOrWhiteSpace(tpRet)) return null;

            switch (tpRet.Trim())
            {
                case "1":
                    return "Não Retido";
                case "2":
                    return "Retido pelo Tomador";
                case "3":
                    return "Retido pelo Intermediário";
                default:
                    return tpRet;
            }
        }

        private static string BuildDescricaoRetencaoFederal(XElement infDps)
        {
            var piscofins = FindElement(infDps, "piscofins");
            var tp = FirstValue(piscofins, "tpRetPisCofins");
            if (string.IsNullOrWhiteSpace(tp)) return null;

            switch (tp.Trim())
            {
                case "0":
                    return "PIS/COFINS/CSLL Não Retidos";
                case "1":
                    return "PIS/COFINS Retidos";
                case "2":
                    return "PIS/COFINS Não Retidos";
                case "3":
                    return "PIS/COFINS/CSLL Retidos";
                default:
                    return tp;
            }
        }

        private static string BuildSimplesNacional(XElement infDps)
        {
            var regTrib = FindElement(infDps, "regTrib");
            var opSimpNac = FirstValue(regTrib, "opSimpNac");
            if (string.IsNullOrWhiteSpace(opSimpNac)) return null;

            switch (opSimpNac.Trim())
            {
                case "1":
                    return "Não optante";
                case "2":
                    return "Optante - Microempreendedor Individual (MEI)";
                case "3":
                    return "Optante - Microempresa ou Empresa de Pequeno Porte (ME/EPP)";
                default:
                    return opSimpNac;
            }
        }

        private static string BuildRegimeEspecial(XElement infDps)
        {
            var regTrib = FindElement(infDps, "regTrib");
            var regEspTrib = FirstValue(regTrib, "regEspTrib");
            if (string.IsNullOrWhiteSpace(regEspTrib)) return null;

            switch (regEspTrib.Trim())
            {
                case "0":
                    return "Nenhum";
                case "1":
                    return "Ato Cooperado (Cooperativa)";
                case "2":
                    return "Estimativa";
                case "3":
                    return "Microempresa Municipal";
                case "4":
                    return "Notário ou Registrador";
                case "5":
                    return "Profissional Autônomo";
                case "6":
                    return "Sociedade de Profissionais";
                default:
                    return regEspTrib;
            }
        }
    }
}
