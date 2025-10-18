using System; 

class URI {

    static void Main(string[] args) { 

         double n1 = double.Parse(Console.ReadLine());
         double n2 = double.Parse(Console.ReadLine());
         double n3 = double.Parse(Console.ReadLine());
         
         double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10.0;
         
         Console.WriteLine($"MEDIA = {media:F1}");

    }

}