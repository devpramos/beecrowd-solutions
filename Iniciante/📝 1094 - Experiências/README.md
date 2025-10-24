# Problema 1094 - Experiências

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1094)**

## 🧠 Minha Lógica

Este é um problema de processamento e agregação de dados. O objetivo é ler uma série de experimentos, registrar a quantidade e o tipo de cobaia (Coelho, Rato ou Sapo), e no final, apresentar um relatório completo.

Assim como em outros desafios, o primeiro número lido, `N`, é um "controlador" que define quantas linhas de dados (experimentos) o programa deve ler.

Para resolver, iniciei **quatro** contadores com valor `0` antes do laço:
1.  `contCoelhos`: Para somar apenas as quantidades de coelhos.
2.  `contRatos`: Para somar apenas as quantidades de ratos.
3.  `contSapos`: Para somar apenas as quantidades de sapos.
4.  `contCobaias`: Para somar o total geral de cobaias, independentemente do tipo.

Dentro do laço `for` (que executa `N` vezes), o programa lê a linha (ex: "10 C"), a divide (`Split(' ')`) para separar a `quantidade` do `tipo`.

A estrutura `switch-case` é usada para classificar o `tipo` ("C", "R" ou "S") e adicionar a `quantidade` ao contador específico do animal.

**Ponto-chave:** Em cada iteração, *independentemente do tipo*, a `quantidade` também é somada ao contador geral `contCobaias`.

Após o laço, o programa imprime os totais. Em seguida, calcula os percentuais usando a fórmula: `(total_do_tipo / total_geral) * 100`. Para garantir que a divisão seja de ponto flutuante (e não inteira, que resultaria em zero), fiz um *cast* para `(double)` em um dos valores. A formatação `:F2` garante a saída com duas casas decimais.

### Análise do Problema

O fluxo de trabalho é dividido em coleta de dados, processamento e relatório.

**1. Entrada de Dados**
* A primeira linha contém um inteiro `N` (a quantidade de experimentos).
* As `N` linhas seguintes contêm uma `quantidade` (int) e um `tipo` (char/string), separados por espaço.

**2. Processamento**
* **Fora do laço:** Inicializar os 4 contadores (`contCobaias`, `contCoelhos`, `contRatos`, `contSapos`) com `0`.
* **Dentro do laço (executa N vezes):**
    1.  Ler a linha e usar `.Split(' ')` para obter um vetor `entrada`.
    2.  Converter `entrada[0]` para `int quantidade`.
    3.  Pegar `entrada[1]` como `string tipo`.
    4.  Usar `switch (tipo)` para somar a `quantidade` ao contador do animal correto.
    5.  Adicionar a `quantidade` ao contador `contCobaias`.
* **Após o laço:**
    1.  Calcular os três percentuais (Coelhos, Ratos, Sapos) dividindo o total de cada um pelo `contCobaias` e multiplicando por 100.

**3. Saída**
* Imprimir os totais absolutos (Total de cobaias, coelhos, ratos, sapos).
* Imprimir os três percentuais formatados com duas casas decimais e o símbolo `%`.

## A Lógica de Implementação

A solução foi implementada em três partes: inicialização, o laço de agregação e a exibição do relatório.

**1. Leitura de N e Inicialização dos Contadores**

Primeiro, lemos o controlador `N` e zeramos os quatro contadores que acumularão os dados.

```csharp
int n = int.Parse(Console.ReadLine());
int contCobaias = 0;
int contCoelhos = 0;
int contRatos = 0;
int contSapos = 0;
```

**2. Laço de Leitura e Classificação**

O laço `for` executa `N` vezes. A cada ciclo, ele lê a linha, divide os dados, e o `switch` direciona a `quantidade` para o contador correto. A variável `contCobaias` é incrementada em todas as iterações.

```csharp
for (int i = 1; i <= n; i++)
{
    string[] entrada = Console.ReadLine().Split(' ');
    int quantidade = int.Parse(entrada[0]);
    string tipo = entrada[1].ToUpper(); // .ToUpper() é uma boa prática
    
    switch (tipo)
    {
        case "C":
            contCoelhos += quantidade;
            break;
        case "S":
            contSapos += quantidade;
            break;
        case "R":
            contRatos += quantidade;
            break;
    }
    // Adiciona ao total geral, independente do tipo
    contCobaias += quantidade;
}
```

**3. Exibição do Relatório (Totais e Percentuais)**

Após o laço, o programa imprime os totais. Em seguida, calcula e imprime os percentuais. Note o `(double)` para forçar a divisão decimal e o `:F2` para formatar a saída.

```csharp
Console.WriteLine($"Total: {contCobaias} cobaias");
Console.WriteLine($"Total de coelhos: {contCoelhos}");
Console.WriteLine($"Total de ratos: {contRatos}");
Console.WriteLine($"Total de sapos: {contSapos}");

// (double) é essencial para a divisão correta
// :F2 formata para 2 casas decimais
Console.WriteLine($"Percentual de coelhos: {(double) contCoelhos/contCobaias * 100:F2} %");
Console.WriteLine($"Percentual de ratos: {(double) contRatos/contCobaias * 100:F2} %");
Console.WriteLine($"Percentual de sapos: {(double) contSapos/contCobaias * 100:F2} %");
```