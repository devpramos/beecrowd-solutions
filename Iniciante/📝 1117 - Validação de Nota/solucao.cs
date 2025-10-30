using System;

class URI {

    static void Main(string[] args) {

        int contValidas = 0;
        double somaNotas = 0;

        while (contValidas != 2)
        {
            double nota = double.Parse(Console.ReadLine());
            if (nota >= 0 && nota <= 10)
            {
                somaNotas += nota;
                contValidas++;
            }
            else
            {
                Console.WriteLine("nota invalida");
            }
        }

        Console.WriteLine($"media = {somaNotas / contValidas}");

    }

}