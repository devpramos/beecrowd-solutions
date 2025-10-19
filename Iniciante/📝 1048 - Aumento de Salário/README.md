# Problema 1048 - Aumento de Salário

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1048)**

## 🧠 Minha Lógica

Este foi um desafio de lógica condicional direta, que exigiu apenas uma entrada simples (`Console.ReadLine`) para receber o salário do funcionário. A solução foi construída utilizando uma estrutura `if / else if / else` para tratar cada uma das faixas salariais especificadas no enunciado.

### 1. Declaração das Variáveis

Para começar, declarei três variáveis do tipo `double` que seriam essenciais para os cálculos:

- `salarioAtual`: Armazena o valor que o usuário insere no console.
- `salarioNovo`: Guardará o valor do salário após a aplicação do reajuste.
- `reajuste`: Guardará o valor monetário do aumento recebido.

### 2. Estrutura Condicional

A lógica principal foi baseada nas seguintes faixas salariais e seus respectivos percentuais de reajuste:

| Salário Atual         | Percentual de Reajuste |
| :-------------------- | :--------------------- |
| 0 - 400.00            | 15%                    |
| 400.01 - 800.00       | 12%                    |
| 800.01 - 1200.00      | 10%                    |
| 1200.01 - 2000.00     | 7%                     |
| Acima de 2000.00      | 4%                     |

Dentro de cada bloco condicional (`if` ou `else if`), a lógica para calcular e exibir os valores foi a mesma:

1.  **Calcular o valor do reajuste:**
    `reajuste = salarioAtual * percentual;`
    *(Exemplo para 15%: `reajuste = salarioAtual * 0.15;`)*

2.  **Calcular o novo salário:**
    `salarioNovo = reajuste + salarioAtual;`

3.  **Exibir os resultados** no formato exigido, com duas casas decimais:
    ```csharp
    Console.WriteLine($"Novo salario: {salarioNovo:f2}");
    Console.WriteLine($"Reajuste ganho: {reajuste:f2}");
    Console.WriteLine($"Em percentual: (percentual) %");
    ```

Para o último caso (salários acima de 2000.00), utilizei um `else`, pois todos os cenários anteriores já haviam sido cobertos pelas outras condições, fazendo do `else` a opção lógica para tratar todos os valores restantes.