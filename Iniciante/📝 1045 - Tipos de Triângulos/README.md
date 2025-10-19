# Problema 1045 - Tipos de Triângulos

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1045)**

## 🧠 Minha Lógica

### 1. Leitura e Preparação das Variáveis

Primeiro, eu declarei um vetor de strings `pontos` que receberia os três valores que o usuário inserir no console, lidos em uma única linha e separados por espaço.

Depois, declarei as variáveis `A`, `B` e `C` do tipo `double`. Conforme o enunciado, a variável `A` precisa ser sempre o maior valor. Para garantir isso, segui estes passos:
- Inicializei `A` com o menor valor possível (`double.MinValue`) para que qualquer número do vetor fosse maior que ele na primeira comparação.
- As variáveis `B` e `C` foram inicializadas com `0`.
- Criei também uma variável inteira `indiceVetor` para guardar a posição (o índice) do maior valor encontrado no vetor.

### 2. Encontrando o Maior Lado (A)

Criei um primeiro laço (`for`) com o objetivo específico de percorrer o vetor `pontos` e encontrar o maior valor para atribuir à variável `A`.
- Dentro do loop, precisei converter o valor de cada posição do vetor (que é string) para `double`.
- Criei uma condição (`if`) que verifica se o valor recém-convertido é maior que o valor atual de `A`.
- Se a condição for verdadeira, `A` recebe esse novo valor maior, e `indiceVetor` recebe o valor de `i` (a posição atual do loop).

Ao final deste laço, `A` já tem o maior dos três valores, e eu sei exatamente em qual posição do vetor ele estava.

### 3. Atribuindo os Lados B e C

Em seguida, um segundo laço (`for`) foi criado. A finalidade dele é atribuir os outros dois valores do vetor para as variáveis `B` e `C`.
- A condição principal aqui é verificar se o índice atual (`j`) é **diferente** do `indiceVetor`. Isso garante que não vamos pegar o valor que já está em `A`.
- Se o índice for diferente e `B` ainda não tiver nenhum valor (`B == 0`), `B` recebe o valor daquela posição do vetor.
- Se `B` já tiver um valor, `C` recebe o próximo valor disponível.

### 4. Verificações do Triângulo

Com os valores das variáveis `A`, `B` e `C` finalmente definidos, e com `A` sendo o maior lado, comecei as verificações para classificar o triângulo, seguindo exatamente a ordem pedida no enunciado:

- **Se** $A \ge B + C$, apresente a mensagem: `NAO FORMA TRIANGULO`
- **Se** $A^2 = B^2 + C^2$, apresente a mensagem: `TRIANGULO RETANGULO`
- **Se** $A^2 > B^2 + C^2$, apresente a mensagem: `TRIANGULO OBTUSANGULO`
- **Se** $A^2 < B^2 + C^2$, apresente a mensagem: `TRIANGULO ACUTANGULO`
- **Se** os três lados forem iguais, apresente a mensagem: `TRIANGULO EQUILATERO`
- **Se** apenas dois dos lados forem iguais, apresente a mensagem: `TRIANGULO ISOSCELES`