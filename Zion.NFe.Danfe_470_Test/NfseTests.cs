using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Zion.NFe.Danfe;

namespace Zion.NFe.Danfe_470_Test
{
    [TestClass]
    public class NfseTests
    {
        [TestMethod]
        public void GerarNfsePdfDeXml_RetornaBytes()
        {
            var xml = @"
<NFSe>
  <infNFSe Id=""NFSe123"">
    <nNFSe>123</nNFSe>
    <cVerif>ABC123</cVerif>
    <dhProc>2026-05-03T10:00:00</dhProc>
    <DPS>
      <InfDPS>
        <nDPS>456</nDPS>
        <serie>1</serie>
        <dCompet>2026-05-01</dCompet>
        <prest>
          <CNPJ>12345678000199</CNPJ>
          <IM>12345</IM>
          <xNome>Prestador Exemplo LTDA</xNome>
          <enderNac>
            <xLgr>Rua A</xLgr>
            <nro>100</nro>
            <xCpl>Sala 10</xCpl>
            <xBairro>Centro</xBairro>
            <xMun>São Paulo</xMun>
            <UF>SP</UF>
            <CEP>01001000</CEP>
          </enderNac>
          <email>contato@exemplo.com.br</email>
          <fone>1133334444</fone>
        </prest>
        <toma>
          <CPF>12345678901</CPF>
          <xNome>Tomador Exemplo</xNome>
          <enderNac>
            <xLgr>Avenida B</xLgr>
            <nro>200</nro>
            <xCpl>Conj 20</xCpl>
            <xBairro>Vila Nova</xBairro>
            <xMun>Campinas</xMun>
            <UF>SP</UF>
            <CEP>13010000</CEP>
          </enderNac>
          <email>cliente@exemplo.com.br</email>
          <fone>11999990000</fone>
        </toma>
        <serv>
          <xDescServ>Prestação de serviço de exemplo para validação da geração do PDF.</xDescServ>
        </serv>
        <valores>
          <vServPrest>
            <vServ>150.25</vServ>
          </vServPrest>
          <vLiq>150.25</vLiq>
          <vISSQN>7.51</vISSQN>
          <pAliqAplic>5.00</pAliqAplic>
        </valores>
      </InfDPS>
    </DPS>
  </infNFSe>
</NFSe>";

            var pdfBytes = GeradorPdf.GerarNfsePdfDeXml(xml);

            Assert.IsNotNull(pdfBytes);
            Assert.IsTrue(pdfBytes.Length > 0);
        }

        [TestMethod]
        public void GerarNfsePdfDeXml_ExemploArquivo_RetornaBytes()
        {
            var xmlPath = Path.Combine("Xml", "NFSe", "exemplo-2026-01-08.xml");
            Assert.IsTrue(File.Exists(xmlPath), $"Arquivo de exemplo não encontrado: {xmlPath}");

            var xml = File.ReadAllText(xmlPath);
            var pdfBytes = GeradorPdf.GerarNfsePdfDeXml(xml);

            Assert.IsNotNull(pdfBytes);
            Assert.IsTrue(pdfBytes.Length > 0);
        }
    }
}
