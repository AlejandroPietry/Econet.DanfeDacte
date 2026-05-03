### Econet DacteDanfe é uma biblioteca em C# que permite a geração do DANFE e do DACTE em formato PDF. Feito em netstandard2.0 e multiplataforma.

### Exemplo para gerar DACTE
```csharp
string xmlCte = "ExemploXmlDacte";

var pdfBytesCte = GeradorPdf.GerarDactePdfDeXml(xmlCte, ModeloDacte.Cte57);
var pdfBytesCteOs = GeradorPdf.GerarDactePdfDeXml(xmlCte, ModeloDacte.CteOs67);

File.WriteAllBytes("Dacte.pdf", pdfBytesCte);
```

### Exemplo para gerar DANFE
```csharp
string xmlNfe = "ExemploXmlDanfe";

var pdfBytes = GeradorPdf.GerarDanfePdfDeXml(xmlNfe);

File.WriteAllBytes("Danfe.pdf", pdfBytes);
```

### API avançada

Se precisar customizar o documento manualmente, a API atual com `DanfeDoc`, `Dacte`, `DanfeViewModelCreator` e `DacteViewModelCreator` continua disponível.

### Créditos

Biblioteca construída com base no [Zion.Danfe](https://github.com/Laranjeiras/Zion.NFe.Danfe).
Créditos também ao [FiscalSync](https://fiscalsync.com.br/).
