using System; 

class URI {

    static void Main(string[] args) {

        int i, n;

        n = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            double div = x / y;

            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            } else
            {
                Console.WriteLine($"{div:F1}");
            }

        }
    }

}
