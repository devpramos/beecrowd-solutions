# Problema 1065 - Pares entre Cinco Números

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1065)**

## 🧠 Minha Lógica

O objetivo deste desafio é ler 5 números inteiros, verificar quantos deles são pares e, por fim, exibir essa contagem.

Assim como em problemas anteriores (como o 1060), a abordagem mais limpa é usar um laço `for` para gerenciar a leitura dos 5 números, em vez de criar 5 variáveis distintas.

Para registrar a contagem, utilizei uma única variável "contadora" (`contPares`), que foi declarada **fora** do laço para não perder seu valor a cada iteração.

### Análise do Problema

O fluxo de trabalho é muito direto:

**1. Entrada de Dados**
* O programa deve ler 5 números inteiros, um por linha.

**2. Processamento**
* Uma variável `contPares` é inicializada com o valor `0`.
* Um laço `for` é configurado para executar exatamente 5 vezes (de `i = 0` até `i < 5`).
* A cada ciclo do laço:
    1. O programa lê um número inteiro (`num`).
    2. Uma condição `if` verifica se o número é par. A regra matemática para isso é checar se o resto da divisão por 2 é igual a 0 (`num % 2 == 0`).
    3. Se a condição for verdadeira, a variável `contPares` é incrementada (`contPares++`).
* O processo se repete até que os 5 números tenham sido lidos e verificados.

**3. Saída**
* Após o término do laço, o programa imprime o valor final de `contPares`, formatado com a mensagem " valores pares".

## A Lógica de Implementação

A solução é focada em um contador e um laço de repetição.

**1. Inicialização do Contador**

Antes de qualquer leitura, a variável que armazenará a contagem de pares é declarada e zerada.

```csharp
int contPares = 0;
```

**2. Leitura e Verificação (Dentro do Laço)**

Um laço `for` é usado para repetir o processo de leitura e verificação 5 vezes. A cada iteração, um número é lido e imediatamente testado pela condição de paridade.

```csharp
for (int i = 0; i < 5; i++)
{
    // Lê o número
    int num = int.Parse(Console.ReadLine());

    // Verifica se o resto da divisão por 2 é 0
    if (num % 2 == 0)
    {
        // Se for par, incrementa o contador
        contPares++;
    }
}
```

**3. Exibição do Resultado Final**

Quando o laço termina, a variável `contPares` contém o total de números pares encontrados. Basta imprimi-la no formato exigido.

```csharp
Console.WriteLine($"{contPares} valores pares");
```