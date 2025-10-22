# Problema 1074 - Par ou Ímpar

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1074)**

## 🧠 Minha Lógica

Este problema é um exercício completo de classificação. Assim como no problema 1072 (Intervalo 2), o programa primeiro lê um valor `N` que atua como um "controlador", definindo quantas vezes o nosso laço de verificação será executado.

Para cada um dos `N` números lidos, o programa deve realizar duas verificações:
1.  **Sinal:** Se o número é POSITIVE, NEGATIVE ou NULL (zero).
2.  **Paridade:** Se o número é EVEN (par) ou ODD (ímpar).

A solução mais direta é construir uma cadeia de `if-else if` que teste todas as combinações possíveis e, o mais importante, trate o zero como um caso especial.

### Análise do Problema

O fluxo de trabalho é baseado em um laço e múltiplas condições aninhadas:

**1. Entrada de Dados**
* A primeira linha contém um inteiro `N` (a quantidade de testes).
* As `N` linhas seguintes contêm, cada uma, um valor inteiro `X` a ser classificado.

**2. Processamento**
* Um laço `for` é configurado para executar `N` vezes.
* A cada iteração, um número `X` é lido.
* Uma estrutura `if-else if` é usada para encontrar a classificação correta. A ordem das verificações é importante:
    1.  Verifica se é Positivo E Par (`X > 0 && X % 2 == 0`).
    2.  Senão, verifica se é Negativo E Par (`X < 0 && X % 2 == 0`).
    3.  Senão, verifica se é Positivo E Ímpar (`X > 0 && X % 2 != 0`).
    4.  Senão, verifica se é Negativo E Ímpar (`X < 0 && X % 2 != 0`).
    5.  Senão (se não for nada disso, só pode ser zero), classifica como `NULL`.

**3. Saída**
* Para cada número `X` lido, a sua classificação correspondente (ex: "EVEN POSITIVE") é impressa na tela, seguida por uma nova linha.

## A Lógica de Implementação

A solução foi implementada em duas partes: o controle do laço e a cadeia de classificação.

**1. Leitura de N e Estrutura do Laço**

Primeiro, lemos o valor `N` que define o número de repetições. O laço `for` é então usado para controlar o fluxo de leitura e verificação de cada número.

```csharp
// 1. Lê a quantidade de testes
int n = int.Parse(Console.ReadLine());
int num; // Variável que receberá o número a ser testado

// 2. O laço repete N vezes
for (int i = 0; i < n; i++)
{
    // 3. Lê o número a ser classificado DENTRO do laço
    num = int.Parse(Console.ReadLine());
    
    // 4. O bloco de classificação (if-else if) entra aqui
    // ...
}
```

**2. O Bloco de Classificação `if-else if`**

Dentro do laço `for`, esta cadeia de condições é responsável por analisar o `num` lido. O uso de `else if` garante que, assim que uma condição verdadeira é encontrada, as outras são ignoradas, e o laço parte para a próxima iteração.

```csharp
// (Código dentro do laço for)

if (num > 0 && num % 2 == 0)
{
    Console.WriteLine($"EVEN POSITIVE");
}
else if (num < 0 && num % 2 == 0)
{
    Console.WriteLine($"EVEN NEGATIVE");
}
else if (num > 0 && num % 2 != 0)
{
    Console.WriteLine($"ODD POSITIVE");
}
else if (num < 0 && num % 2 != 0)
{
    Console.WriteLine($"ODD NEGATIVE");
}
// O único caso restante é o zero
else if (num == 0) 
{
    Console.WriteLine("NULL");
}
```