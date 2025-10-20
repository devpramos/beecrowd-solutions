# Problema 2006 - Identificando o Chá

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/2006)**

## 🧠 Minha Lógica

Diferente de outros desafios que podem ter "pegadinhas", este problema é bastante direto. O objetivo é simples: ler o tipo correto de chá, ler os palpites de cinco competidores e, ao final, contar quantos deles acertaram.

A estratégia consiste em comparar cada palpite individualmente com a resposta correta e usar um contador para registrar o número de acertos.

### Análise do Problema

O fluxo de dados é claro e linear:

**1. Entrada de Dados**
* Uma linha para o tipo de chá correto (`t`), que é um número inteiro.
* Uma segunda linha contendo os cinco palpites dos competidores, separados por espaço. Estes serão lidos inicialmente como texto.

**2. Processamento**
* É preciso percorrer cada um dos cinco palpites.
* Para cada palpite, é necessário compará-lo com o tipo de chá correto.
* Uma variável (contador) deve ser incrementada a cada vez que um palpite for igual à resposta correta.

**3. Saída**
* O valor final do contador deve ser impresso na tela.

## A Lógica de Implementação

A solução foi implementada em três passos principais:

**1. Leitura das Entradas e Preparação das Variáveis**

Primeiro, lemos o tipo correto de chá e os palpites dos competidores. Como os palpites vêm na mesma linha, eles são lidos como um vetor (array) de strings. Em seguida, inicializamos um contador de acertos com o valor zero.

```csharp
int t = int.Parse(Console.ReadLine()); // Lê o tipo de chá correto
string[] entrada = Console.ReadLine().Split(' '); // Lê os palpites como um array de strings

int contCertos = 0; // Inicia o contador de acertos
```

**2. Iteração e Verificação dos Palpites**

A parte-chave da lógica está em percorrer o vetor de palpites. Para isso, utilizei um laço `for`. A cada volta do laço, o palpite (que está em formato de texto) é convertido para um número inteiro para que a comparação possa ser feita.

```csharp
for (int i = 0; i < entrada.Length; i++)
{
    // Converte o palpite da posição atual para inteiro
    int palpiteAtual = int.Parse(entrada[i]);

    // Compara o palpite com a resposta correta
    if (palpiteAtual == t)
    {
        contCertos++; // Se for igual, incrementa o contador
    }
}
```

**3. Exibição do Resultado Final**

Após o laço `for` ter percorrido todos os palpites e o contador ter sido atualizado, o único passo restante é imprimir o valor final armazenado na variável `contCertos`.

```csharp
Console.WriteLine(contCertos);
```