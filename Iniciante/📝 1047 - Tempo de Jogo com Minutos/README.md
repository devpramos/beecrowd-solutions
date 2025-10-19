# Problema 1047 - Tempo de Jogo com Minutos

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1047)**

## 🧠 Minha Lógica

Para evitar a complexidade de "emprestar" horas e minutos entre os cálculos, a minha abordagem foi converter todos os horários para uma única unidade: **minutos**. Isso simplifica enormemente a lógica.

### 1. Leitura e Conversão para Minutos

Primeiro, li os quatro valores (`horainicial`, `mininicial`, `horafim`, `minfim`) da entrada. Em seguida, para simplificar os cálculos, converti os horários de início e fim para um valor total em minutos:

- `tempo_total_inicial = (horainicial * 60) + mininicial;`
- `tempo_total_final = (horafim * 60) + minfim;`

### 2. Lógica de Cálculo da Duração

Com os totais em minutos, a lógica foi dividida em três cenários:

#### Cenário 1: O Jogo Termina no Mesmo Dia (`tempo_total_final > tempo_total_inicial`)
Se o tempo final em minutos é maior que o inicial, o jogo não atravessou a meia-noite. A duração total em minutos é uma simples subtração:
- `duracao = tempo_total_final - tempo_total_inicial;`

#### Cenário 2: O Jogo Atravessa a Meia-Noite (`tempo_total_final < tempo_total_inicial`)
Se o tempo final é menor que o inicial, significa que o jogo terminou no dia seguinte. O cálculo precisa considerar a "virada" do dia. A duração é calculada subtraindo a diferença de tempo do total de minutos em um dia (1440 minutos = 24 horas):
- `duracao = 1440 - (tempo_total_inicial - tempo_total_final);`

#### Cenário 3: Duração de Exatamente 24 Horas
Se nenhum dos casos acima for verdadeiro, significa que `tempo_total_inicial == tempo_total_final`. Conforme a regra do problema, isso indica uma duração exata de **24 horas e 0 minutos**.

### 3. Convertendo o Resultado Final

Após encontrar a `duracao` total em minutos em um dos cenários, converti esse valor de volta para o formato de horas e minutos para a exibição final:
- **Horas:** `calculo = duracao / 60;` (Divisão inteira para encontrar as horas)
- **Minutos:** `calculominutos = duracao % 60;` (Resto da divisão para encontrar os minutos)