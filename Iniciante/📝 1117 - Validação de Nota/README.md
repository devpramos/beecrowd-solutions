# Problema 1117 - Validação de Nota

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1117)**

## 🧠 Minha Lógica

O objetivo deste problema é ler notas digitadas pelo usuário até que **duas notas válidas** sejam registradas. Uma nota é considerada válida se estiver no intervalo de 0 a 10, inclusive. Qualquer nota fora desse intervalo deve ser ignorada, e a mensagem "nota invalida" deve ser exibida.

A melhor estrutura para este cenário é um laço `while`. O laço não é controlado por um número fixo de iterações (como um `for`), mas sim por uma **condição**: ele deve continuar rodando *enquanto* a contagem de notas válidas for diferente de 2.

Para isso, usei duas variáveis "acumuladoras" declaradas fora do laço:
1.  `contValidas = 0`: Um contador para rastrear quantas notas válidas já encontramos.
2.  `somaNotas = 0`: Um acumulador para somar apenas as notas que foram validadas.

### Análise do Problema

O fluxo da solução é um ciclo de filtragem:

**1. Entrada de Dados**
* O programa deve ler múltiplos valores `double`, um por linha.

**2. Processamento (Dentro do `while`)**
* O laço `while (contValidas != 2)` atua como um "gatekeeper" (porteiro).
* **A cada iteração:**
    1.  O programa lê uma `nota`.
    2.  Um `if (nota >= 0 && nota <= 10)` verifica se a nota está no intervalo `[0, 10]`.
    3.  **Se for VÁLIDA:**
        * `somaNotas += nota` (adiciona a nota à soma).
        * `contValidas++` (incrementa o contador de validadas).
    4.  **Se for INVÁLIDA (`else`):**
        * O programa imprime "nota invalida".
* O laço só irá parar quando `contValidas` chegar a 2.

**3. Saída**
* "nota invalida" é impresso para cada tentativa falha.
* Quando o laço termina (exatamente 2 notas válidas foram lidas), o programa calcula a média (`somaNotas / contValidas` - que é `somaNotas / 2`) e a imprime no formato "media = [valor]".

## A Lógica de Implementação

A solução é implementada em três partes: a inicialização, o laço `while` de filtragem e o cálculo final.

**1. Inicialização dos Acumuladores**

Antes do laço, declaramos as duas variáveis que armazenarão o estado do nosso progresso.

```csharp
int contValidas = 0;
double somaNotas = 0;
```

**2. O Laço `while` de Validação**

Este laço é o núcleo da solução. Ele continuará pedindo notas ao usuário até que `contValidas` chegue a 2. A lógica `if/else` interna filtra as notas.

```csharp
// O laço roda ENQUANTO o contador for diferente de 2
while (contValidas != 2)
{
    double nota = double.Parse(Console.ReadLine());

    // 1. A nota é válida?
    if (nota >= 0 && nota <= 10)
    {
        // 1a. Sim: acumula a nota e incrementa o contador
        somaNotas += nota;
        contValidas++;
    }
    else
    {
        // 1b. Não: imprime o erro
        Console.WriteLine("nota invalida");
    }
}
```

**3. Exibição do Resultado (Cálculo da Média)**

Este código só é alcançado *depois* que o laço `while` termina. Neste ponto, temos a garantia de que `contValidas` é 2 e `somaNotas` contém a soma das duas notas válidas.

```csharp
// Calcula e imprime a média (somaNotas / 2)
Console.WriteLine($"media = {somaNotas / contValidas}");
```