using System; 

class URI {

    static void Main(string[] args) { 

        int maior = int.MinValue;
        int posicao = 0;
        for (int i = 1; i <= 100; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (maior < n) {
                maior = n;
                posicao = i;
            }
        }

        Console.WriteLine(maior);
        Console.WriteLine(posicao);

    }

}