using System;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[3]; 
            double Num1;
            double Num2;
            double Num3;
            

            System.Console.WriteLine("Escreva o 1° Número: ");
            Num1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Escreva o 2° Número: ");
            Num2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Escreva o 2° Número: ");
            Num3 = double.Parse(Console.ReadLine());
            
            numeros[0] = Num1;
            numeros[1] = Num2;
            numeros[2] = Num3;

            Console.Clear();
            
            Array.Sort(numeros);
            foreach(int i in numeros)
            {
                System.Console.WriteLine("Eis a ordem numérica de vossos números ...");
                System.Console.WriteLine(i);
            }
        }
    }
}
