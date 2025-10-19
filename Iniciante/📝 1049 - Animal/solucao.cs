using System; 

class URI {

    static void Main(string[] args) {

        string classeBiologica = Console.ReadLine();
        string classeAnimal = Console.ReadLine();
        string tipoAlimentacao = Console.ReadLine();

        if (classeBiologica == "vertebrado" && classeAnimal == "ave" && tipoAlimentacao == "carnivoro")
            Console.WriteLine("aguia");
        if (classeBiologica == "vertebrado" && classeAnimal == "ave" && tipoAlimentacao == "onivoro")
            Console.WriteLine("pomba");
        if (classeBiologica == "vertebrado" && classeAnimal == "mamifero" && tipoAlimentacao == "onivoro")
            Console.WriteLine("homem");
        if (classeBiologica == "vertebrado" && classeAnimal == "mamifero" && tipoAlimentacao == "herbivoro")
            Console.WriteLine("vaca");
        // =================================================================================================== //   
        if (classeBiologica == "invertebrado" && classeAnimal == "inseto" && tipoAlimentacao == "hematofago")
            Console.WriteLine("pulga");
        if (classeBiologica == "invertebrado" && classeAnimal == "inseto" && tipoAlimentacao == "herbivoro")
            Console.WriteLine("lagarta");
        if (classeBiologica == "invertebrado" && classeAnimal == "anelideo" && tipoAlimentacao == "hematofago")
            Console.WriteLine("sanguessuga");
        if (classeBiologica == "invertebrado" && classeAnimal == "anelideo" && tipoAlimentacao == "onivoro")
            Console.WriteLine("minhoca");                            
    }

}