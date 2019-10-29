using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double medidaC;
            double medidaF;
            

            System.Console.WriteLine("Digite vossa temperatura em °C: ");
            medidaC = double.Parse(Console.ReadLine());

            medidaF = (( 9 * medidaC + 160) / 5);
            
            System.Console.WriteLine($"Eis vossa conversão para °F: {medidaF}");
        }
    }
}
