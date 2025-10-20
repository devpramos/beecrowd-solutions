# Problema 1052 - Mês

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1052)**

## 🧠 Minha Lógica

Este é um problema de associação direta, onde um número de entrada deve corresponder a uma saída de texto específica. A tarefa é ler um número inteiro entre 1 e 12 e imprimir o nome do mês correspondente em inglês.

A estrutura mais limpa, legível e eficiente para resolver este tipo de problema, que envolve múltiplas verificações de um único valor, é a declaração `switch-case`. Ela evita o uso de uma longa cadeia de `if-else if`, tornando o código mais organizado.

### Análise do Problema

O fluxo para a solução é extremamente simples:

**1. Entrada de Dados**
* O programa recebe uma única linha contendo um número inteiro.

**2. Processamento**
* O valor deste número é verificado.
* Com base no número, o nome do mês correspondente é selecionado.

**3. Saída**
* O nome do mês, em inglês e com a primeira letra maiúscula, é impresso na tela, seguido por uma quebra de linha.

## A Lógica de Implementação

A implementação foi focada na simplicidade e eficiência, utilizando a estrutura de controle `switch`.

**1. Leitura da Entrada**

Primeiramente, o programa lê o número inteiro fornecido pelo usuário e o armazena em uma variável.

```csharp
int opcao = int.Parse(Console.ReadLine());
```

**2. Verificação com `switch-case`**

O coração da solução é a estrutura `switch`. A variável `opcao` é passada como a condição a ser avaliada. Para cada valor possível de 1 a 12, um `case` correspondente é criado para imprimir o nome do mês correto.

```csharp
switch (opcao)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("December");
        break;
}
```

Cada `case` executa a impressão e termina com um `break` para sair da estrutura `switch`, garantindo que apenas o código do caso correspondente seja executado.