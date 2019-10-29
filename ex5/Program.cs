using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string ValorA = "";
            string ValorB = "";
            string C = "";

                System.Console.WriteLine("Digite o 1° Valor: ");
                ValorA = Console.ReadLine();

                System.Console.WriteLine("Digite o 2° Valor: ");
                ValorB = Console.ReadLine();

                C = ValorA; 
                ValorA = ValorB;
                ValorB = C;

                System.Console.WriteLine($"Eis vosso 1° Valor: {ValorA}");
                System.Console.WriteLine($"Eis vosso 2° Valor: {ValorB}");

        }
    }
}
