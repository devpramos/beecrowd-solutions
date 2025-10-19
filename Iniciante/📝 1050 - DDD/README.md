# Problema 1050 - DDD

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1050)**

## 🧠 Minha Lógica

A solução para este problema, que envolve associar um código DDD a um destino específico, foi implementada utilizando uma estrutura `switch case`. Esta abordagem se mostrou ideal para a natureza do desafio.

### Por que usar `switch` em vez de `if/else`?

Em vez de usar uma longa cadeia de `if / else if` para comparar o DDD de entrada com cada valor da tabela (`if (DDD == 61)`, `else if (DDD == 71)`, etc.), optei pela estrutura `switch case`.

O motivo principal foi a **clareza e a eficiência** do código. O `switch` é projetado exatamente para este cenário: comparar uma única variável contra múltiplos valores constantes. Isso resulta em um código mais limpo e sem a repetição desnecessária do operador `==`, evitando que o código ficasse cheio de informações redundantes.

### Implementação

A lógica foi bem direta:

1.  Li o código DDD inserido pelo usuário como um inteiro.
2.  Utilizei este valor como a expressão do `switch`.
3.  Para cada DDD válido da tabela, criei um `case` correspondente que imprime o nome da cidade.
4.  O comando `break;` foi usado ao final de cada `case` para interromper a execução e evitar que o código continuasse para o caso seguinte.
5.  Para os casos em que o DDD inserido não correspondia a nenhum dos valores da tabela, utilizei o bloco `default`, que foi responsável por imprimir a mensagem `DDD nao cadastrado`.

A estrutura básica ficou assim:

```csharp
switch (DDD)
{
    case 61:
        Console.WriteLine("Brasilia");
        break;

    case 71:
        Console.WriteLine("Salvador");
        break;
    
    // ... outros casos
    
    default:
        Console.WriteLine("DDD nao cadastrado");
        break;
}