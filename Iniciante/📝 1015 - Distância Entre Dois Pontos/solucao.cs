using System; 

class URI {

    static void Main(string[] args) { 

        string[] x = Console.ReadLine().Split(' ');
        double x1 = double.Parse(x[0]);
        double y1 = double.Parse(x[1]);
        string[] y = Console.ReadLine().Split(' ');
        double x2 = double.Parse(y[0]);
        double y2 = double.Parse(y[1]);

        double distancia = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        Console.WriteLine($"{distancia:F4}");
    }

}