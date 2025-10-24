# Problema 1079 - Médias Ponderadas

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1079)**

## 🧠 Minha Lógica

Este problema pede o cálculo de várias médias ponderadas. A lógica é semelhante a outros desafios (como o 1072 e 1074): a primeira linha lida (`N`) é um "controlador" que define quantas vezes o laço principal deve ser executado.

Dentro do laço, o programa lê uma linha que contém três valores de ponto flutuante (double) separados por espaço. O desafio informa os pesos de cada valor: 2, 3 e 5.

A fórmula para a média ponderada é:
$media = \frac{(valor1 \times peso1) + (valor2 \times peso2) + (valor3 \times peso3)}{soma\_dos\_pesos}$

Neste caso, a soma dos pesos é $2 + 3 + 5 = 10$.

Meu código implementa isso lendo a linha, separando-a em um vetor, e já multiplicando cada valor pelo seu respectivo peso no momento da conversão. Por fim, ele soma esses valores já ponderados e divide por 10.

### Análise do Problema

O fluxo de trabalho é baseado em um laço `for` que executa a lógica de cálculo `N` vezes.

**1. Entrada de Dados**
* A primeira linha contém um inteiro `N` (a quantidade de casos de teste).
* As `N` linhas seguintes contêm, cada uma, três valores `double` separados por espaço.

**2. Processamento (Dentro do laço)**
* A cada iteração:
    1.  O programa lê a linha inteira: `Console.ReadLine()`.
    2.  Separa a linha em um vetor de strings: `.Split(' ')`.
    3.  Pega o primeiro valor (`entrada[0]`), converte para `double` e já multiplica pelo peso 2.
    4.  Pega o segundo valor (`entrada[1]`), converte para `double` e multiplica pelo peso 3.
    5.  Pega o terceiro valor (`entrada[2]`), converte para `double` e multiplica pelo peso 5.
    6.  Soma os três resultados ponderados e divide pela soma total dos pesos (10) para obter a média.

**3. Saída**
* A média calculada é impressa no console.
* É crucial formatar a saída para ter exatamente **uma casa decimal** (`:F1`).

## A Lógica de Implementação

A solução é implementada em duas partes: o controle do laço e a lógica de cálculo interna.

**1. Leitura de N e Estrutura do Laço**

Primeiro, lemos o valor `N` que define o número de repetições. O laço `for` é então usado para controlar o fluxo, garantindo que o cálculo seja refeito para cada caso de teste.

```csharp
int n = int.Parse(Console.ReadLine());

// O laço executa N vezes
for (int i = 0; i < n; i++)
{
    // A lógica de cálculo e impressão entra aqui
    // ...
}
```

**2. Leitura, Cálculo e Impressão (Dentro do Laço)**

Este é o bloco que executa a cada iteração. Ele lê a linha, divide os valores, aplica os pesos (2, 3 e 5), calcula a média (dividindo por 10) e imprime o resultado formatado com uma casa decimal.

```csharp
// (Código dentro do laço for)

// 1. Lê a linha e divide em um vetor de strings
string[] entrada = Console.ReadLine().Split(' ');

// 2. Converte e aplica os pesos imediatamente
double valor1 = double.Parse(entrada[0]) * 2;
double valor2 = double.Parse(entrada[1]) * 3;
double valor3 = double.Parse(entrada[2]) * 5;

// 3. Soma os valores ponderados e divide pela soma dos pesos (10)
double media = (valor1 + valor2 + valor3) / 10;

// 4. Imprime com formatação de 1 casa decimal
Console.WriteLine($"{media:F1}");
```