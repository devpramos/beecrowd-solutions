# Problema 1080 - Maior e Posição

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1080)**

## 🧠 Minha Lógica

O desafio aqui é ler 100 valores inteiros distintos e, ao final, reportar duas coisas: qual foi o **maior valor** lido e em qual **posição** (de 1 a 100) ele foi lido.

Para resolver isso, precisei de duas variáveis "rastreadoras" que foram declaradas **antes** do laço `for` começar:
1.  `maior`: Para guardar o maior valor encontrado *até o momento*.
2.  `posicao`: Para guardar a posição onde esse maior valor foi encontrado.

A cada iteração do laço, o novo número lido (`n`) é comparado com o valor armazenado em `maior`. Se o novo número for maior, as duas variáveis (`maior` e `posicao`) são atualizadas com os novos valores.

### Análise do Problema

O fluxo de trabalho é baseado em um laço de 100 iterações com uma lógica de "substituição" contínua.

**1. Entrada de Dados**
* O programa deve ler 100 números inteiros, um por linha.

**2. Processamento**
* **Inicialização (Ponto-Chave):**
    * `int maior` é inicializado com `int.MinValue`. Esta é uma técnica robusta que armazena o menor valor possível para um inteiro. Isso garante que o *primeiro número lido* (`n`) será, por definição, maior que `maior`, e o sistema funcionará corretamente.
    * `int posicao` é inicializada com `0`.
* **Laço:**
    * Um laço `for` é criado para executar 100 vezes.
    * Foi crucial que o contador `i` fosse de **1 até 100** (`for (int i = 1; i <= 100; i++)`). O problema pede a posição em base 1 (posição 1, 2, 3...), não em base 0. Ao começar `i` em 1, a própria variável `i` já representa a posição correta.
* **Verificação (Dentro do laço):**
    * A cada iteração, um novo `int n` é lido.
    * A condição `if (maior < n)` verifica se o novo número é maior que o maior registrado até agora.
    * Se for, as duas variáveis são atualizadas: `maior = n;` e `posicao = i;`.

**3. Saída**
* Após o laço terminar (depois de ler os 100 números), o programa imprime o valor final de `maior`.
* Na linha seguinte, imprime o valor final de `posicao`.

## A Lógica de Implementação

A solução foi implementada em três partes: inicialização, o laço de verificação e a saída.

**1. Inicialização das Variáveis Rastreadoras**

Antes do laço, declaramos as duas variáveis que armazenarão o resultado. `maior` começa com o menor valor possível para garantir que o primeiro `n` lido o substitua.

```csharp
int maior = int.MinValue;
int posicao = 0;
```

**2. Laço de Leitura e Verificação**

O laço `for` é configurado para rodar 100 vezes, com `i` servindo como o número da "posição" (1-100). Dentro dele, lemos `n` e o comparamos com `maior`. Se `n` for o novo maior, atualizamos `maior` e `posicao` simultaneamente.

```csharp
// O laço vai de i = 1 até i = 100
for (int i = 1; i <= 100; i++)
{
    int n = int.Parse(Console.ReadLine());
    
    // Se o novo número 'n' for maior que o 'maior' atual...
    if (maior < n) {
        // ...atualizamos 'maior' para ser esse novo número
        maior = n;
        // ...e gravamos a posição 'i' onde ele foi encontrado
        posicao = i;
    }
}
```

**3. Exibição dos Resultados**

Após o laço terminar, as variáveis `maior` e `posicao` contêm os valores finais corretos, que são então impressos.

```csharp
Console.WriteLine(maior);
Console.WriteLine(posicao);
```