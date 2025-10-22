# Problema 1072 - Intervalo 2

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1072)**

## 🧠 Minha Lógica

Resolvi este problema dividindo-o em etapas claras. O primeiro valor lido, `N`, é crucial, pois ele não é um número a ser testado, mas sim o **controlador** que define quantas vezes nosso laço de verificação deve rodar.

O objetivo é ler `N` números e classificar cada um deles em duas categorias: "in" (se estiver no intervalo de 10 a 20, incluindo ambos) ou "out" (se estiver fora desse intervalo).

Para isso, iniciei duas variáveis contadoras, `contIn` e `contOut`, com valor 0. Elas são declaradas **fora** do laço para acumular o resultado de todas as verificações.

### Análise do Problema

O fluxo de trabalho da solução é o seguinte:

**1. Entrada de Dados**
* A primeira linha contém um número inteiro `N`, que indica a quantidade de casos de teste que virão.
* As próximas `N` linhas conterão, cada uma, um número inteiro `X` a ser testado.

**2. Processamento**
* As variáveis `contIn = 0` e `contOut = 0` são inicializadas.
* Um laço `for` é criado para executar exatamente `N` vezes (de `i = 0` até `i < N`).
* A cada iteração do laço:
    1. O programa lê o próximo número a ser testado, `X`.
    2. Uma condição `if` verifica se `X` está dentro do intervalo. A lógica é: `if (x >= 10 && x <= 20)`.
    3. Se for verdadeiro, `contIn` é incrementado (`contIn++`).
    4. Caso contrário (`else`), `contOut` é incrementado (`contOut++`).

**3. Saída**
* Após o laço `for` terminar de processar todos os `N` números, o programa imprime os valores finais dos contadores, formatados como "in" e "out".

## A Lógica de Implementação

A solução foi implementada em três partes principais:

**1. Leitura de N e Inicialização dos Contadores**

Primeiro, lemos o valor `N` para saber quantas vezes o laço deve repetir. Em seguida, preparamos os contadores de "dentro" e "fora" do intervalo.

```csharp
// Lê a quantidade de testes
int n = int.Parse(Console.ReadLine());

// Inicia os contadores
int contIn = 0;
int contOut = 0;
```

**2. Laço de Leitura e Verificação**

O laço `for` é o coração da solução. Ele garante que o programa pedirá ao usuário um número `X` pela quantidade exata de vezes definida por `N`. A cada leitura, a verificação é feita imediatamente.

```csharp
// O laço vai de 0 até N-1 (total de N repetições)
for (int i = 0; i < n; i++)
{
    // Lê o número a ser testado
    int x = int.Parse(Console.ReadLine());

    // Verifica se X está no intervalo [10, 20]
    if (x >= 10 && x <= 20)
    {
        contIn++; // Se sim, conta como "in"
    }
    else
    {
        contOut++; // Se não, conta como "out"
    }
}
```

**3. Exibição dos Resultados**

Fora do laço, após todas as verificações terem sido feitas, o programa exibe os totais acumulados nas variáveis `contIn` e `contOut`.

```csharp
Console.WriteLine($"{contIn} in");
Console.WriteLine($"{contOut} out");
```