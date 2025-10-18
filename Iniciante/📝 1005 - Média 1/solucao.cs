using System; 

class URI {

    static void Main(string[] args) { 
         
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());

        double media = (n1 * 3.5 + n2 * 7.5) / 11.0;

        Console.WriteLine($"MEDIA = {media:F5}");

    }

}