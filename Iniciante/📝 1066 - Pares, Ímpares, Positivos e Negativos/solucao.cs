using System;

class URI {

    static void Main(string[] args) {

        int contPares = 0;
        int contImpares = 0;
        int contPositivos = 0;
        int contNegativos = 0;
        for (int i = 0; i < 5; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                contPares++;
            else
                contImpares++;
            if (num > 0)
                contPositivos++;
            else if (num < 0)
                contNegativos++;
        }

        Console.WriteLine($"{contPares} valor(es) par(es)");
        Console.WriteLine($"{contImpares} valor(es) impar(es)");
        Console.WriteLine($"{contPositivos} valor(es) positivo(s)");
        Console.WriteLine($"{contNegativos} valor(es) negativo(s)");

    }

}