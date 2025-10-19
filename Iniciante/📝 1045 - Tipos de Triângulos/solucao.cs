using System;

class URI
{

    static void Main(string[] args)
    {

        string[] pontos = Console.ReadLine().Split(' ');
        double a = double.MinValue;
        double b = 0;
        double c = 0;
        int indiceVetor = -1;
        for (int i = 0; i < pontos.Length; i++)
        {
            double convertI = double.Parse(pontos[i]);
            if (convertI > a)
            {
                a = convertI;
                indiceVetor = i;
            }
        }
        for (int j = 0; j < pontos.Length; j++)
        {
            if (indiceVetor != j)
            {
                if (b == 0)
                    b = double.Parse(pontos[j]);
                else
                    c = double.Parse(pontos[j]);

            }
        }

        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (a * a == b * b + c * c)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if (a * a > b * b + c * c)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if (a * a < b * b + c * c)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if (a == b && a != c || a == c && a != b || b == c && b != a)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}