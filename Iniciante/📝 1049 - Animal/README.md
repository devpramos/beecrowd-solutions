# Problema 1049 - Animal

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1049)**

## 🧠 Minha Lógica

A solução para este problema foi baseada na árvore de decisão fornecida no enunciado. O desafio consistia em ler três características de um animal e, com base na combinação delas, identificar qual animal específico ele é.

### 1. Leitura das Características

Para armazenar as entradas do usuário, declarei três variáveis do tipo `string`:

-   `classeBiologica`: Recebe a primeira palavra (ex: "vertebrado" ou "invertebrado").
-   `classeAnimal`: Recebe a segunda palavra (ex: "ave", "mamifero").
-   `tipoAlimentacao`: Recebe a terceira palavra (ex: "carnivoro", "herbivoro").

Cada variável recebeu seu valor a partir de uma linha de entrada separada no console.

### 2. Fluxo Condicional

![Fluxo](https://i.imgur.com/mh14Yam.png)

Após receber as três características, a minha abordagem foi usar uma estrutura de `if / else if` para testar cada combinação completa da árvore de decisão de uma só vez.

Em vez de aninhar as condições, juntei as três verificações em uma única linha usando o **operador lógico `&&` (E)**. Dessa forma, uma condição só é verdadeira se **todas** as três palavras corresponderem a um caminho específico da árvore.

A estrutura do código ficou assim:

```csharp
if (classeBiologica == "vertebrado" && classeAnimal == "ave" && tipoAlimentacao == "carnivoro")
{
    Console.WriteLine("aguia");
}
else if (classeBiologica == "vertebrado" && classeAnimal == "ave" && tipoAlimentacao == "onivoro")
{
    Console.WriteLine("pomba");
}
// ... e assim por diante para todas as outras combinações.