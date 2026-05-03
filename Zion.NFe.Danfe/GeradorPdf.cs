using DacteSharp.Modelo;
using ECONET.EcoNFe2.Negocio.Dacte.DacteSharp.Modelo;
using System;
using System.IO;
using Zion.NFe.Danfe.Modelo;

namespace Zion.NFe.Danfe
{
    /// <summary>
    /// Fornece métodos de conveniência para gerar PDFs de DANFE e DACTE a partir de XML.
    /// </summary>
    public static class GeradorPdf
    {
        public static byte[] GerarDanfePdfDeXml(string xml)
        {
            if (xml == null) throw new ArgumentNullException(nameof(xml));

            var modelo = DanfeViewModelCreator.CriarDeStringXml(xml);
            return GerarDanfePdf(modelo);
        }

        public static byte[] GerarDanfePdfDeXml(Stream xmlStream)
        {
            if (xmlStream == null) throw new ArgumentNullException(nameof(xmlStream));

            var modelo = DanfeViewModelCreator.CriarDeArquivoXml(xmlStream);
            return GerarDanfePdf(modelo);
        }

        public static byte[] GerarDactePdfDeXml(string xml, ModeloDacte modelo)
        {
            if (xml == null) throw new ArgumentNullException(nameof(xml));

            var viewModel = CriarDacteViewModel(xml, modelo);
            return GerarDactePdf(viewModel);
        }

        public static byte[] GerarDactePdfDeXml(Stream xmlStream, ModeloDacte modelo)
        {
            if (xmlStream == null) throw new ArgumentNullException(nameof(xmlStream));

            using (var reader = new StreamReader(xmlStream, true))
            {
                return GerarDactePdfDeXml(reader.ReadToEnd(), modelo);
            }
        }

        private static byte[] GerarDanfePdf(DanfeViewModel modelo)
        {
            using (var pdfStream = new MemoryStream())
            using (var danfe = new DanfeDoc(modelo))
            {
                danfe.Gerar();
                return danfe.ObterPdfBytes(pdfStream);
            }
        }

        private static byte[] GerarDactePdf(DacteViewModel modelo)
        {
            using (var pdfStream = new MemoryStream())
            using (var dacte = new ECONET.EcoNFe2.Negocio.Dacte.Dacte(modelo))
            {
                dacte.Gerar();
                return dacte.ObterPdfBytes(pdfStream);
            }
        }

        private static DacteViewModel CriarDacteViewModel(string xml, ModeloDacte modelo)
        {
            switch (modelo)
            {
                case ModeloDacte.Cte57:
                    return DacteViewModelCreator.Criar57DeStringXml(xml);
                case ModeloDacte.CteOs67:
                    return DacteViewModelCreator.Criar67DeStringXml(xml);
                default:
                    throw new ArgumentOutOfRangeException(nameof(modelo), modelo, "Modelo de DACTE não suportado.");
            }
        }
    }
}
