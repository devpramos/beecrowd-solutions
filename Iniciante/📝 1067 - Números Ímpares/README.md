# Problema 1067 - Números Ímpares

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1067)**

## 🧠 Minha Lógica

Este é um problema bem simples de repetição e filtragem. O objetivo é ler um número inteiro `X` e, em seguida, imprimir todos os números ímpares no intervalo de 1 até `X` (incluindo o próprio `X`, se for ímpar).

A solução é um laço `for` clássico. O laço será responsável por "visitar" cada número de 1 até `X`, e dentro dele, uma estrutura condicional `if` simples fará a verificação de paridade.

### Análise do Problema

O fluxo da solução é muito direto:

**1. Entrada de Dados**
* O programa lê um único número inteiro, `X`.
* O problema nos informa (e garante) que esse valor estará entre 1 e 1000 (`1 <= X <= 1000`).

**2. Processamento**
* Um laço `for` é iniciado com um contador `i` começando em 1.
* O laço continuará a ser executado enquanto `i` for menor ou igual a `X` (`i <= X`).
* A cada iteração, o programa verifica se o valor atual de `i` é ímpar.
* A regra matemática para isso é verificar se o resto da divisão de `i` por 2 é **diferente de 0** (`i % 2 != 0`).

**3. Saída**
* Se a condição (ser ímpar) for verdadeira, o valor de `i` é impresso no console.
* Cada número deve ser impresso em sua própria linha.

## A Lógica de Implementação

A implementação é focada em um `for` e um `if`.

**1. Leitura do Valor Limite (X)**

Primeiro, lemos o número `X` que o usuário irá fornecer. Este valor determinará até onde o nosso laço de repetição deve ir.

```csharp
int x = int.Parse(Console.ReadLine());
```

**2. Laço de Repetição e Verificação**

Em seguida, criamos o laço `for`. Ele é configurado para iniciar o contador `i` em 1 (pois o problema pede os ímpares a partir de 1) e parar quando `i` ultrapassar `X`.

Dentro do laço, a instrução `if` usa o operador de módulo (`%`) para checar o resto da divisão. Se o resto for diferente de 0, o número é ímpar e, portanto, é impresso.

```csharp
// O laço vai de 1 até o valor de x
for (int i = 1; i <= x; i++)
{
    // Se o resto da divisão de i por 2 for diferente de 0...
    if (i % 2 != 0)
    {
        // ...significa que 'i' é ímpar, então o imprimimos.
        Console.WriteLine(i);
    }
}
```