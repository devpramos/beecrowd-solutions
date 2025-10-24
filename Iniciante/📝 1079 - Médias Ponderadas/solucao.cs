using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double valor1 = double.Parse(entrada[0]) * 2;
            double valor2 = double.Parse(entrada[1]) * 3;
            double valor3 = double.Parse(entrada[2]) * 5;
            double media = (valor1 + valor2 + valor3) / 10;
            Console.WriteLine($"{media:F1}");
        }

    }

}