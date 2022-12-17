### Econet DacteDanfe é uma biblioteca em C# que permite a geração do DANFE e do DACTE em formato PDF. Com muitas possibilidades! Feito em netstandard2.0 é multiplataforma.

### Exemplo para gerar Dacte
```C#
byte[] pdfBytes;
string xmlCte = "ExemploXmlDacte";

//para Cte usamos:
var modelo = DacteViewModelCreator.Criar57DeStringXml(xmlCTe);
//para Cte-OS usamos:
var modelo = DacteViewModelCreator.Criar67DeStringXml(xmlCTe);

//Para obter os bytes do pdf gerado
using (var ms = new MemoryStream())
{
    using var dacte = new Dacte(modelo);
    dacte.Gerar();
    pdfBytes = dacte.ObterPdfBytes(ms);
}

//Para salvar o pdf em um diretorio especifico.
using (var ms = new MemoryStream())
{
    using var dacte = new Dacte(modelo);
    dacte.Gerar();
    dacte.Salvar("Dacte.pdf");
}

```

### Exemplo para gerar Danfe

```C#
string xmlNfe = "exemplo de xml nfe";

var modelo = DanfeViewModelCreator.CriarDeStringXml(xmlNFe);

//Para obter os bytes do pdf gerado
var ms = new MemoryStream();
using (var danfe = new DanfeDoc(modelo))
{
    danfe.Gerar();
    var bytesPdf = danfe.ObterPdfBytes(ms);
    return bytesPdf;
}

//Para salvar o pdf em um diretorio especifico.
var ms = new MemoryStream();
using (var danfe = new DanfeDoc(modelo))
{
    danfe.Gerar();
    danfe.Salvar("Danfe.pdf");
}

```

Biblioteca construída com base no [Zion.Danfe](https://github.com/Laranjeiras/Zion.NFe.Danfe), porém com suporte para gerar Dacte.
Meus agradecimentos ao [Alexandre Laranjeiras](https://github.com/Laranjeiras)