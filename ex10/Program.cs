using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor;
            
            Console.WriteLine("Digite um número: ");
            Valor = double.Parse(Console.ReadLine());
            
            if (Valor % 3 == 0)
            {
                System.Console.WriteLine($"O número {Valor} é múltiplo de 3");
            } else {
                System.Console.WriteLine($"O número {Valor} não é múltiplo de 3");
            }
        }
    }
}
