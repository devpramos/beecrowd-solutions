# Problema 1114 - Senha Fixa

**[Link para o problema no Beecrowd](https://www.beecrowd.com.br/judge/pt/problems/view/1114)**

## 🧠 Minha Lógica

O objetivo deste problema é simular uma tela de login. O programa deve ler tentativas de senha, uma após a outra, e para cada tentativa incorreta, deve imprimir "Senha Invalida". O processo só para quando a senha correta (2002) for digitada, momento em que o programa imprime "Acesso Permitido".

Este cenário é o caso de uso clássico para um laço `do-while`. A diferença-chave é:
* Um laço `while` normal verifica a condição **antes** de executar o bloco.
* Um laço `do-while` executa o bloco **primeiro** e só então verifica a condição.

Como o programa precisa ler uma senha *pelo menos uma vez* antes de poder checá-la, o `do-while` é a estrutura ideal, pois garante a primeira execução.

### Análise do Problema

O fluxo da solução é um ciclo de verificação contínua:

**1. Entrada de Dados**
* O programa deve ler múltiplos valores inteiros (tentativas de senha), um por linha.

**2. Processamento**
* Uma senha correta (`senhaCorreta = 2002`) é definida.
* O programa entra em um laço `do-while`.
* **Dentro do `do`:**
    1.  O programa lê a tentativa (`senha`).
    2.  Um `if` verifica se a tentativa está errada (`senha != senhaCorreta`).
    3.  Se estiver errada, imprime "Senha Invalida".
* **No `while` (Condição de Repetição):**
    * O laço continua repetindo **enquanto** a senha estiver errada (`while (senhaCorreta != senha)`).

**3. Saída**
* "Senha Invalida" é impresso para cada tentativa falha.
* Assim que o laço é quebrado (ou seja, a senha correta foi digitada), a linha final "Acesso Permitido" é impressa.

## A Lógica de Implementação

A solução é implementada em três partes: a inicialização, o laço `do-while` e a saída final.

**1. Inicialização das Variáveis**

Primeiro, definimos a senha que estamos procurando e declaramos a variável que receberá as tentativas do usuário.

```csharp
int senhaCorreta = 2002;
int senha;
```

**2. O Laço `do-while`**

Este é o núcleo da solução. O bloco `do` é executado, e a condição `while` no final decide se ele deve ser executado novamente.

```csharp
do
{
    // 1. Sempre lê a senha pelo menos uma vez
    senha = int.Parse(Console.ReadLine());
    
    // 2. Verifica se a senha está errada
    if (senha != senhaCorreta)
    {
        // 3. Se estiver errada, imprime a mensagem de erro
        Console.WriteLine("Senha Invalida");
    }
} 
// 4. Se a senha digitada for DIFERENTE da correta, volta ao 'do'
while (senhaCorreta != senha);
```

**3. Exibição do Resultado (Acesso Permitido)**

A única forma do programa escapar do laço `do-while` é quando a condição `(senhaCorreta != senha)` se torna `false`. Isso só acontece quando `senha` é **igual** a `senhaCorreta`.

Portanto, qualquer código escrito *após* o laço só será executado quando o acesso for bem-sucedido.

```csharp
Console.WriteLine("Acesso Permitido");
```