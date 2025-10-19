using System;

class URI
{

    static void Main(string[] args)
    {
        int calculo = 0;
        int duracao;
        int calculominutos;
        string[] entrada = Console.ReadLine().Split(' ');
        int horainicial = int.Parse(entrada[0]);
        int mininicial = int.Parse(entrada[1]);
        int horafim = int.Parse(entrada[2]);
        int minfim = int.Parse(entrada[3]);
        int tempo_total_inicial = (horainicial * 60) + mininicial;
        int tempo_total_final = (horafim * 60) + minfim;
        if (tempo_total_final > tempo_total_inicial)
        {
            duracao = tempo_total_final - tempo_total_inicial;
            calculo = duracao / 60;
            calculominutos = duracao % 60;
            Console.WriteLine($"O JOGO DUROU {calculo} HORA(S) E {calculominutos} MINUTO(S)");
        }
        else if (tempo_total_final < tempo_total_inicial)
        {
            duracao = 1440 - (tempo_total_inicial - tempo_total_final);
            calculo = duracao / 60;
            calculominutos = duracao % 60;
            Console.WriteLine($"O JOGO DUROU {calculo} HORA(S) E {calculominutos} MINUTO(S)");
        }
        else 
        {
            calculo = 24;
            calculominutos = 0;
            Console.WriteLine($"O JOGO DUROU {calculo} HORA(S) E {calculominutos} MINUTO(S)");
        }
    }
}