using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor;

            System.Console.WriteLine("Digite um valor: ");
            Valor = double.Parse(Console.ReadLine());

            if (Valor % 2 == 0)
            {
                System.Console.WriteLine("Seu número é par");
            } else {
                System.Console.WriteLine("Seu número é ímpar");
            }
            


        }
    }
}
