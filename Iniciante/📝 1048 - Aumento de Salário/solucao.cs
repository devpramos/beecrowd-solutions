using System; 

class URI {

    static void Main(string[] args) {

        double salarioAtual = double.Parse(Console.ReadLine());
        double salarioNovo, reajuste;
        if (salarioAtual >= 0 && salarioAtual <= 400.00)
        {
            reajuste = salarioAtual * 0.15;
            salarioNovo = reajuste + salarioAtual;
            Console.WriteLine($"Novo salario: {salarioNovo:f2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:f2}");
            Console.WriteLine($"Em percentual: 15 %");
        }
        else if (salarioAtual >= 400.01 && salarioAtual <= 800.00)
        {
            reajuste = salarioAtual * 0.12;
            salarioNovo = reajuste + salarioAtual;
            Console.WriteLine($"Novo salario: {salarioNovo:f2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:f2}");
            Console.WriteLine($"Em percentual: 12 %");
        }
        else if (salarioAtual >= 800.01 && salarioAtual <= 1200.00)
        {
            reajuste = salarioAtual * 0.10;
            salarioNovo = reajuste + salarioAtual;
            Console.WriteLine($"Novo salario: {salarioNovo:f2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:f2}");
            Console.WriteLine($"Em percentual: 10 %");
        }
        else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00)
        {
            reajuste = salarioAtual * 0.07;
            salarioNovo = reajuste + salarioAtual;
            Console.WriteLine($"Novo salario: {salarioNovo:f2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:f2}");
            Console.WriteLine($"Em percentual: 7 %");
        } else
        {
            reajuste = salarioAtual * 0.04;
            salarioNovo = reajuste + salarioAtual;
            Console.WriteLine($"Novo salario: {salarioNovo:f2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:f2}");
            Console.WriteLine($"Em percentual: 4 %");           
        }
    }
}