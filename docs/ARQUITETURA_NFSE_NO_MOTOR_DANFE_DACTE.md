# Arquitetura proposta para NFS-e usando o motor do DANFE/DACTE

Este documento define como adicionar suporte a NFS-e neste repositório sem usar HTML como origem do PDF.
A ideia e aproveitar a infraestrutura de composicao grafica, paginação e salvamento de PDF que ja existe em `DanfeDoc` e `Dacte`, mas com um modelo e um conjunto de blocos proprios para NFS-e.

## Objetivo

Criar um novo fluxo de geracao de PDF para NFS-e com estas caracteristicas:

- Entrada: XML de NFS-e
- Saida: PDF binario ou arquivo em disco
- Motor: composicao de blocos PDF, nao HTML
- Reuso: infraestrutura de PDF, paginas, fontes, logos e utilitarios de desenho
- Isolamento: NFS-e deve ficar separada de `DANFE` e `DACTE`

## Principio de integracao

Nao devemos adaptar NFS-e para caber dentro de `DanfeDoc` ou `Dacte`.
O caminho certo e criar um terceiro documento:

- `NfseDoc`

Esse documento deve seguir o mesmo estilo de API dos documentos atuais:

- construtor com `ViewModel`
- metodo `Gerar()`
- metodo `Salvar(...)`
- metodo `ObterPdfBytes(...)`
- suporte a logo

## Reuso possivel

O que pode ser reaproveitado:

- estrutura de paginas
- padrao `IDisposable`
- carregamento de logo
- salvamento em stream/arquivo
- fontes e estilo de desenho
- utilitarios de formatacao
- padrao de blocos e elementos visuais

O que nao deve ser reaproveitado diretamente:

- o parser de `NF-e`
- o parser de `CT-e`
- o layout atual de blocos do DANFE/DACTE
- qualquer suposicao especifica de nota fiscal modelo 55 ou CT-e

## Estrutura sugerida

### Novo modulo

Criar uma area nova no projeto principal:

- `Zion.NFe.Danfe/Nfse/`

Subpastas sugeridas:

- `Nfse/Modelo/`
- `Nfse/Blocos/`
- `Nfse/Elementos/`
- `Nfse/Parser/`
- `Nfse/Schema/`
- `Nfse/Tools/`

### Classes principais

- `NfseDoc`
- `NfseViewModel`
- `NfseViewModelCreator`
- `GeradorPdf.GerarNfsePdfDeXml(...)`
- `GeradorPdf.GerarNfsePdf(...)`

### Blocos iniciais provaveis

Os blocos podem variar conforme o layout final da NFS-e, mas a divisao inicial costuma ser:

- cabecalho / identificacao
- dados do prestador
- dados do tomador
- discriminacao do servico
- valores / tributos
- retencoes
- informacoes complementares
- codigo de verificacao / chave / QRCode, se aplicavel

## Modelo de dados

O `NfseViewModel` deve ser uma estrutura pronta para renderizacao, nao um espelho cru do XML.

Isso e importante porque:

- o XML da NFS-e pode variar por padrao/municipio
- o documento visual precisa de campos normalizados
- formatos de data, moeda, municipio e tributacao devem sair prontos para o desenho

Campos comuns provaveis:

- numero da NFS-e
- serie
- data e hora de emissao
- codigo de verificacao / chave de acesso
- prestador
- tomador
- discriminacao do servico
- valores do servico
- impostos
- retencoes
- observacoes
- ambiente de producao/homologacao

## Parser do XML

O parser deve converter XML em `NfseViewModel`.

Requisitos:

- aceitar `string`, `Stream` e arquivo, se necessario
- validar XML nulo ou malformado
- expor erros claros para campos obrigatorios ausentes
- separar parsing de mapeamento visual

Sugestao de organizacao:

- `NfseSchema` para classes de serializacao
- `NfseViewModelCreator` para conversao do schema para o modelo de tela

## Fachada publica

Para manter a experiencia parecida com a API atual:

```csharp
byte[] GeradorPdf.GerarNfsePdfDeXml(string xml)
byte[] GeradorPdf.GerarNfsePdfDeXml(Stream xmlStream)
```

Depois, se houver necessidade, pode existir uma API avancada:

```csharp
using var doc = new NfseDoc(modelo);
doc.Gerar();
doc.Salvar("nfse.pdf");
```

## Reuso tecnico do motor atual

A melhor estrategia e extrair ou espelhar a infraestrutura de renderizacao atual em um nivel mais baixo:

- `PaginaBase`
- `DocumentoPdfBase`
- `BlocoBase`
- `ElementoBase`
- `Estilo`
- `Fonte`

Se a base atual nao estiver preparada para heranca compartilhada, a alternativa pragmatica e:

- manter `DanfeDoc` e `Dacte` como estao
- criar classes equivalentes para NFS-e
- copiar apenas o necessario de forma controlada

Isso evita acoplamento excessivo e reduz risco de regressao nos documentos existentes.

## Ordem de implementacao recomendada

1. Definir qual layout de NFS-e sera suportado primeiro.
2. Criar o schema e o view model.
3. Criar o parser XML -> modelo.
4. Criar `NfseDoc` com uma pagina simples e um bloco de cabecalho.
5. Adicionar blocos adicionais por necessidade real do layout.
6. Expor a fachada publica em `GeradorPdf`.
7. Adicionar testes com XML real.

## Riscos

- NFS-e nao e um padrao unico na pratica; municipios podem variar
- o layout visual pode exigir ajustes finos de espaco e quebra de linha
- alguns XMLs podem nao trazer todos os campos esperados
- o motor atual foi feito para DANFE/DACTE, entao pode exigir pequenas adaptacoes em classes base

## Decisao tecnica

A decisao recomendada e:

- nao usar HTML
- nao misturar NFS-e com `DanfeDoc` ou `Dacte`
- criar um novo documento PDF no mesmo estilo arquitetural
- reutilizar apenas a infraestrutura de desenho e persistencia

