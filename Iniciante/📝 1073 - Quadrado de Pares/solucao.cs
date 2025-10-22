using System; 

class URI {

    static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());
        if (5 < n && n < 2000)
        {
            double quadrado;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    quadrado = Math.Pow(i, 2);
                    Console.WriteLine($"{i}^2 = {quadrado}");
                }
            }
        }
    }
}