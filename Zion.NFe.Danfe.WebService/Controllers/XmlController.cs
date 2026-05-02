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
        [HttpGet("/api/xml/pdf/gerar")]
        public async Task<IActionResult> Index()
        {
            string xml = System.IO.File.ReadAllText(@"C:\Users\pietr\Downloads\v4_ComLocalEntrega.xml");

            var modelo = DanfeViewModelCreator.CriarDeStringXml(xml);

            using (var pdfStream = new MemoryStream())
            {
                using (var danfe = new DanfeDoc(modelo))
                {
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

                string xml = System.IO.File.ReadAllText(@"C:\Users\pietr\Downloads\35220720147617002276570010063360481993663950.xml");
                byte[] pdfBytes;
                var modelo = DacteViewModelCreator.Criar57DeStringXml(xml);
                using (var pdfStream = new MemoryStream())
                {
                    using (var dacte = new Dacte(modelo))
                    {
                        dacte.Gerar();
                        pdfBytes = dacte.ObterPdfBytes(pdfStream);
                    }
                }
                return File(pdfBytes, "Application/pdf", $"{modelo.ChaveAcesso}.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
