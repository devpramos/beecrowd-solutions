using System; 

class URI {

    static void Main(string[] args) { 

        int idadedias = int.Parse(Console.ReadLine());
        int anos = idadedias / 365;
        int restoanos = idadedias % 365;
        int meses = restoanos / 30;
        int dias = restoanos % 30;
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }

}