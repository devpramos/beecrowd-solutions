using System; 

class URI {

    static void Main(string[] args) {

        int i = 1;
        int j = 7;
        int posI = 0;

        while (i <= 9)
        {
            Console.Write($"I={i} ");
            Console.WriteLine($"J={j}");
            j -= 1;
            posI++;
            if (j < 5)
            {
                j = 7;
            }
            if (posI == 3)
            {
                posI = 0;
                i += 2;
            }
        }
    }

}