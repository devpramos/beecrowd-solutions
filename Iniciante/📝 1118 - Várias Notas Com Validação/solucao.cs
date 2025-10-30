using System; 

class URI {

    static void Main(string[] args) {

        double nota1, nota2, media;
        int x = 0;

        while (x != 2)
        {
            do
            {
                nota1 = double.Parse(Console.ReadLine());
                if (nota1 < 0 || nota1 > 10)
                    Console.WriteLine("nota invalida");
            } while (nota1 < 0 || nota1 > 10);
            
            do
            {
                nota2 = double.Parse(Console.ReadLine());
                if (nota2 < 0 || nota2 > 10)
                    Console.WriteLine("nota invalida");
            } while (nota2 < 0 || nota2 > 10);

            media = (nota1 + nota2) / 2;
            Console.WriteLine($"media = {media:f2}");

            do
            {
                Console.WriteLine($"novo calculo (1-sim 2-nao)");
                x = int.Parse(Console.ReadLine());
            } while (x != 1 && x != 2);
        }

    }

}