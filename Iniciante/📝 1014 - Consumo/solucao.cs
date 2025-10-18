using System; 

class URI {

    static void Main(string[] args) { 

        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double consumo = x / y;
        Console.WriteLine($"{consumo:F3} km/l");
    }

}