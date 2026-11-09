# CityManager — TP2 Desenvolvimento Web com .NET

Projeto de estudo em **ASP.NET Core Razor Pages (.NET 10)**.

## Executar
Abra `CityManager.slnx` no Visual Studio ou execute:
```bash
dotnet run --project CityManager/CityManager.csproj
```

## Exercícios e rotas

| Exercício | Objetivo | Rota |
|---|---|---|
| 1 | Formulário com BindProperty (versão original na branch master) | /CityManager/CreateCity |
| 2 | Parâmetro no OnPost sem BindProperty | /CityManager/CreateCityHandler |
| 3 e 4 | Data Annotations, ModelState e validação no cliente | /CityManager/CreateCity |
| 5, 6 e 12 | Country, código ISO e validação personalizada | /CityManager/CreateCountry |
| 7 | Enviar cinco países em um formulário | /CityManager/MultipleCountries |
| 8 | Rota com nome da cidade | /CityManager/CityDetails/Rio |
| 9 | Links dinâmicos com Tag Helpers | /CityManager/CityLinks |
| 10 | Escrever anotação em arquivo | /CityManager/SaveNote |
| 11 | Listar e ler anotações | /CityManager/ReadNotes |

## Testes manuais
- Cidade: vazio, 2 letras e 3+ letras.
- País: Brasil/BR, Brasil/B, Brasil/BRA, Brasil/vazio e Brasil/US.
- Cinco países: preencher todas as linhas e testar uma linha vazia.
- Roteamento: acessar Rio, São Paulo e Brasília pelos links.
- Arquivos: salvar nota, baixar, listar e ler.

**Nota:** a regra didática de mesma letra para país/código não representa a especificação ISO. Os arquivos em `wwwroot/files` são públicos; não armazene dados sensíveis. Não há persistência em banco de dados.

## Estado
Implementação preparada para revisão e testes no Visual Studio. Não declarar compilação validada sem executar `dotnet build`.
