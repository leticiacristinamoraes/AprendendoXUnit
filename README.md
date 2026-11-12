# Aprendendo testes parametrizados com xUnit

Projeto desenvolvido como parte da atividade **"Aprender com IA sem terceirizar o aprendizado"**, da disciplina AI First.

## Objetivo

Aprender os conceitos básicos de testes unitários e testes parametrizados utilizando **C#, .NET 10 e xUnit**, com apoio da inteligência artificial durante o processo de aprendizagem.

Escolhi essa tecnologia porque já tenho experiência com C#, mas ainda não havia trabalhado com xUnit.

## Sobre o projeto

A demonstração consiste em uma calculadora simples de descontos, que recebe o preço de um produto e um percentual de desconto.

Foram implementados testes para verificar:

- O cálculo correto de descontos em diferentes situações.
- Casos extremos, como descontos de 0% e 100%.
- O tratamento de valores inválidos, como preços negativos e descontos superiores a 100%.

## Conceitos explorados

- **`[Fact]`**: utilizado para criar testes sem parâmetros.
- **`[Theory]`**: permite executar um mesmo teste com diferentes conjuntos de dados.
- **`[InlineData]`**: fornece os valores utilizados em cada execução.
- **`Assert.Equal`**: compara o resultado obtido com o esperado.
- **`Assert.Throws`**: verifica se uma exceção é lançada.

## Como executar

É necessário ter o .NET SDK instalado.

Clone o repositório e, no terminal, dentro da pasta do projeto, execute:

```bash
dotnet restore
dotnet test
```

## Resultado

A execução local apresentou:

- **9 testes executados**
- **9 testes aprovados**
- **0 falhas**

Os testes foram executados utilizando .NET 10 e xUnit.

## Uso da inteligência artificial

Utilizei a IA como apoio para entender os conceitos iniciais, conhecer os atributos utilizados pelo xUnit, construir uma demonstração e investigar problemas encontrados durante a execução dos testes.

Durante a implementação, também consultei os resultados apresentados pelo terminal para verificar se os testes estavam sendo reconhecidos e executados corretamente.

O objetivo foi utilizar a IA como facilitadora do aprendizado, buscando compreender o funcionamento da solução em vez de apenas obter código pronto.

## Referências oficiais

- [xUnit — Getting Started](https://xunit.net/docs/getting-started/v3/getting-started)
- [Microsoft Learn — Testes unitários com xUnit](https://learn.microsoft.com/pt-br/dotnet/core/testing/unit-testing-csharp-with-xunit)

## Contexto acadêmico

**Atividade:** Aprender com IA sem terceirizar o aprendizado  
**Disciplina:** AI First  
**Data:** Novembro de 2026