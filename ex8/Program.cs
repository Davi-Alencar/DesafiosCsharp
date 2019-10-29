using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int Altura;

            System.Console.WriteLine("Digite a altura do Triângulo: ");
            Altura = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            for (int Linha = 0; Linha <= Altura; ++Linha)
            {
                for (int Coluna = Altura; Coluna > Linha; --Coluna)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
            
        }
    }
}
