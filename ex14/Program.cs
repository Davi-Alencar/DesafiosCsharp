using System;

namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool comandoInvalido = false;
            
            Console.Clear();
            System.Console.WriteLine("Digite um verbo no infinitivo: ");
            string Verbo = Console.ReadLine();

            Verbo.ToLower();
            
            if (comandoInvalido == false)
            {
                if(Verbo.EndsWith("ar"))
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Este é um verbo de 1a conjugação");
                }

                if(Verbo.EndsWith("er"))
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Este é um verbo de 2a conjugação");
                }

                if(Verbo.EndsWith("ir"))
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Este é um verbo de 3a conjugação");
                }

                if(Verbo.EndsWith("or"))
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Verbo com final OR???");
                }
            } else {
                comandoInvalido = true;
                System.Console.WriteLine("Comando inválido");
            }
        }
    }
}
