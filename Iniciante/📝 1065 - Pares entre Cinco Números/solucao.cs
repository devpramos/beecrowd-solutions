using System;

class URI {

    static void Main(string[] args) {

        int contPares = 0;
        for (int i = 0; i < 5; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                contPares++;
            }
        }

        Console.WriteLine($"{contPares} valores pares");

    }

}