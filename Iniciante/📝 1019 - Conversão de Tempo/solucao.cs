using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        int horas = n / 3600;
        int restohrs = n % 3600;
        int minutos = restohrs / 60;
        int restomnts = restohrs % 60;
        int segundos = restomnts;
        Console.WriteLine($"{horas}:{minutos}:{segundos}");

    }

}