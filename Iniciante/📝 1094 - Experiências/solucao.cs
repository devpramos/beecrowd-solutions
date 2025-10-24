using System; 

class URI {

    static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());
        int contCobaias = 0;
        int contCoelhos = 0;
        int contRatos = 0;
        int contSapos = 0;
        for (int i = 1; i <= n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int quantidade = int.Parse(entrada[0]);
            string tipo = entrada[1].ToUpper();
            switch (tipo)
            {
                case "C":
                    contCoelhos += quantidade;
                    break;
                case "S":
                    contSapos += quantidade;
                    break;
                case "R":
                    contRatos += quantidade;
                    break;
                default:
                    break;
            }
            contCobaias += quantidade;
        }

        Console.WriteLine($"Total: {contCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {contCoelhos}");
        Console.WriteLine($"Total de ratos: {contRatos}");
        Console.WriteLine($"Total de sapos: {contSapos}");
        Console.WriteLine($"Percentual de coelhos: {(double) contCoelhos/contCobaias * 100:F2} %");
        Console.WriteLine($"Percentual de ratos: {(double) contRatos/contCobaias * 100:F2} %");
        Console.WriteLine($"Percentual de sapos: {(double) contSapos/contCobaias * 100:F2} %");

    }

}