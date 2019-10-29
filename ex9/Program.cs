using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            double GMercurio = 0.37;
            double GVenus = 0.88;
            double GMarte = 0.38;
            double GJupiter = 2.64;
            double GSaturno = 1.15;
            double GUrano = 1.17;
            double Resultado;
            string opcao;

            Console.Clear();
            System.Console.WriteLine("~ Escolha seu Planeta! ~");
            System.Console.WriteLine();
            System.Console.WriteLine("1. Mercúrio");
            System.Console.WriteLine("2. Vênus");
            System.Console.WriteLine("3. Marte");
            System.Console.WriteLine("4. Júpiter");
            System.Console.WriteLine("5. Saturno");
            System.Console.WriteLine("6. Urâno");
            opcao = Console.ReadLine();
            Console.Clear();
            

            System.Console.WriteLine("Digite o peso: ");
            double Peso = double.Parse(Console.ReadLine());

            switch(opcao)
            {
                case "1": 
                    Resultado = (Peso / 10) * GMercurio;
                    System.Console.WriteLine($"{Peso} aqui, pesam {Resultado} em Mercúrio");
                break;

                case "2": 
                    Resultado = (Peso/10) * GVenus;
                    System.Console.WriteLine($"{Peso} aqui, pesam {Resultado} em Vênus");
                break;

                case "3": 
                    Resultado = (Peso/10) * GMarte;
                    System.Console.WriteLine($"{Peso} aqui, pesam {Resultado} em Marte");
                break;

                case "4": 
                    Resultado = (Peso/10) * GJupiter;
                    System.Console.WriteLine($"{Peso} aqui, pesam {Resultado} em Júpiter");
                break;

                case "5": 
                    Resultado = (Peso/10) * GSaturno;
                    System.Console.WriteLine($"{Peso} aqui, pesam {Resultado} em Saturno");
                break;

                case "6": 
                    Resultado = (Peso/10) * GUrano;
                    System.Console.WriteLine($"{Peso} aqui, pesam {Resultado} em Urâno");
                break;
                
            }            
        }
    }
}
