using System;

class Program
{
    static void Main()
    {

        string[] peca1 = Console.ReadLine().Split(' ');
        int codigo1 = int.Parse(peca1[0]);
        int quantidade1 = int.Parse(peca1[1]);
        double valor1 = double.Parse(peca1[2]);

        string[] peca2 = Console.ReadLine().Split(' ');
        int codigo2 = int.Parse(peca2[0]);
        int quantidade2 = int.Parse(peca2[1]);
        double valor2 = double.Parse(peca2[2]);

        double total = (quantidade1 * valor1) + (quantidade2 * valor2);

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
    }
}