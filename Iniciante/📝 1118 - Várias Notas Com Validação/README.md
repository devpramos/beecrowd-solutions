# Problema 1118 - Várias Notas Com Validação

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1118)**

## 🧠 Minha Lógica

Este problema é uma evolução direta do 1117 (Validação de Nota). A lógica de validação é a mesma (só aceitar notas entre 0 e 10), mas com uma nova funcionalidade: após calcular a média, o programa deve perguntar "novo calculo (1-sim 2-nao)" e repetir todo o processo se a resposta for 1, ou terminar se a resposta for 2.

A arquitetura do código é baseada em **laços aninhados**:
1.  **Um Laço Principal (`while (x != 2)`):** Este é o laço "jogar novamente". Ele envolve *todo* o processo (pedir nota1, pedir nota2, calcular média, perguntar de novo). Ele só para quando a variável `x` (a resposta do usuário) for `2`.
2.  **Três Laços Internos (`do-while`):** Dentro do laço principal, existem três laços `do-while` que atuam como "portões" de validação:
    * **Laço 1 (Nota 1):** Pede `nota1`. Se for inválida, imprime "nota invalida" e repete, sem avançar para `nota2`.
    * **Laço 2 (Nota 2):** Pede `nota2`. Se for inválida, imprime "nota invalida" e repete, sem avançar para o cálculo da média.
    * **Laço 3 (Novo Calculo):** Pede `x` (a resposta). Se for inválida (diferente de 1 e 2), repete a pergunta "novo calculo..." até receber uma resposta válida.

A variável `x` (definida no Laço 3) é então usada pelo Laço Principal para decidir se deve recomeçar tudo ou parar.

### Análise do Problema

O fluxo da solução é um grande ciclo controlado por `x`.

**1. Entrada de Dados**
* O programa lê uma sequência de números `double` (as notas) e `int` (os comandos).

**2. Processamento (Dentro do Laço Principal)**
* **Etapa 1 (Laço `do-while` 1):** O programa fica preso pedindo `nota1` até que uma nota válida (0 a 10) seja digitada.
* **Etapa 2 (Laço `do-while` 2):** Após `nota1` ser válida, o programa fica preso pedindo `nota2` até que ela também seja válida.
* **Etapa 3 (Cálculo):** Com as duas notas válidas, a `media` é calculada e impressa.
* **Etapa 4 (Laço `do-while` 3):** O programa fica preso pedindo a opção `x` até que o usuário digite `1` ou `2`.
* **Etapa 5 (Verificação do Laço Principal):** O laço `while (x != 2)` verifica o `x` obtido na Etapa 4.
    * Se `x == 1`, o laço repete, voltando à Etapa 1.
    * Se `x == 2`, a condição `(x != 2)` se torna falsa e o laço principal (e o programa) termina.

**3. Saída**
* "nota invalida" para notas fora do intervalo [0, 10].
* "media = [valor]" após duas notas válidas.
* "novo calculo (1-sim 2-nao)" após a média ser impressa.

## A Lógica de Implementação

A solução é implementada em três partes principais, com os laços `do-while` aninhados dentro do laço `while` principal.

**1. O Laço Principal (Controle de Execução)**

Declaramos `x = 0` no início para garantir que o laço `while (x != 2)` execute pelo menos uma vez. Este laço "envolve" todo o processo.

```csharp
double nota1, nota2, media;
int x = 0; // Inicia com 0 para garantir a primeira execução

// Laço principal: continua enquanto x for diferente de 2
while (x != 2)
{
    // ... Todos os outros laços entram aqui ...
}
```

**2. Laços de Validação de Nota (Dentro do `while`)**

Os dois primeiros `do-while` são os "portões" que validam `nota1` e `nota2`. O código só avança para o próximo laço quando a condição do atual for satisfeita.

```csharp
// (Código dentro do laço principal 'while')

// Laço 1: Valida nota1
do
{
    nota1 = double.Parse(Console.ReadLine());
    if (nota1 < 0 || nota1 > 10)
        Console.WriteLine("nota invalida");
} while (nota1 < 0 || nota1 > 10); // Repete se for inválida

// Laço 2: Valida nota2 (só executa após nota1 ser válida)
do
{
    nota2 = double.Parse(Console.ReadLine());
    if (nota2 < 0 || nota2 > 10)
        Console.WriteLine("nota invalida");
} while (nota2 < 0 || nota2 > 10); // Repete se for inválida

// Cálculo e Impressão (só executa após nota1 e nota2 serem válidas)
media = (nota1 + nota2) / 2;
Console.WriteLine($"media = {media:f2}");
```

**3. Laço de Validação "Novo Calculo"**

O terceiro `do-while` é o que atualiza a variável `x`, que controla o laço principal.

```csharp
// (Continuação, dentro do laço principal 'while')

// Laço 3: Valida a resposta do usuário
do
{
    Console.WriteLine($"novo calculo (1-sim 2-nao)");
    x = int.Parse(Console.ReadLine());
} while (x != 1 && x != 2); // Repete se x não for 1 NEM 2
```