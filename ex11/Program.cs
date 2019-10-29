using System;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[2]; 
            string Nome1;
            string Nome2;

            System.Console.WriteLine("Escreva o 1° Nome: ");
            Nome1 = Console.ReadLine();

            System.Console.WriteLine("Escreva o 2° Nome: ");
            Nome2 = Console.ReadLine();
            
            nomes[0] = Nome1;
            nomes[1] = Nome2;

            Console.Clear();
            
            Array.Sort(nomes);
            foreach(string i in nomes)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
