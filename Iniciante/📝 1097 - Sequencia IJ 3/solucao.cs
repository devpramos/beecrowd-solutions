using System; 

class URI {

    static void Main(string[] args) {

        int i = 1;
        int j = 7;
        int posI = 0;
        int contJ = 0;

        while (i <= 9)
        {
            Console.Write($"I={i} ");
            Console.WriteLine($"J={j}");
            j -= 1;
            posI++;
            if (posI == 3)
            {
                contJ++;
                posI = 0;
                i += 2;
                j = 7;
                j += 2 * contJ;
            }
        }
    }

}