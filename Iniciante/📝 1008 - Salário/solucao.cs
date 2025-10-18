using System; 

class URI {

    static void Main(string[] args) { 

         int numero = int.Parse(Console.ReadLine());
         int horas = int.Parse(Console.ReadLine());
         double valorhora = double.Parse(Console.ReadLine());
         double salario = (double) horas * valorhora;
         
         Console.WriteLine($"NUMBER = {numero}");
         Console.WriteLine($"SALARY = U$ {salario:F2}");

    }

}