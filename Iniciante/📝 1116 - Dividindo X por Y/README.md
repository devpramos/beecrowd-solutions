# Problema 1116 - Dividindo X por Y

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1116)**

## 🧠 Minha Lógica

Este é um problema de processamento em lote (ou "batch"). O programa primeiro lê um valor `N` que define a quantidade de casos de teste. Em seguida, um laço `for` é usado para repetir a lógica de divisão `N` vezes.

A cada iteração, o programa lê uma linha contendo dois números, `X` (dividendo) e `Y` (divisor).

O ponto mais importante deste desafio é a restrição matemática: **é impossível dividir por zero**.

Portanto, a lógica principal dentro do laço não é apenas calcular, mas sim **verificar antes de exibir**.
1.  Ler `X` e `Y`.
2.  Verificar `if (y == 0)`.
3.  Se `Y` for zero, o programa deve imprimir "divisao impossivel".
4.  Se `Y` for qualquer outro número, o programa realiza a divisão e imprime o resultado formatado com uma casa decimal.

Para que a divisão resulte em um número com casas decimais (ex: 5 / 2 = 2.5), as variáveis `X` e `Y` foram lidas como `double`.

### Análise do Problema

O fluxo de trabalho é um laço que contém uma condição de guarda.

**1. Entrada de Dados**
* A primeira linha contém um inteiro `N` (o número de casos de teste).
* As `N` linhas seguintes contêm, cada uma, um par de números `X` e `Y` (lidos como `double`).

**2. Processamento (Dentro do laço N)**
* A cada iteração:
    1.  A linha é lida e dividida (`Split(' ')`).
    2.  `X` e `Y` são convertidos para `double`.
    3.  A divisão `div = x / y` é calculada.
    4.  Uma condição `if` verifica se `Y` é igual a 0.

**3. Saída**
* Se `Y == 0`, imprime "divisao impossivel".
* Caso contrário (`else`), imprime o valor de `div` formatado com uma casa decimal (`:F1`).

## A Lógica de Implementação

A solução é implementada com um laço `for` que envolve a lógica de verificação.

**1. Leitura de N e Laço de Controle**

Primeiro, lemos `N` para definir o número de repetições. O laço `for` gerencia a execução de cada caso de teste.

```csharp
int i, n;
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    // A lógica de divisão entra aqui
    // ...
}
```

**2. Leitura, Cálculo e Verificação (Dentro do Laço)**

Dentro do laço, lemos a linha, convertemos os números para `double` e calculamos a divisão.

Note que em C\#, dividir um `double` por zero não gera um erro, mas sim um valor especial (`Infinity`). O `if` subsequente é o que nos protege de imprimir esse valor, tratando-o como "divisao impossivel".

```csharp
// (Código dentro do laço for)

string[] input = Console.ReadLine().Split(' ');
double x = double.Parse(input[0]);
double y = double.Parse(input[1]);
double div = x / y; // Calcula a divisão (ou 'Infinity' se y=0)

// 3. Verifica o DIVISOR (y)
if (y == 0)
{
    // Se y for 0, imprime a mensagem de erro
    Console.WriteLine("divisao impossivel");
} 
else
{
    // Se y for válido, imprime o resultado formatado
    Console.WriteLine($"{div:F1}");
}
```