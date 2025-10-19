using System; 

class URI {

    static void Main(string[] args) {
        int calculo;
        string[] entrada = Console.ReadLine().Split(' ');
        int inicio = int.Parse(entrada[0]);
        int fim = int.Parse(entrada[1]);
        if (inicio < fim)
        {
            calculo = fim - inicio;
            Console.WriteLine($"O JOGO DUROU {calculo} HORA(S)");
        } else
        {
            calculo = 24 - (inicio - fim);
            Console.WriteLine($"O JOGO DUROU {calculo} HORA(S)");
        }

    }

}