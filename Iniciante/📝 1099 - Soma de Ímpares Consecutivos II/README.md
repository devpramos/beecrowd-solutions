# Problema 1099 - Soma de Ímpares Consecutivos II

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1099)**

## 🧠 Minha Lógica

Este problema é, essencialmente, uma versão em "lote" do problema 1071. O programa primeiro lê um número `N` que indica quantos casos de teste serão executados.

Para cada caso de teste, o programa deve ler dois valores, `X` e `Y`, e calcular a soma de todos os números ímpares que estão **estritamente entre** eles.

A solução é estruturada com dois laços `for` aninhados:
1.  **Laço Externo:** Controlado por `N`, repete todo o processo de leitura e cálculo para cada caso de teste.
2.  **Laço Interno:** Executado dentro do laço externo, é responsável por percorrer o intervalo entre `X` e `Y` e somar os ímpares.

É crucial que a variável `soma` seja inicializada com `0` **dentro** do laço externo, para que ela seja zerada a cada novo caso de teste.

### Análise do Problema

O fluxo de trabalho para cada caso de teste é idêntico ao do problema 1071.

**1. Entrada de Dados**
* A primeira linha contém um inteiro `N` (o número de casos de teste).
* As `N` linhas seguintes contêm, cada uma, dois inteiros `X` e `Y`.

**2. Processamento (Dentro do laço N)**
* A cada iteração do laço externo:
    1.  A linha é lida e dividida (`Split(' ')`) para obter `X` e `Y`.
    2.  `int soma = 0;` é declarado para zerar a soma do caso atual.
    3.  **Ordenação:** É fundamental garantir que `X` seja o menor valor e `Y` o maior. Um bloco `if (x > y)` é usado para "trocar" os valores, garantindo que o laço de soma funcione corretamente, independentemente da ordem de entrada.
    4.  **Laço Interno (Soma):** Um laço `for (int j = ...)` é iniciado em `x + 1` (para não incluir `x`) e continua enquanto `j < y` (para não incluir `y`).
    5.  **Filtragem:** Dentro do laço interno, `if (j % 2 != 0)` filtra apenas os números ímpares.
    6.  A `soma` é acumulada.

**3. Saída**
* Ao final de *cada* iteração do laço externo (após o laço interno terminar), o valor da `soma` para aquele caso de teste é impresso.

## A Lógica de Implementação

A solução é implementada com laços aninhados.

**1. Laço de Controle de Testes (Externo)**

Primeiro, lemos `N`. O laço `for` externo é o que gerencia a repetição de todo o processo `N` vezes.

```csharp
int n = int.Parse(Console.ReadLine());
    
// Laço externo: repete N vezes
for (int i = 0; i < n; i++)
{
    // A lógica de cada caso de teste entra aqui
    // ...
}
```

**2. Leitura, Ordenação e Inicialização da Soma (Dentro do Laço Externo)**

No início de cada caso de teste, lemos a linha e os valores `x` e `y`. A variável `soma` é zerada. O bloco `if` garante que `x` seja sempre o menor e `y` o maior.

```csharp
// (Código dentro do laço externo)

string[] entrada = Console.ReadLine().Split(' ');
int x = int.Parse(entrada[0]);
int y = int.Parse(entrada[1]);

// Reseta a soma para este caso de teste
int soma = 0; 

// Bloco para garantir que X é o menor e Y é o maior
if (x > y)
{
    // Reatribui os valores com base na entrada original
    y = int.Parse(entrada[0]); 
    x = int.Parse(entrada[1]);
}
```

**3. Laço de Soma (Interno) e Saída**

Com `x` e `y` ordenados, o laço interno (`j`) percorre o intervalo exclusivo. A condição `if` filtra os ímpares. Após o laço interno, o resultado da `soma` daquele caso de teste é impresso.

```csharp
// (Continuação, dentro do laço externo)

// Laço interno: vai de X+1 até Y-1
for (int j = x+1; j < y; j++)
{
    if (j % 2 != 0)
    {
        soma += j;
    }
}

// Imprime o resultado deste caso de teste
Console.WriteLine(soma);
```