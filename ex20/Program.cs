using System;

namespace ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor = new int[10];
            int Num = 0;
            Random numAleatorio = new Random();

            System.Console.WriteLine();
            Console.Clear();
            
            if(Num % 2 && == 0)
            {
                
            }


            for(int i = 0; i < 10; i++)
            {
                Num = numAleatorio.Next(0, 100);
                Vetor[i] = Num;
                System.Console.WriteLine($"Posição - {i}  Número aleatório: {Num}");
            }


        }
    }
}
