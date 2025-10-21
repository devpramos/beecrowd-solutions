# Problema 1064 - Positivos e Média

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1064)**

## 🧠 Minha Lógica

Este problema é uma continuação direta do desafio 1060 (Números Positivos). Além de contar quantos valores são positivos, agora também precisamos calcular a **média** desses valores positivos.

A estratégia de leitura de dados é exatamente a mesma: para evitar a criação de 6 variáveis (`n1`, `n2`...), utilizei um laço `for` que se repete 6 vezes. A cada iteração, o programa lê um número e faz a verificação.

A diferença é que agora precisamos de **duas** variáveis "contadoras" fora do laço:
1.  Uma `int` para contar a **quantidade** de positivos.
2.  Uma `double` para **somar** os valores positivos.

### Análise do Problema

O fluxo de trabalho se expande um pouco para incluir o cálculo da média:

**1. Entrada de Dados**
* O programa deve ler 6 números do tipo `double`.

**2. Processamento**
* **Fora do laço:** Declarar `int contPositivos = 0;` (para contar) e `double somaPositivos = 0.0;` (para somar).
* **Dentro do laço:** Um `for` é configurado para repetir 6 vezes (`i = 0` até `i < 6`).
    * A cada iteração, o programa lê um `double num`.
    * Uma condição `if (num > 0)` verifica se o número é positivo.
    * Se for positivo, duas ações ocorrem:
        1. `contPositivos++;` (incrementa o contador de quantidade).
        2. `somaPositivos += num;` (adiciona o valor do número à soma total).
* **Após o laço:**
    * O cálculo da média é feito: `mediaPositivos = somaPositivos / contPositivos`.

**3. Saída**
* O programa imprime a contagem de positivos (ex: "4 valores positivos").
* Em seguida, imprime a média calculada, formatada com uma casa decimal.

## A Lógica de Implementação

A solução é construída em três etapas: inicialização, processamento em laço e cálculo final.

**1. Inicialização das Variáveis Acumuladoras**

Antes do laço, precisamos de duas variáveis para guardar os dados que coletaremos. Elas precisam, obrigatoriamente, estar fora do `for` para não serem zeradas a cada ciclo.

```csharp
int contPositivos = 0;           // Contador para a QUANTIDADE de positivos
double somaPositivos = 0.0;  // Acumulador para a SOMA dos positivos
```

**2. Leitura, Contagem e Soma (Dentro do Laço)**

O laço `for` controla a leitura dos 6 valores. A variável `num` é declarada dentro do laço para ser reaproveitada a cada iteração. O bloco `if` é o núcleo da lógica: ele filtra apenas os números positivos e atualiza nossos dois acumuladores.

```csharp
for (int i = 0; i < 6; i++)
{
    double num = double.Parse(Console.ReadLine());

    // Se o número for positivo...
    if (num > 0)
    {
        // ...incrementamos o contador de quantidade
        contPositivos++; 
        
        // ...e adicionamos o valor à soma total
        somaPositivos += num; 
    }
}
```

**3. Cálculo da Média e Exibição dos Resultados**

Após o término do laço, temos a quantidade exata de positivos (`contPositivos`) e a soma total deles (`somaPositivos`).

Primeiro, imprimimos a contagem. Em seguida, calculamos a média dividindo a soma pela quantidade. Por fim, imprimimos a média formatada com uma casa decimal (`{mediaPositivos:F1}`).

```csharp
// 1. Calcula a média (Soma / Quantidade)
double mediaPositivos = somaPositivos / contPositivos;

// 2. Imprime a contagem de positivos
Console.WriteLine($"{contPositivos} valores positivos");

// 3. Imprime a média formatada com 1 casa decimal
Console.WriteLine($"{mediaPositivos:F1}");
```