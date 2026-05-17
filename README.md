# ConsoleApp1

Projeto .NET 10 gerado em Visual Studio.

Descrição

Este repositório contém uma aplicação console de exemplo (ConsoleApp1).

Pré-requisitos

- .NET 10 SDK instalado: https://dotnet.microsoft.com/

Como compilar e executar

No diretório raiz do repositório:

- Restaurar dependências:
  dotnet restore
- Compilar:
  dotnet build --configuration Release
- Executar (a partir da pasta do projeto ou especificando o projeto):
  dotnet run --project ConsoleApp1/ConsoleApp1.csproj

Integração contínua

Um workflow do GitHub Actions foi adicionado para compilar e executar testes em pushes e pull requests para a branch main.
