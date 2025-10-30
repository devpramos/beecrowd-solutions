using System; 

class URI {

    static void Main(string[] args) { 

        int x, y;
        do
        {
            string[] entrada = Console.ReadLine().Split(' ');
            x = int.Parse(entrada[0]);
            y = int.Parse(entrada[1]);
            if (y > 0 && x > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if (y > 0 && x < 0)
            {
                Console.WriteLine("segundo");
            }
            else if (y < 0 && x < 0)
            {
                Console.WriteLine("terceiro");
            }
            else if (y < 0 && x > 0)
            {
                Console.WriteLine("quarto");
            }

            
        } while (x != 0 && y != 0);

    }

}