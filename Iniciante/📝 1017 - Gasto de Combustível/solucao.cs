using System; 

class URI {

    static void Main(string[] args) { 

        int tempo = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());
        int distancia = velocidade * tempo;
        double consumo = (double) distancia / 12;
        Console.WriteLine($"{consumo:F3}");

    }

}