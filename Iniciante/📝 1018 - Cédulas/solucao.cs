using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n);
        int nota100 = n / 100;
        int nota50 = (n - (nota100 * 100)) / 50;
        int nota20 = (n - (nota100 * 100 + nota50 * 50)) / 20;
        int nota10 = (n - (nota100 * 100 + nota50 * 50 + nota20 * 20)) / 10;
        int nota5 = (n - (nota100 * 100 + nota50 * 50 + nota20 * 20 + nota10 * 10)) / 5;
        int nota2 = (n - (nota100 * 100 + nota50 * 50 + nota20 * 20 + nota10 * 10 + nota5 * 5)) / 2;
        int nota1 = (n - (nota100 * 100 + nota50 * 50 + nota20 * 20 + nota10 * 10 + nota5 * 5 + nota2 * 2)) / 1;
        Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
        Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
        Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
        Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
        Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
        Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
        Console.WriteLine($"{nota1} nota(s) de R$ 1,00");
    }

}