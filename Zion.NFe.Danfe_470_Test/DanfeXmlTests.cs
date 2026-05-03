using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;
using Zion.NFe.Danfe;
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
            if (!File.Exists(xmlPath))
                Assert.Inconclusive($"Arquivo de teste não encontrado: {xmlPath}");

            var outPdfFilePath = Path.Combine(OutputDirectory, Path.GetFileNameWithoutExtension(xmlPath) + ".pdf");
            var model = DanfeViewModelCreator.CriarDeArquivoXml(xmlPath);
            using (var danfe = new DanfeDoc(model))
            {
                danfe.Gerar();
                danfe.Salvar(outPdfFilePath);
            }
        }

        public void TestXml(string xmlPath)
        {
            var outPdfFilePath = Path.Combine(OutputDirectory, Path.GetFileNameWithoutExtension(xmlPath) + ".pdf");
            var model = DanfeViewModelCreator.CriarDeArquivoXml(Path.Combine(InputXmlDirectoryPrefix, xmlPath));
            using (var danfe = new DanfeDoc(model))
            {
                danfe.Gerar();
                danfe.Salvar(outPdfFilePath);
            }
        }

        [TestMethod]
        public void GerarDacte()
        {
            var xmlPath = @"C:\Users\alejandro_trindade\Downloads\XML_260520221451526344047\42220520121850010894571450060453721808295371_Cte.xml";
            if (!File.Exists(xmlPath))
                Assert.Inconclusive($"Arquivo de teste não encontrado: {xmlPath}");

            string xml = File.ReadAllText(xmlPath);
            var pdfBytes = ExecutarIgnorandoAusenciaDeFonte(() => GeradorPdf.GerarDactePdfDeXml(xml, ModeloDacte.Cte57));

            Assert.IsTrue(pdfBytes.Length > 0);
        }

        [TestMethod]
        public void GerarDanfePdfDeXmlString_RetornaBytes()
        {
            string xml = File.ReadAllText(Path.Combine(InputXmlDirectoryPrefix, "v4.00", "v4_ComLocalEntrega.xml"));
            var pdfBytes = ExecutarIgnorandoAusenciaDeFonte(() => GeradorPdf.GerarDanfePdfDeXml(xml));

            Assert.IsNotNull(pdfBytes);
            Assert.IsTrue(pdfBytes.Length > 0);
        }

        [TestMethod]
        public void GerarDanfePdfDeXmlStream_RetornaBytes()
        {
            using (var xmlStream = File.OpenRead(Path.Combine(InputXmlDirectoryPrefix, "v4.00", "v4_ComLocalRetirada.xml")))
            {
                var pdfBytes = ExecutarIgnorandoAusenciaDeFonte(() => GeradorPdf.GerarDanfePdfDeXml(xmlStream));

                Assert.IsNotNull(pdfBytes);
                Assert.IsTrue(pdfBytes.Length > 0);
            }
        }

        [TestMethod]
        public void GerarDanfePdfDeXmlInvalido_LancaExcecao()
        {
            var ex = CapturarExcecao(() => GeradorPdf.GerarDanfePdfDeXml("<xml-invalido/>"));
            Assert.AreEqual("XmlException", ex.GetType().Name);
        }

        [TestMethod]
        public void GerarDactePdfDeXmlInvalido_LancaExcecao()
        {
            var ex = CapturarExcecao(() => GeradorPdf.GerarDactePdfDeXml("<xml-invalido/>", ModeloDacte.Cte57));
            Assert.AreEqual("XmlException", ex.GetType().Name);
        }

        [TestMethod]
        public void GerarDactePdfDeXmlComModeloInvalido_LancaExcecao()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => GeradorPdf.GerarDactePdfDeXml("<xml/>", (ModeloDacte)999));
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

        private static byte[] ExecutarIgnorandoAusenciaDeFonte(Func<byte[]> acao)
        {
            try
            {
                return acao();
            }
            catch (TargetInvocationException ex) when (ex.InnerException is FileNotFoundException inner && inner.Message.Contains("No Fonts installed on this device!"))
            {
                Assert.Inconclusive("Ambiente de teste sem fontes instaladas para o PdfSharpCore.");
                throw;
            }
            catch (FileNotFoundException ex) when (ex.Message.Contains("No Fonts installed on this device!"))
            {
                Assert.Inconclusive("Ambiente de teste sem fontes instaladas para o PdfSharpCore.");
                throw;
            }
        }

        private static Exception CapturarExcecao(Action acao)
        {
            try
            {
                acao();
            }
            catch (Exception ex)
            {
                return ex;
            }

            Assert.Fail("Era esperada uma exceção.");
            return null;
        }
    }
}
