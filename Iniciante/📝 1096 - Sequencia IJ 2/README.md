# Problema 1096 - Sequencia IJ 2

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1096)**

## 🧠 Minha Lógica

Este é um problema de saída estática, o que significa que não há entrada de dados; o programa deve sempre imprimir a mesma sequência de valores.

A sequência-alvo segue um padrão claro:
* `I` começa em 1 e é incrementado de 2 em 2 (1, 3, 5, 7, 9).
* Para **cada** valor de `I`, `J` deve percorrer a sequência 7, 6, 5.

Embora a solução mais comum use dois laços `for` aninhados (um para `I` e um para `J`), a minha implementação utiliza um **único laço `while`** para controlar todo o fluxo. Para fazer isso, precisei de variáveis manuais de controle de estado:
* `i`: Armazena o valor atual de I (começa em 1).
* `j`: Armazena o valor atual de J (começa em 7).
* `posI`: Um contador auxiliar para rastrear quantas vezes o `J` foi impresso para o `I` atual (vai de 0 a 3).

### Análise do Problema

O fluxo de trabalho do laço `while` é o seguinte:

**1. Entrada de Dados**
* Nenhuma entrada é necessária.

**2. Processamento (Dentro do Laço `while`)**
* O laço principal (`while (i <= 9)`) continua executando enquanto `I` não tiver chegado ao seu valor final.
* A cada iteração:
    1.  O programa imprime os valores atuais `I={i} J={j}`.
    2.  `j` é decrementado em 1 (ex: 7 -> 6).
    3.  O contador auxiliar `posI` é incrementado (ex: 0 -> 1).
    4.  **Primeira Verificação (Reset de `J`):** O código checa `if (j < 5)`. Se `j` chegar a 4 (após imprimir 7, 6, 5), ele é "resetado" para `7`, preparando-o para o próximo ciclo de `I`.
    5.  **Segunda Verificação (Avanço de `I`):** O código checa `if (posI == 3)`. Se o contador auxiliar indicar que 3 linhas já foram impressas para o `I` atual, ele zera o `posI` (para o próximo `I`) e avança `i` em 2 (ex: 1 -> 3).

**3. Saída**
* A saída é gerada linha por linha dentro do laço `while` até que `i` ultrapasse 9.

## A Lógica de Implementação

A solução é implementada em duas partes: a inicialização das variáveis de estado e o laço `while` que controla a lógica.

**1. Inicialização das Variáveis de Estado**

Antes do laço, definimos os valores iniciais para `i`, `j` e nosso contador auxiliar `posI`.

```csharp
int i = 1;
int j = 7;
int posI = 0;
```

**2. O Laço de Controle `while`**

Um único laço `while` é usado. Todo o controle de incremento de `i` e "reset" de `j` acontece manualmente dentro dele, através das duas estruturas `if`.

```csharp
while (i <= 9)
{
    // 1. Imprime o estado atual
    Console.Write($"I={i} ");
    Console.WriteLine($"J={j}");
    
    // 2. Atualiza o estado para a próxima linha
    j -= 1;
    posI++;
    
    // 3. Se J 'cair' do limite (foi para 4)...
    if (j < 5)
    {
        // ...reseta J para 7
        j = 7;
    }
    
    // 4. Se já imprimimos 3x para o I atual...
    if (posI == 3)
    {
        // ...zera o contador
        posI = 0;
        // ...e avança o I
        i += 2;
    }
}
```