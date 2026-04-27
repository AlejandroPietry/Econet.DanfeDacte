using DacteSharp.Modelo;
using ECONET.EcoNFe2.Negocio.Dacte;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Zion.NFe.Danfe;
using Zion.NFe.Danfe.Modelo;

namespace ZionDanfe.WebService.Controllers
{
    public class XmlController : Controller
    {
        private const string PastaXmlRobo = @"C:\Users\pietr\OneDrive\Documentos\xmlrobo";
        private const string PastaPdfRobo = @"C:\Users\pietr\OneDrive\Documentos\pdfrobo";

        [HttpPost("/api/xml/pdf/gerar")]
        public async Task<IActionResult> Index()
        {
            string xml = null;

            using (var reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                xml = await reader.ReadToEndAsync();
            }

            var modelo = DanfeViewModelCreator.CriarDeStringXml(xml);

            using (var pdfStream = new MemoryStream())
            {
                using (var danfe = new DanfeDoc(modelo))
                {
                    danfe.ViewModel.DefinirTextoCreditos("Desenvolvido por [ www.laranjeiras.dev / (21)997706037 ]");
                    danfe.Gerar();
                    var bytesPdf = danfe.ObterPdfBytes(pdfStream);
                    return File(bytesPdf, "Application/pdf", $"{modelo.ChaveAcesso}.pdf");
                }
            }
        }

        [HttpGet("/api/xml/pdf/gerar-dacte")]
        public async Task<IActionResult> GerarDacte()
        {
            try
            {
                if (!Directory.Exists(PastaXmlRobo))
                {
                    return NotFound($"A pasta de entrada não foi encontrada: {PastaXmlRobo}");
                }

                Directory.CreateDirectory(PastaPdfRobo);

                var arquivosXml = Directory.GetFiles(PastaXmlRobo, "*.xml", SearchOption.TopDirectoryOnly);
                var arquivosGerados = 0;
                var arquivosComErro = new System.Collections.Generic.List<object>();
                var arquivosSaida = new System.Collections.Generic.List<string>();

                foreach (var caminhoXml in arquivosXml)
                {
                    try
                    {
                        var xml = await System.IO.File.ReadAllTextAsync(caminhoXml, Encoding.UTF8);
                        var modelo = CriarModeloDacte(xml);
                        var nomeArquivo = string.IsNullOrWhiteSpace(modelo.ChaveAcesso)
                            ? Path.GetFileNameWithoutExtension(caminhoXml)
                            : modelo.ChaveAcesso;
                        var caminhoPdf = Path.Combine(PastaPdfRobo, $"{nomeArquivo}.pdf");

                        using (var dacte = new Dacte(modelo))
                        {
                            dacte.Gerar();
                            dacte.Salvar(caminhoPdf);
                        }

                        arquivosGerados++;
                        arquivosSaida.Add(caminhoPdf);
                    }
                    catch (Exception exArquivo)
                    {
                        arquivosComErro.Add(new
                        {
                            arquivo = Path.GetFileName(caminhoXml),
                            erro = exArquivo.Message
                        });
                    }
                }

                return Ok(new
                {
                    pastaEntrada = PastaXmlRobo,
                    pastaSaida = PastaPdfRobo,
                    arquivosEncontrados = arquivosXml.Length,
                    arquivosGerados,
                    arquivosSaida,
                    arquivosComErro
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private static ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo.DacteViewModel CriarModeloDacte(string xml)
        {
            if (xml.IndexOf("<mod>67</mod>", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return DacteViewModelCreator.Criar67DeStringXml(xml);
            }

            return DacteViewModelCreator.Criar57DeStringXml(xml);
        }
    }
}
