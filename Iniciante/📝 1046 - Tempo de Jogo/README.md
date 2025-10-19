# Problema 1046 - Tempo de Jogo

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1046)**

## 🧠 Minha Lógica

### 1. Declaração e Leitura das Variáveis

- Primeiro, declarei a variável inteira `calculo`, que seria usada para armazenar o resultado final da duração do jogo.
- Em seguida, criei um vetor de strings `entrada` para receber os valores de início e fim, que são lidos na mesma linha e separados por espaço.
- Populei as variáveis `inicio` e `fim`, pegando os valores das posições `[0]` e `[1]` do vetor e convertendo-os para inteiros com `int.Parse`.

### 2. Lógica de Cálculo da Duração

Para descobrir o tempo de jogo, precisei analisar dois cenários possíveis:

#### Cenário 1: O jogo termina no mesmo dia (`inicio < fim`)

Se a hora de início for menor que a hora do fim, significa que o jogo não atravessou a meia-noite. Nesse caso, a lógica é uma simples subtração.

- **Cálculo:** `calculo = fim - inicio;`

#### Cenário 2: O jogo atravessa a meia-noite (`inicio >= fim`)

Se a hora de início for maior ou igual à hora de fim, significa que a partida terminou no dia seguinte. O cálculo aqui é um pouco diferente para levar em conta a "virada" do dia.

- **Cálculo:** `calculo = 24 - (inicio - fim);`

A lógica matemática para este caso é que, ao subtrair `inicio - fim` (ex: 16h - 2h = 14h), encontramos o tempo que *não foi jogado*. Subtraindo esse valor de 24 horas, encontramos a duração real do jogo. Por exemplo, de 16h de um dia até 2h do outro, temos uma duração de 10 horas (`24 - 14 = 10`).

Finalmente, o valor armazenado na variável `calculo` é impresso na tela.