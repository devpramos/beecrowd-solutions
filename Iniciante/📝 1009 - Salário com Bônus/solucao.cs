using System; 

class URI {

    static void Main(string[] args) { 

         string nome = Console.ReadLine();
         double salario = double.Parse(Console.ReadLine());
         double vendas = double.Parse(Console.ReadLine());
         double comissao = (double) vendas * 0.15;
         double total = (double) comissao + salario;
         
         Console.WriteLine($"TOTAL = R$ {total:F2}");

    }

}