using System;

namespace ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número de 1 à 12: ");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    System.Console.WriteLine("Este número corresponde ao mês Janeiro");
                break;

                case 2:
                    System.Console.WriteLine("Este número corresponde ao mês Fevereiro");
                break;

                case 3:
                    System.Console.WriteLine("Este número corresponde ao mês Março");
                break;

                case 4:
                    System.Console.WriteLine("Este número corresponde ao mês Abril");
                break;

                case 5:
                    System.Console.WriteLine("Este número corresponde ao mês Maio");
                break;

                case 6:
                    System.Console.WriteLine("Este número corresponde ao mês Junho");
                break;

                case 7:
                    System.Console.WriteLine("Este número corresponde ao mês Julho");
                break;

                case 8:
                    System.Console.WriteLine("Este número corresponde ao mês Agosto");
                break;

                case 9:
                    System.Console.WriteLine("Este número corresponde ao mês Setembruh");
                break;

                case 10:
                    System.Console.WriteLine("Este número corresponde ao mês Outubro");
                break;

                case 11:
                    System.Console.WriteLine("Este número corresponde ao mês Novembro");
                break;

                case 12:
                    System.Console.WriteLine("Este número corresponde ao mês Dezembro");
                break;

                default:
                System.Console.WriteLine("Este mês não corresponde à um mês...");
                break;
            }
            
        }
    }
}
