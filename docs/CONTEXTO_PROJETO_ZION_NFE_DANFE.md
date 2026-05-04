# Contexto do projeto Zion.NFe.Danfe

Documento de referência do repositório `Econet.DanfeDacte`, com foco no pacote `Zion.NFe.Danfe`.
Use este arquivo como ponto de partida para entender rapidamente a arquitetura, os fluxos principais e as limitações conhecidas do projeto.

## Visão geral

O projeto entrega uma biblioteca C# para gerar:

- `DANFE` a partir de XML de `NF-e`
- `DACTE` a partir de XML de `CT-e`

A biblioteca principal é `netstandard2.0`, então o objetivo é permitir uso multiplataforma. Há também um webservice `net6.0` que funciona como demonstração/endpoint de teste, além de um projeto de testes legado.

## Estrutura do repositório

- `Zion.NFe.Danfe/`: biblioteca principal de geração de PDF.
- `Zion.NFe.Danfe.WebService/`: API ASP.NET Core com endpoints de exemplo para gerar PDFs.
- `Zion.NFe.Danfe_470_Test/`: testes e massas de XML/figuras para validação manual e automatizada.
- `README.md`: exemplos públicos de uso.
- `docs/CONTEXTO_PROJETO_ZION_NFE_DANFE.md`: este documento.

## Responsabilidade de cada projeto

### `Zion.NFe.Danfe`

É o núcleo do sistema. Contém:

- Fachada de geração rápida: `GeradorPdf`
- Geração avançada de `DANFE`: `DanfeDoc`
- Geração avançada de `DACTE`: `Dacte`
- Conversores de XML para modelos de tela: `DanfeViewModelCreator` e `DacteViewModelCreator`
- Modelos de dados, blocos visuais, elementos PDF e utilitários de formatação

### `Zion.NFe.Danfe.WebService`

É um webservice mínimo usado para disparar a geração de PDF via HTTP. Hoje ele contém rotas fixas e lê XML de caminhos locais hardcoded no controlador, então ele serve mais como exemplo técnico do que como API pronta para produção.

### `Zion.NFe.Danfe_470_Test`

Conjunto de testes com XMLs de diferentes versões de `NF-e`, imagens de logo e cenários de renderização.
Os testes ajudam a entender o que já foi suportado pelo projeto em versões anteriores.

## Entradas e saídas

### Entrada principal

- XML processado de `NF-e` para gerar `DANFE`
- XML processado de `CT-e` ou `CT-e OS` para gerar `DACTE`

### Saída principal

- `byte[]` com o PDF gerado
- `Stream` ou arquivo em disco quando se usa a API avançada

## API pública relevante

### Fachada rápida

- `GeradorPdf.GerarDanfePdfDeXml(string xml)`
- `GeradorPdf.GerarDanfePdfDeXml(Stream xmlStream)`
- `GeradorPdf.GerarDactePdfDeXml(string xml, ModeloDacte modelo)`
- `GeradorPdf.GerarDactePdfDeXml(Stream xmlStream, ModeloDacte modelo)`

Essa fachada valida parâmetros nulos, converte XML em modelo e devolve o PDF já pronto.

### DANFE avançado

- `DanfeDoc`
- `DanfeViewModelCreator`
- `DanfeViewModel`

O fluxo típico é:

1. Ler o XML.
2. Converter para `DanfeViewModel`.
3. Criar `DanfeDoc`.
4. Chamar `Gerar()`.
5. Salvar em arquivo ou obter bytes.

### DACTE avançado

- `Dacte`
- `DacteViewModelCreator`
- `DacteViewModel`

O fluxo é equivalente ao do DANFE, mas com suporte às variações de CT-e e CT-e OS.

## O que o código suporta hoje

### DANFE

- XML `NF-e` processado
- Modos de emissão suportados:
  - Normal
  - Contingência SVC-AN
  - Contingência SVC-RS
- Orientação:
  - Retrato
  - Paisagem
- Blocos opcionais para local de entrega, local de retirada e duplicatas
- Inclusão de logotipo via imagem ou PDF
- Renderização de múltiplas páginas para lista de produtos/serviços

### DACTE

- `CT-e` modelo `57`
- `CT-e OS` modelo `67`
- Modalidades tratadas no modelo:
  - Rodoviário
  - Aéreo
  - Aquaviário
  - Ferroviário
  - Dutoviário
  - Multimodal

## Formatação e renderização

O projeto usa bibliotecas de PDF e imagem referenciadas no `.csproj`, com destaque para:

- `PdfSharpCore`
- `SixLabors.Fonts`
- `SixLabors.ImageSharp`
- `ICSharpCode.SharpZipLib`

O código também mostra dependência de `PdfClown` em partes da renderização. A escolha de fontes segue a regra interna comentada no código: `Times` ou `Courier`.

## Regras e comportamento importantes

- O `DanfeDoc` e o `Dacte` só podem ser gerados uma vez por instância.
- Há validação explícita para `null` em pontos de entrada públicos.
- O gerador de `DACTE` dispara `ArgumentOutOfRangeException` se o enum `ModeloDacte` não for um valor suportado.
- A criação do modelo a partir do XML lança exceções com mensagens específicas quando o XML é inválido ou não representa o tipo esperado.
- A adição de logotipo aceita imagem JPEG não progressiva ou PDF.

## Testes e evidências

Os testes existentes mostram que o projeto já valida:

- Geração de `DANFE` a partir de XML e `Stream`
- Geração de `DANFE` com XMLs de `NF-e` v1.00, v2.00, v3.10 e v4.00
- Geração de `DACTE` a partir de XML
- Tratamento de XML inválido
- Tratamento de modelo de DACTE inválido
- Cenários com canhotos, contingência, local de entrega e local de retirada

## Webservice

Endpoints atuais em `XmlController`:

- `GET /api/xml/pdf/gerar`
- `GET /api/xml/pdf/gerar-dacte`

Observações:

- Os endpoints usam caminhos locais fixos para arquivos XML.
- O projeto está configurado com `AddControllers()` e roteamento por endpoint.
- O `Program.cs` limpa providers padrão de log e adiciona apenas console/debug.

## Limitações e pontos de atenção

- O controlador do webservice não recebe XML por request; ele lê arquivos locais hardcoded.
- Existem nomes e namespaces legados/históricos misturados, como `ECONET.EcoNFe2` e `ZionDanfe`.
- Parte da implementação é bastante acoplada ao formato específico dos XMLs de entrada.
- Há código legado e comentários `TODO` em trechos do DACTE OS, indicando suporte menos maduro nesse caminho.

## Evolução planejada

Há uma proposta separada para adicionar NFS-e ao repositório sem usar HTML como fonte do PDF.
Essa proposta está documentada em [docs/ARQUITETURA_NFSE_NO_MOTOR_DANFE_DACTE.md](docs/ARQUITETURA_NFSE_NO_MOTOR_DANFE_DACTE.md) e já foi materializada em um primeiro módulo de NFS-e com:

- `Zion.NFe.Danfe/Nfse/Modelo/NfseViewModel.cs`
- `Zion.NFe.Danfe/Nfse/Modelo/NfseViewModelCreator.cs`
- `Zion.NFe.Danfe/Nfse/NfseDoc.cs`
- `Zion.NFe.Danfe/Nfse/NfsePagina.cs`
- `GeradorPdf.GerarNfsePdfDeXml(...)`

O suporte atual é o primeiro corte funcional do módulo, com parser tolerante de XML e renderização em PDF usando o motor gráfico existente.
Há também um XML de exemplo salvo para testes e validação em [Zion.NFe.Danfe_470_Test/Xml/NFSe/exemplo-2026-01-08.xml](../Zion.NFe.Danfe_470_Test/Xml/NFSe/exemplo-2026-01-08.xml).
O preview da NFS-e é gerado com marca d'água `MODELO` / `SEM VALOR FISCAL`.

## Resumo operacional

Se a próxima tarefa for mexer neste projeto, a sequência de leitura mais útil é:

1. Este documento.
2. `README.md`.
3. `Zion.NFe.Danfe/GeradorPdf.cs`.
4. `Zion.NFe.Danfe/Modelo/DanfeViewModelCreator.cs`.
5. `Zion.NFe.Danfe/Dacte/DacteSharp/Modelo/DacteViewModelCreator.cs`.
6. `Zion.NFe.Danfe/DanfeDoc.cs` e `Zion.NFe.Danfe/Dacte/DacteSharp/Dacte.cs`.
7. `Zion.NFe.Danfe.WebService/Controllers/XmlController.cs`.
8. `docs/ARQUITETURA_NFSE_NO_MOTOR_DANFE_DACTE.md`.

## Observação de manutenção

Este documento deve ser atualizado sempre que houver mudança relevante em:

- formatos de XML suportados
- novas rotas do webservice
- novos modelos de entrada/saída
- mudança de dependências ou versões
- alterações no fluxo de geração de PDF
