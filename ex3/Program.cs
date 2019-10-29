using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Tempo;
            int Distancia;
            double Velocidade;
            
            /*1Km = 12L*/
            System.Console.WriteLine("Quantas horas levaram sua viajem?");
            Tempo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a velocidade em média (Km/h) no qual viajava");
            Velocidade = double.Parse(Console.ReadLine());

            Distancia = Convert.ToInt32(Tempo * Velocidade);

            System.Console.WriteLine($"A quantidade de combustível usado foi: {Distancia/12} Litros");
        }
    }
}
