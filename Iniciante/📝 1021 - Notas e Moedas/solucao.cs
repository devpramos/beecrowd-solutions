using System; 

class URI {

    static void Main(string[] args) { 

        double n = double.Parse(Console.ReadLine());
        int nota100 = (int)n / 100;
        int nota50 = (int)(n - (nota100 * 100)) / 50;
        int nota20 = (int)(n - (nota100 * 100 + nota50 * 50)) / 20;
        int nota10 = (int)(n - (nota100 * 100 + nota50 * 50 + nota20 * 20)) / 10;
        int nota5 = (int)(n - (nota100 * 100 + nota50 * 50 + nota20 * 20 + nota10 * 10)) / 5;
        int nota2 = (int)(n - (nota100 * 100 + nota50 * 50 + nota20 * 20 + nota10 * 10 + nota5 * 5)) / 2;
        double restonotas = n - (nota100 * 100 + nota50 * 50 + nota20 * 20 + nota10 * 10 + nota5 * 5 + nota2 * 2);
        restonotas = Math.Round(restonotas * 100);
        int moeda1 = (int)restonotas / 100;
        restonotas %= 100; //
        int moeda50 = (int)restonotas / 50;
        restonotas %= 50;
        int moeda25 = (int)restonotas / 25;
        restonotas %= 25;
        int moeda10 = (int)restonotas / 10;
        restonotas %= 10;
        int moeda5 = (int)restonotas / 5;
        restonotas %= 5;
        int moeda01 = (int)restonotas / 1;

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
        Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
        Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
        Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
        Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
        Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
        Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
        Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
        Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
        Console.WriteLine($"{moeda5} moeda(s) de R$ 0.05");
        Console.WriteLine($"{moeda01} moeda(s) de R$ 0.01");
    }

}