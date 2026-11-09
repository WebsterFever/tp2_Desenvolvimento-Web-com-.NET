# CityManager — TP2 Desenvolvimento Web com .NET

Projeto de estudo em **ASP.NET Core Razor Pages (.NET 10)**.

## Executar
Abra `CityManager.slnx` no Visual Studio ou execute:
```bash
dotnet run --project CityManager/CityManager.csproj
```


## Índice numerado para correção

Cada pasta abaixo contém a descrição, os links para os arquivos `.cshtml` / `.cshtml.cs` e a URL para testar. As páginas executáveis continuam em `CityManager/Pages/CityManager` para preservar o roteamento.

- [Exercicio01](Exercicio01/README.md)
- [Exercicio02](Exercicio02/README.md)
- [Exercicio03](Exercicio03/README.md)
- [Exercicio04](Exercicio04/README.md)
- [Exercicio05](Exercicio05/README.md)
- [Exercicio06](Exercicio06/README.md)
- [Exercicio07](Exercicio07/README.md)
- [Exercicio08](Exercicio08/README.md)
- [Exercicio09](Exercicio09/README.md)
- [Exercicio10](Exercicio10/README.md)
- [Exercicio11](Exercicio11/README.md)
- [Exercicio12](Exercicio12/README.md)


## Páginas organizadas no Visual Studio

Cada pasta `CityManager/Pages/Exercicio01` até `Exercicio12` contém um par de arquivos Razor e C# com nome descritivo.

| Exercício | Arquivos | URL |
|---|---|---|
| 01 | `CreateCity.cshtml` e `CreateCity.cshtml.cs` | `/Exercicio01/CreateCity` |
| 02 | `CreateCityHandler.cshtml` e `CreateCityHandler.cshtml.cs` | `/Exercicio02/CreateCityHandler` |
| 03 | `CreateCityValidation.cshtml` e `CreateCityValidation.cshtml.cs` | `/Exercicio03/CreateCityValidation` |
| 04 | `CreateCityModelState.cshtml` e `CreateCityModelState.cshtml.cs` | `/Exercicio04/CreateCityModelState` |
| 05 | `CreateCountry.cshtml` e `CreateCountry.cshtml.cs` | `/Exercicio05/CreateCountry` |
| 06 | `CreateCountryValidation.cshtml` e `CreateCountryValidation.cshtml.cs` | `/Exercicio06/CreateCountryValidation` |
| 07 | `MultipleCountries.cshtml` e `MultipleCountries.cshtml.cs` | `/Exercicio07/MultipleCountries` |
| 08 | `CityDetails.cshtml` e `CityDetails.cshtml.cs` | `/Exercicio08/CityDetails/Blumenau` |
| 09 | `CityLinks.cshtml` e `CityLinks.cshtml.cs` | `/Exercicio09/CityLinks` |
| 10 | `SaveNote.cshtml` e `SaveNote.cshtml.cs` | `/Exercicio10/SaveNote` |
| 11 | `ReadNotes.cshtml` e `ReadNotes.cshtml.cs` | `/Exercicio11/ReadNotes` |
| 12 | `CreateCountryCustomValidation.cshtml` e `CreateCountryCustomValidation.cshtml.cs` | `/Exercicio12/CreateCountryCustomValidation` |

## Testes manuais
- Cidade: vazio, 2 letras e 3+ letras.
- País: Brasil/BR, Brasil/B, Brasil/BRA, Brasil/vazio e Brasil/US.
- Cinco países: preencher todas as linhas e testar uma linha vazia.
- Roteamento: acessar Rio, São Paulo e Brasília pelos links.
- Arquivos: salvar nota, baixar, listar e ler.

**Nota:** a regra didática de mesma letra para país/código não representa a especificação ISO. Os arquivos em `wwwroot/files` são públicos; não armazene dados sensíveis. Não há persistência em banco de dados.

## Estado
Implementação preparada para revisão e testes no Visual Studio. Não declarar compilação validada sem executar `dotnet build`.
