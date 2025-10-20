# Problema 1060 - Números Positivos

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1060)**

## 🧠 Minha Lógica

O problema exige a leitura de 6 valores numéricos, que podem ser positivos ou negativos, e ao final, a contagem de quantos desses valores eram positivos.

Para evitar a criação desnecessária de seis variáveis diferentes (como `n1`, `n2`, `n3`, etc.), a abordagem mais inteligente é utilizar um laço de repetição `for`. O laço executará exatamente 6 vezes, uma para cada valor a ser lido. Dentro de cada repetição, o programa lerá um número e imediatamente verificará se ele é positivo, atualizando um contador.

### Análise do Problema

O fluxo de trabalho para esta solução é bem definido:

**1. Entrada de Dados**
* O programa deve estar preparado para ler 6 números. Estes podem ser inteiros ou de ponto flutuante (decimais). A leitura ocorrerá um por um.

**2. Processamento**
* Um contador, inicializado com zero, é necessário para armazenar a quantidade de números positivos. É crucial que este contador seja declarado **fora** do laço de repetição para que seu valor seja preservado entre as iterações.
* Um laço `for` é configurado para repetir 6 vezes.
* A cada iteração, o programa lê um novo número.
* Uma condição `if` verifica se o número lido é maior que 0.
* Se a condição for verdadeira, o contador é incrementado em 1.

**3. Saída**
* Após o término do laço, o programa deve imprimir o valor final do contador, seguido da mensagem " valores positivos".

## A Lógica de Implementação

A solução foi estruturada em torno de um contador e um laço `for`.

**1. Inicialização do Contador**

Antes de iniciar o processo de leitura, uma variável inteira para contar os números positivos é declarada e inicializada com `0`.

```csharp
int positivos = 0;
```

**2. Leitura e Verificação em Laço**

Um laço `for` é criado para controlar o fluxo de leitura, garantindo que exatamente 6 números sejam processados.

Dentro do laço, uma única variável do tipo `double`, chamada `n`, é declarada para receber o valor de entrada a cada iteração. Utilizar uma única variável que é reaproveitada a cada ciclo é uma prática eficiente que evita poluir o código.

Logo após a leitura, uma simples verificação `if (n > 0)` determina se o número é positivo. Em caso afirmativo, o contador `positivos` é incrementado.

```csharp
for (int i = 0; i < 6; i++)
{
    // A variável 'n' é declarada aqui dentro para ser reaproveitada a cada ciclo
    double n = double.Parse(Console.ReadLine());

    // Se o número lido for maior que zero...
    if (n > 0)
    {
        // ...incrementamos o contador.
        positivos++;
    }
}
```

**3. Exibição do Resultado Final**

Após a execução completa do laço, o valor final do contador é impresso no formato exigido pelo problema.

```csharp
Console.WriteLine($"{positivos} valores positivos");
```