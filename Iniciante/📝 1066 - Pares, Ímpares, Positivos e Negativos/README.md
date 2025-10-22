# Problema 1066 - Pares, Ímpares, Positivos e Negativos

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1066)**

## 🧠 Minha Lógica

Este problema é uma combinação de desafios anteriores (como o 1060 e o 1065). O objetivo é ler 5 números inteiros e, para cada número, classificá-lo em quatro categorias diferentes: Par, Ímpar, Positivo e Negativo.

A estratégia mais limpa, assim como nos problemas anteriores, é usar um laço `for` para ler os 5 números. A chave aqui é que, para cada número lido, precisamos realizar duas verificações separadas:
1.  Uma verificação de paridade (Par ou Ímpar).
2.  Uma verificação de sinal (Positivo ou Negativo).

Para armazenar os resultados, iniciei quatro variáveis contadoras com valor `0`.

### Análise do Problema

O fluxo de trabalho é uma expansão lógica dos exercícios anteriores:

**1. Entrada de Dados**
* O programa deve ler 5 números inteiros, um por linha.

**2. Processamento**
* **Fora do laço:** Quatro contadores são inicializados com zero: `contPares`, `contImpares`, `contPositivos` e `contNegativos`.
* **Dentro do laço:** Um `for` é configurado para executar 5 vezes (`i = 0` até `i < 5`).
    * A cada iteração, o programa lê um número inteiro (`num`).
    * **Primeira Verificação (Paridade):**
        * O programa checa `if (num % 2 == 0)`.
        * Se for verdade, `contPares++`.
        * Se não (`else`), `contImpares++`.
    * **Segunda Verificação (Sinal):**
        * O programa checa `if (num > 0)`.
        * Se for verdade, `contPositivos++`.
        * Se não, ele checa `else if (num < 0)`, incrementando `contNegativos++`.
* **Nota Importante:** A verificação de sinal deve ignorar o zero. O zero não é positivo nem negativo, mas *é* par. A lógica de `if/else if` separada garante que o zero seja contado corretamente como par, mas não como positivo ou negativo.

**3. Saída**
* Após o término do laço, o programa imprime o valor final de cada um dos quatro contadores, no formato exato exigido pelo problema.

## A Lógica de Implementação

A solução foi estruturada com os contadores e um laço `for` que contém as duas lógicas de verificação.

**1. Inicialização dos Contadores**

Primeiro, declaramos todas as variáveis que usaremos para contar, garantindo que comecem com o valor `0`.

```csharp
int contPares = 0;
int contImpares = 0;
int contPositivos = 0;
int contNegativos = 0;
```

**2. Leitura e Classificação (Dentro do Laço)**

O laço `for` repete o processo de leitura e classificação 5 vezes. Dentro do laço, cada `num` lido passa por dois blocos `if` independentes.

```csharp
for (int i = 0; i < 5; i++)
{
    int num = int.Parse(Console.ReadLine());

    // --- Bloco 1: Verificação de Paridade ---
    // (O número 0 será contado como Par aqui)
    if (num % 2 == 0)
    {
        contPares++;
    }
    else
    {
        contImpares++;
    }

    // --- Bloco 2: Verificação de Sinal ---
    // (O número 0 não entra em nenhuma dessas condições)
    if (num > 0)
    {
        contPositivos++;
    }
    else if (num < 0)
    {
        contNegativos++;
    }
}
```

**3. Exibição dos Resultados**

Após o laço processar todos os números, os valores finais dos contadores são impressos na ordem e formato exatos pedidos pelo enunciado.

```csharp
Console.WriteLine($"{contPares} valor(es) par(es)");
Console.WriteLine($"{contImpares} valor(es) impar(es)");
Console.WriteLine($"{contPositivos} valor(es) positivo(s)");
Console.WriteLine($"{contNegativos} valor(es) negativo(s)");
```