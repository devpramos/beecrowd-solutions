# Problema 1097 - Sequencia IJ 3

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1097)**

## 🧠 Minha Lógica

Este problema é uma continuação direta do 1096 (Sequencia IJ 2). É um desafio de saída estática (sem entrada de dados).

A sequência-alvo segue um padrão similar, mas o valor inicial de `J` agora **aumenta** a cada novo ciclo de `I`:
* `I=1` -> `J=7, 6, 5`
* `I=3` -> `J=9, 8, 7`
* `I=5` -> `J=11, 10, 9`
* ...e assim por diante.

Para resolver isso, adaptei a lógica de "loop único" que usei no problema anterior. Mantive o `while` principal, mas precisei de uma nova variável (`contJ`) para "lembrar" quantos ciclos de `I` já se passaram, para então calcular o novo ponto de partida de `J`.

As variáveis de controle de estado são:
* `i`: Armazena o valor atual de I (começa em 1).
* `j`: Armazena o valor atual de J (começa em 7).
* `posI`: Um contador auxiliar para rastrear quantas vezes `J` foi impresso para o `I` atual (vai de 0 a 3).
* `contJ`: Um contador de "grupos". Ele conta quantos *grupos de `I`* já foram concluídos (começa em 0).

### Análise do Problema

O fluxo de trabalho do laço `while` é o seguinte:

**1. Entrada de Dados**
* Nenhuma entrada é necessária.

**2. Processamento (Dentro do Laço `while`)**
* O laço principal (`while (i <= 9)`) continua enquanto `I` não tiver chegado ao seu valor final.
* A cada iteração:
    1.  O programa imprime os valores atuais `I={i} J={j}`.
    2.  `j` é decrementado em 1 (ex: 7 -> 6 -> 5).
    3.  O contador auxiliar `posI` é incrementado (ex: 1 -> 2 -> 3).
    4.  **Verificação de "fim de ciclo I" (`if (posI == 3)`):**
        * `contJ++`: O contador de grupos é incrementado (agora `contJ = 1`, pois o grupo `I=1` terminou).
        * `posI = 0`: O contador auxiliar é zerado.
        * `i += 2`: O valor de `I` é avançado (ex: 1 -> 3).
        * `j = 7`: O `J` é resetado para seu valor base 7.
        * `j += 2 * contJ`: **Esta é a lógica-chave.** O `J` é ajustado para seu novo ponto de partida.
            * No primeiro reset (`contJ=1`), `j` vira `7 + (2 * 1) = 9`.
            * No segundo reset (`contJ=2`), `j` vira `7 + (2 * 2) = 11`.
            * E assim por diante, calculando perfeitamente o início do próximo `J`.

**3. Saída**
* A saída é gerada linha por linha dentro do laço `while`.

## A Lógica de Implementação

A solução é implementada em duas partes: a inicialização das variáveis de estado e o laço `while` que controla a lógica.

**1. Inicialização das Variáveis de Estado**

Antes do laço, definimos os valores iniciais para todas as nossas variáveis de controle.

```csharp
int i = 1;
int j = 7;
int posI = 0;
int contJ = 0;
```

**2. O Laço de Controle `while`**

Um único laço `while` gerencia todo o fluxo. A mágica acontece no bloco `if (posI == 3)`, que é responsável por avançar `I` e calcular o novo ponto de partida de `J` usando o `contJ`.

```csharp
while (i <= 9)
{
    // 1. Imprime o estado atual
    Console.Write($"I={i} ");
    Console.WriteLine($"J={j}");
    
    // 2. Atualiza o estado para a próxima linha
    j -= 1;
    posI++;
    
    // 3. Se já imprimimos 3x para o I atual...
    if (posI == 3)
    {
        // ...incrementa o contador de "grupos"
        contJ++;
        // ...zera o contador de impressões
        posI = 0;
        // ...avança o I
        i += 2;
        // ...reseta J para o valor base
        j = 7;
        // ...e calcula o novo ponto de partida de J
        j += 2 * contJ; 
    }
}
```