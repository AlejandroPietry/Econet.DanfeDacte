using DacteSharp.Modelo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using Zion.NFe.Danfe;
using Zion.NFe.Danfe.Modelo;
using Zion.NFe.Danfe.Nfse.Modelo;

namespace ZionDanfe.WebService.Controllers
{
    public class XmlController : Controller
    {
        [HttpGet("/api/xml/pdf/gerar")]
        public IActionResult Index()
        {
            string xml = System.IO.File.ReadAllText(@"C:\Users\pietr\Downloads\v4_ComLocalEntrega.xml");
            var modelo = DanfeViewModelCreator.CriarDeStringXml(xml);
            var bytesPdf = GeradorPdf.GerarDanfePdfDeXml(xml);

            return File(bytesPdf, "Application/pdf", $"{modelo.ChaveAcesso}.pdf");
        }

        [HttpGet("/api/xml/pdf/gerar-dacte")]
        public IActionResult GerarDacte()
        {
            try
            {
                string xml = System.IO.File.ReadAllText(@"C:\Users\pietr\Downloads\35220720147617002276570010063360481993663950.xml");
                var modelo = DacteViewModelCreator.Criar57DeStringXml(xml);
                var pdfBytes = GeradorPdf.GerarDactePdfDeXml(xml, ModeloDacte.Cte57);

                return File(pdfBytes, "Application/pdf", $"{modelo.ChaveAcesso}.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/api/xml/pdf/gerar-nfse")]
        public IActionResult GerarPdfNFSe()
        {
            try
            {
                string xml = System.IO.File.ReadAllText(@"C:\Users\pietr\Downloads\35503081253698568000194000000000003926040558966528.xml");
                var modelo = NfseViewModelCreator.CriarDeStringXml(xml);
                var pdfBytes = GeradorPdf.GerarNfsePdfDeXml(xml);

                return File(pdfBytes, "Application/pdf", $"{modelo.ChaveAcesso}.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
