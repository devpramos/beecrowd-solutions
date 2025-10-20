# Problema 1071 - Soma de Impares Consecutivos I

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1071)**

## 🧠 Minha Lógica

Este exercício tende a nos enganar se não analisarmos o enunciado e os exemplos de saída com atenção. Uma primeira tentativa de solução pode facilmente levar a um resultado incorreto.

### Análise e "Pegadinhas" do Problema

Ao testar com a entrada `6` e `-5`, cuja saída esperada é `5`, percebi dois pontos cruciais:

**1. O Intervalo da Soma é Exclusivo**

Uma abordagem inicial e "lógica" seria criar um laço que vai de X até Y, somando os ímpares.

```csharp
// Abordagem inicial incorreta
for (int i = x; i < y; i++)
{
    if (i % 2 != 0) {
        soma += i;
    }
}
```

No entanto, para a entrada 6 e -5 (ordenando para -5 e 6), a sequência de ímpares a ser somada é -3, -1, 1, 3, 5, cujo resultado é 5. Note que o -5 não entra na soma. Isso nos mostra que o laço deve considerar apenas os números entre X e Y. A correção é simples: o laço deve começar em x + 1.

**2. A Ordem de Entrada Não Importa**

O laço for precisa percorrer do menor para o maior número para que a soma funcione logicamente. Se a entrada for 6 e -5, o x inicial é maior que o y, e um laço for (int i = 6; i < -5; i++) nunca seria executado.

Portanto, é necessário "blindar" o código contra isso, garantindo que, antes do laço, a variável x sempre contenha o menor valor e y o maior.

## A Lógica de Implementação

Com base nessas observações, a solução foi implementada em dois passos principais:

**1. Ordenar as Entradas**

Para garantir que nosso for sempre funcione, criei uma condição inicial que verifica se x é maior que y. Se for, os valores são trocados de lugar usando uma variável temporária (temp).

```csharp
if (x > y)
{
    int temp = x; // Salva o valor original de x
    x = y;        // x recebe o valor menor
    y = temp;       // y recebe o valor maior
}
```

**2. Calcular a Soma**

Com x e y devidamente ordenados, o laço for é executado para calcular a soma dos ímpares.

O laço inicia em x + 1 para não incluir o primeiro valor no cálculo.

A condição de parada é i < y para não incluir o último valor.

Dentro do laço, uma condição if (i % 2 != 0) verifica se o número é ímpar antes de adicioná-lo à variável soma.