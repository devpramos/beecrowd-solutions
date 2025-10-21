using System;

class URI {

    static void Main(string[] args) {

        int contPositivos = 0;
        double somaPositivos = 0;
        for (int i = 0; i < 6; i++)
        {
            double num = double.Parse(Console.ReadLine());
            if (num > 0)
            {
                contPositivos++;
                somaPositivos += num;
            }
        }

        double mediaPositivos = somaPositivos / contPositivos;

        Console.WriteLine($"{contPositivos} valores positivos");
        Console.WriteLine($"{mediaPositivos:F1}");

    }

}