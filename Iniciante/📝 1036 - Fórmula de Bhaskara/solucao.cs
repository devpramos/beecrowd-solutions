using System; 

class URI {

    static void Main(string[] args) { 

        string[] pontos = Console.ReadLine().Split(' ');
        double a = double.Parse(pontos[0]);
        double b = double.Parse(pontos[1]);
        double c = double.Parse(pontos[2]);
        double delta = b * b - (4 * a * c);
        if (delta >= 0 && a > 0 && b > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"R1 = {x1:F5}");
            Console.WriteLine($"R2 = {x2:F5}");
        }
        else
        {
            Console.WriteLine("Impossivel calcular");
        }
    }

}