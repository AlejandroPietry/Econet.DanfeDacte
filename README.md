### Econet DacteDanfe é uma biblioteca em C# que permite a geração do DANFE e do DACTE em formato PDF. Feito em `netstandard2.0` e multiplataforma.

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

### Exemplo avançado de DANFE a partir do XML
```csharp
string xmlNfe = File.ReadAllText("nota.xml");

var modelo = DanfeViewModelCreator.CriarDeStringXml(xmlNfe);

using (var danfe = new DanfeDoc(modelo))
{
    danfe.Gerar();
    danfe.Salvar("Danfe.pdf");
}
```

### Exemplo avançado de DANFE retornando bytes
```csharp
string xmlNfe = File.ReadAllText("nota.xml");
var modelo = DanfeViewModelCreator.CriarDeStringXml(xmlNfe);

byte[] pdfBytes;
using (var memoryStream = new MemoryStream())
using (var danfe = new DanfeDoc(modelo))
{
    danfe.Gerar();
    pdfBytes = danfe.ObterPdfBytes(memoryStream);
}
```

### Exemplo avançado de DANFE com logotipo
```csharp
string xmlNfe = File.ReadAllText("nota.xml");
var modelo = DanfeViewModelCreator.CriarDeStringXml(xmlNfe);

using (var danfe = new DanfeDoc(modelo))
{
    danfe.AdicionarLogoImagem("logo.jpg");
    danfe.Gerar();
    danfe.Salvar("Danfe-com-logo.pdf");
}
```

### Exemplo avançado de DACTE
```csharp
string xmlCte = File.ReadAllText("cte.xml");
var modelo = DacteViewModelCreator.Criar57DeStringXml(xmlCte);

using (var dacte = new Dacte(modelo))
{
    dacte.Gerar();
    dacte.Salvar("Dacte.pdf");
}
```

### Exemplo avançado de DACTE OS
```csharp
string xmlCteOs = File.ReadAllText("cteos.xml");
var modelo = DacteViewModelCreator.Criar67DeStringXml(xmlCteOs);

using (var dacte = new Dacte(modelo))
{
    dacte.Gerar();
    dacte.Salvar("Dacte-OS.pdf");
}
```

### Créditos

Créditos também ao [FiscalSync](https://fiscalsync.com.br/).
