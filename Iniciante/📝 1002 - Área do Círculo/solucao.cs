using System; 

class URI {

    static void Main(string[] args) { 

         const double n = 3.14159;
         double raio = double.Parse(Console.ReadLine());
         double area = n * (raio * raio);
         Console.WriteLine($"A={area:F4}");

    }

}