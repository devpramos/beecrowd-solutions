using System; 

class URI {

    static void Main(string[] args) { 

        int senhaCorreta = 2002;
        int senha;
        do
        {
            senha = int.Parse(Console.ReadLine());
            if (senha != senhaCorreta)
            {
                Console.WriteLine("Senha Invalida");
            }
        } while (senhaCorreta != senha);
        
        Console.WriteLine("Acesso Permitido");

    }

}