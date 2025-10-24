using System; 

class URI {

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        if (2 < n && n < 1000)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }
        }
    }

}
