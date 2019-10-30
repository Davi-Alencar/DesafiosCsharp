using System;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite um número como limite: ");
            double Limite = double.Parse(Console.ReadLine());
            
            
            if(Limite % 2 == 0)
            {
                Limite -= 1;
                for(double i= 1 ; i <= Limite; i+=2)
                {
                    System.Console.Write(Convert.ToInt32(i) + ", ");
                }
            } else {
                for(double i= 1; i < Limite; i+=2)
                {
                    System.Console.Write(Convert.ToInt32(i) + ", ");
                }
            }
        }
    }
}