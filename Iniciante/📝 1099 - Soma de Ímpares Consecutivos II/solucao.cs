using System;

class URI {

    static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);
            int soma = 0;
            if (x > y)
            {
                y = int.Parse(entrada[0]);
                x = int.Parse(entrada[1]);
            }
            for (int j = x+1; j < y; j++)
            {
                if (j % 2 != 0)
                {
                    soma += j;
                }
            }

            Console.WriteLine(soma);

        }

    }

}