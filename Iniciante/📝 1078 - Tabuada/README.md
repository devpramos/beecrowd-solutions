# Problema 1078 - Tabuada

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1078)**

## 🧠 Minha Lógica

O objetivo deste problema é muito direto: ler um número inteiro `N` e imprimir a sua tabuada completa, do 1 ao 10.

A solução mais eficiente é primeiro ler o valor `N` e validá-lo. Utilizei uma instrução `if` como uma "condição de guarda" para verificar se `N` atende às restrições do problema (`2 < n && n < 1000`).

Somente se `N` for válido, o programa entra em um laço `for`. O laço é configurado para iterar 10 vezes (com um contador `i` de 1 a 10) e, a cada iteração, imprimir a linha correspondente da tabuada.

### Análise do Problema

O fluxo da solução é baseado em validação e repetição:

**1. Entrada de Dados**
* O programa lê um único número inteiro `N`.

**2. Processamento**
* **Validação:** Uma condição `if` principal verifica se `N` está estritamente entre 2 e 1000.
* **Se a condição for válida:**
    1.  Um laço `for` é iniciado com um contador `i` começando em 1 e indo até 10.
    2.  A cada iteração, o programa calcula o produto de `i * N`.
    3.  O resultado é impresso no formato "i x N = resultado".

**3. Saída**
* A tabuada completa (10 linhas) só é impressa se `N` passar na verificação inicial. Caso contrário, o programa não imprime nada e termina.

## A Lógica de Implementação

A solução é composta por uma condição de guarda e, dentro dela, um laço `for`.

**1. Leitura e Condição de Guarda**

Primeiro, o programa lê e armazena o valor `N`. Em seguida, o `if` verifica se `N` está no intervalo permitido. Esta é a forma mais eficiente, pois evita executar o laço desnecessariamente.

```csharp
int n = int.Parse(Console.ReadLine());

// 1. O 'if' age como um "guarda"
if (2 < n && n < 1000)
{
    // 2. O laço 'for' só executa se N for válido
    // ...
}
```

**2. Laço de Repetição e Impressão (Dentro do `if`)**

Se `N` for válido, o laço `for` é iniciado para contar de 1 a 10. A `Console.WriteLine` usa a interpolação de string para formatar e imprimir o resultado do cálculo (`i * n`) em cada linha.

```csharp
// (Continuação, dentro do if principal)

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} x {n} = {i * n}");
}
```