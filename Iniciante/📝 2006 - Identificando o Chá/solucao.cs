using System; 

class URI {

    static void Main(string[] args) {

        int t = int.Parse(Console.ReadLine());
        string[] entrada = Console.ReadLine().Split(' ');
        int inteiros;
        int contCertos = 0;

        for (int i = 0; i < entrada.Length; i++)
        {
            inteiros = int.Parse(entrada[i]);
            if (inteiros == t)
            {
                contCertos++;
            }
        }

        Console.WriteLine(contCertos);

    }

}