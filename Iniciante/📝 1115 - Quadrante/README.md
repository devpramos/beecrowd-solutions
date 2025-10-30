# Problema 1115 - Quadrante

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1115)**

## 🧠 Minha Lógica

Este problema exige a leitura contínua de pares de coordenadas (X, Y) e a identificação do quadrante ao qual cada ponto pertence. O programa só deve parar quando uma das coordenadas lidas for `0`.



[Image of Cartesian coordinate quadrants]


Assim como no problema 1114 (Senha Fixa), este é um cenário perfeito para um laço `do-while`. O programa precisa, obrigatoriamente, ler um par de coordenadas (X, Y) **antes** de poder verificar se deve parar ou não.

Dentro do laço, uma cadeia de `if-else if` é usada para classificar o ponto com base nos sinais de X e Y:
* **Primeiro:** X > 0, Y > 0
* **Segundo:** X < 0, Y > 0
* **Terceiro:** X < 0, Y < 0
* **Quarto:** X > 0, Y < 0

A condição de parada do problema é `X = 0` **ou** `Y = 0`. Portanto, a condição de *continuação* do laço `do-while` é o oposto: `X != 0` **e** `Y != 0`.

### Análise do Problema

O fluxo da solução é um ciclo de leitura e classificação.

**1. Entrada de Dados**
* O programa deve ler múltiplas linhas. Cada linha contém dois inteiros, `X` e `Y`, separados por espaço.

**2. Processamento (Dentro do laço)**
* **`do`:**
    1.  A linha é lida e dividida (`Split(' ')`) para obter `X` e `Y`.
    2.  Uma cadeia `if-else if` verifica as quatro combinações de sinais (positivo/negativo) para X e Y.
    3.  Apenas se o ponto estiver em um quadrante (ou seja, `X` e `Y` são diferentes de 0), o nome do quadrante correspondente é impresso.
* **`while` (Condição de Continuação):**
    * O laço repete **enquanto** `X` for diferente de 0 E `Y` for diferente de 0.

**3. Saída**
* "primeiro", "segundo", "terceiro" ou "quarto" é impresso para cada par de coordenadas lido.
* Quando a condição de parada é atingida (um dos valores é 0), o `if-else if` interno é ignorado (pois nenhuma condição bate), a saída não é impressa, e o laço `while` falha, terminando o programa.

## A Lógica de Implementação

A solução é implementada com as variáveis `x` e `y` declaradas fora do laço `do-while` para que possam ser usadas na condição `while` no final.

**1. Estrutura do Laço `do-while`**

As variáveis são declaradas, e o laço `do-while` é iniciado. A condição de continuação `(x != 0 && y != 0)` fica no final.

```csharp
int x, y; // Declaradas fora para serem acessíveis no 'while'
do
{
    // A lógica de leitura e classificação entra aqui
    // ...

} while (x != 0 && y != 0); // Continua enquanto ambos forem != 0
```

**2. Leitura e Classificação (Dentro do `do`)**

Dentro do laço, a linha é lida, os valores são extraídos, e a cadeia `if-else if` classifica e imprime o quadrante.

```csharp
// (Código dentro do bloco 'do')

// 1. Lê e divide a entrada
string[] entrada = Console.ReadLine().Split(' ');
x = int.Parse(entrada[0]);
y = int.Parse(entrada[1]);

// 2. Classifica o quadrante
if (y > 0 && x > 0)
{
    Console.WriteLine("primeiro");
}
else if (y > 0 && x < 0)
{
    Console.WriteLine("segundo");
}
else if (y < 0 && x < 0)
{
    Console.WriteLine("terceiro");
}
else if (y < 0 && x > 0)
{
    Console.WriteLine("quarto");
}

// Se x ou y for 0, nenhuma condição é atendida,
// nada é impresso, e o laço 'while' irá parar.
```