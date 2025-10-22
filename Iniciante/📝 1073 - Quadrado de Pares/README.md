# Problema 1073 - Quadrado de Pares

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1073)**

## 🧠 Minha Lógica

O objetivo deste problema é ler um valor inteiro `N` e imprimir o quadrado de todos os números pares entre 1 e `N` (inclusive).

Minha implementação primeiro lê o valor de `N` e, em seguida, utiliza uma estrutura condicional `if` para verificar se `N` atende às restrições impostas pelo problema (`5 < n && n < 2000`). Toda a lógica de cálculo só é executada se o valor de `N` estiver dentro deste intervalo válido.

Dentro da lógica principal, um laço `for` percorre os números de 1 até `N`, um `if` filtra apenas os pares, e a função `Math.Pow()` é usada para calcular o quadrado.

### Análise do Problema

O fluxo da solução é baseado em validação e repetição:

**1. Entrada de Dados**
* O programa lê um único número inteiro `N`.

**2. Processamento**
* **Validação:** Uma condição `if` principal verifica se `N` está estritamente entre 5 e 2000.
* **Se a condição for válida:**
    1.  Uma variável `quadrado` do tipo `double` é declarada (para ser compatível com a saída de `Math.Pow()`).
    2.  Um laço `for` é iniciado com um contador `i` começando em `1` e indo até `N` (`i <= N`).
    3.  A cada iteração, um `if` interno verifica se `i` é par (`i % 2 == 0`).
    4.  Se for par, o quadrado de `i` é calculado usando `quadrado = Math.Pow(i, 2);`.

**3. Saída**
* Se `i` for par, o resultado é imediatamente impresso no formato "número^2 = resultado" (ex: "2^2 = 4"). A saída só ocorre para os números que passam por todos os filtros.

## A Lógica de Implementação

A solução foi implementada em duas etapas principais: uma condição de guarda e o laço de cálculo.

**1. Leitura e Condição de Guarda**

Primeiro, o programa lê o valor `N`. Em seguida, uma instrução `if` "envolve" todo o resto da lógica. O código que calcula os quadrados só será executado se `N` estiver no intervalo correto.

```csharp
int n = int.Parse(Console.ReadLine());

// Condiciona a execução de acordo com a restrição do problema
if (5 < n && n < 2000)
{
    // Apenas se N for válido, o código abaixo é executado
    // ...
}
```

**2. Laço, Verificação e Cálculo (Dentro do `if`)**

Dentro do bloco `if` principal, declaramos a variável `quadrado`. O laço `for` percorre todos os números de 1 até `N`. O `if` interno ao laço filtra apenas os números pares e, para estes, calcula e imprime o quadrado.

```csharp
// (Continuação, dentro do if principal)

double quadrado;

// O laço percorre de 1 até N
for (int i = 1; i <= n; i++)
{
    // 1. Verifica se 'i' é par
    if (i % 2 == 0)
    {
        // 2. Calcula o quadrado usando Math.Pow
        quadrado = Math.Pow(i, 2);
        
        // 3. Mostra o resultado formatado
        Console.WriteLine($"{i}^2 = {quadrado}");
    }
}
```