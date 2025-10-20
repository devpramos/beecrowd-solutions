# Problema 1059 - Números Pares

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1059)**

## 🧠 Minha Lógica

Este é um exercício de repetição extremamente simples, com um objetivo claro: imprimir todos os números pares no intervalo de 1 a 100. A principal característica deste problema é que ele não exige nenhuma entrada de dados do usuário; a lógica é completamente autônoma.

Como a quantidade de repetições é bem definida (de 1 até 100), a estrutura de laço `for` é a escolha mais natural e eficiente para resolver o desafio.

### Análise do Problema

O fluxo de execução é direto e não depende de fatores externos:

**1. Entrada de Dados**
* Nenhuma entrada é necessária.

**2. Processamento**
* O programa precisa percorrer, um a um, todos os números no intervalo de 1 a 100.
* Para cada número nesse intervalo, é preciso aplicar uma verificação para determinar se ele é par.
* A regra matemática para identificar um número par é verificar se o resto da sua divisão por 2 é igual a 0.

**3. Saída**
* Sempre que um número for identificado como par, ele deve ser impresso no console. Cada número par deve ocupar uma nova linha.

## A Lógica de Implementação

A solução é construída em torno de um laço de repetição `for` que contém uma única condição `if`.

**1. Estruturando o Laço de Repetição**

Para percorrer todos os números de 1 a 100, um laço `for` foi implementado. A variável contadora, que chamei de `i`, inicia com o valor `1`, e a cada ciclo do laço, seu valor é incrementado em 1, até que atinja 100.

```csharp
for (int i = 1; i <= 100; i++)
{
    // A lógica de verificação entra aqui
}
```

**2. Verificando se o Número é Par**

Dentro do laço, a cada nova iteração, o valor atual de `i` precisa ser testado. Para isso, usei uma estrutura condicional `if`. A condição `i % 2 == 0` utiliza o operador de módulo (`%`) para obter o resto da divisão de `i` por 2. Se o resto for 0, significa que o número é par.

Quando a condição é verdadeira, o comando para imprimir o valor de `i` é executado.

```csharp
// Lógica completa
for (int i = 1; i <= 100; i++)
{
    // Se o resto da divisão de i por 2 for 0...
    if (i % 2 == 0)
    {
        // ...então o número é par, e o imprimimos no console.
        Console.WriteLine(i);
    }
}
```