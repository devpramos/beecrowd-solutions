# Problema 1075 - Resto 2

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1075)**

## 🧠 Minha Lógica

O objetivo deste problema é ler um número inteiro `N` e, em seguida, encontrar e imprimir todos os números (no intervalo de 1 a 10000) que, quando divididos por `N`, deixam um resto exatamente igual a 2.

A solução é muito direta:
1.  Lemos o valor de `N`, que será nosso divisor.
2.  Criamos um laço `for` que "varre" o intervalo de números a serem testados. No meu código, fiz o laço percorrer de `i = 0` até `i < 10000`.
3.  Dentro do laço, a cada iteração, o programa usa o operador de módulo (`%`) para verificar a condição principal: `if (i % n == 2)`.

### Análise do Problema

O fluxo da solução é simples e não requer o armazenamento de dados, apenas a verificação e impressão imediata.

**1. Entrada de Dados**
* O programa lê um único valor inteiro `N`. Este `N` é o divisor.

**2. Processamento**
* Um laço `for` é iniciado. O contador `i` começa em `0` e o laço continua enquanto `i` for menor que 10000.
* A cada ciclo, o programa avalia a condição: "O resto da divisão do número atual (`i`) pelo divisor (`N`) é igual a 2?".
* Isso é traduzido para o código como: `if (i % n == 2)`.

**3. Saída**
* Se a condição for verdadeira, o valor de `i` (o número que produziu o resto 2) é impresso no console.
* Cada número é impresso em uma nova linha.

## A Lógica de Implementação

A solução inteira é composta pela leitura de `N` e um único laço `for` contendo um `if`.

**1. Leitura do Divisor (N)**

Primeiro, o programa lê e armazena o valor `N` que será usado como divisor em todas as verificações de resto.

```csharp
int n = int.Parse(Console.ReadLine());
```

**2. Laço de Verificação e Impressão**

Em seguida, o laço `for` percorre todos os números de 0 a 9999. O `if` interno filtra e imprime apenas aqueles que satisfazem a condição do problema (resto 2).

```csharp
// O laço percorre de i = 0 até i = 9999
for (int i = 0; i < 10000; i++)
{
    // Se o resto da divisão de 'i' por 'n' for 2...
    if (i % n == 2)
    {
        // ...então imprima o valor de 'i'
        Console.WriteLine(i);
    }
}
```