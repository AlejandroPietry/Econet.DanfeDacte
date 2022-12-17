﻿using DacteSharp.Modelo;
using ECONET.EcoNFe2.Negocio.Dacte;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Zion.NFe.Danfe.Modelo;

namespace Zion.NFe.Danfe_470_Test
{
    [TestClass]
    public class DanfeXmlTests
    {
        public readonly string OutputDirectory = Path.Combine("Output", "DeXml");
        public readonly string InputXmlDirectoryPrefix = Path.Combine("Xml", "NFe");

        public DanfeXmlTests()
        {
            if (!Directory.Exists(OutputDirectory))
                Directory.CreateDirectory(OutputDirectory);
        }

        [TestMethod]
        public void TestXml()
        {
            var xmlPath = @"C:\Laranjeiras\Xmls\XmlNFeClientes\NFe33190611367874000106550010000002311000324326.xml";
            var outPdfFilePath = Path.Combine(OutputDirectory, Path.GetFileNameWithoutExtension(xmlPath) + ".pdf");
            var model = DanfeViewModelCreator.CriarDeArquivoXml(xmlPath);
            using (var danfe = new Danfe.DanfeDoc(model))
            {
                danfe.Gerar();
                danfe.Salvar(outPdfFilePath);
            }
        }
        public void TestXml(String xmlPath)
        {
            var outPdfFilePath = Path.Combine(OutputDirectory, Path.GetFileNameWithoutExtension(xmlPath) + ".pdf");
            var model = DanfeViewModelCreator.CriarDeArquivoXml(Path.Combine(InputXmlDirectoryPrefix, xmlPath));
            using (var danfe = new Danfe.DanfeDoc(model))
            {
                danfe.Gerar();
                danfe.Salvar(outPdfFilePath);
            }
        }

        [TestMethod]
        public void GerarDacte()
        {
            string xml = System.IO.File.ReadAllText(@"C:\Users\alejandro_trindade\Downloads\XML_260520221451526344047\42220520121850010894571450060453721808295371_Cte.xml");
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


        }

        [TestMethod]
        public void v1() => TestXml("v1.00/v1.xml");

        [TestMethod]
        public void v2_Retrato() => TestXml("v2.00/v2_Retrato.xml");

        [TestMethod]
        public void v3_10_Retrato() => TestXml("v3.10/v3.10_Retrato.xml");

        [TestMethod]
        public void v4_ComLocalEntrega() => TestXml("v4.00/v4_ComLocalEntrega.xml");

        [TestMethod]
        public void v4_ComLocalRetirada() => TestXml("v4.00/v4_ComLocalRetirada.xml");
    }
}
