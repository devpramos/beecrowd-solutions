using System; 

class URI {

    static void Main(string[] args) { 

         double R = double.Parse(Console.ReadLine());
         double pi = 3.14159;
         double volume = (double) (4/3.0) * pi * (R * R * R);
         Console.WriteLine($"VOLUME = {volume:F3}");

    }

}