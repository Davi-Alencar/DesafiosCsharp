using System;

namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            double IMC;

            Console.Clear();

            System.Console.WriteLine("Digite seu Peso em Kg: ");
            double Peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Digite sua Altura em Metros: ");
            double Altura = double.Parse(Console.ReadLine());

            IMC = Peso/(Altura * Altura);

            System.Console.WriteLine();
            System.Console.WriteLine($"O nível de seu IMC é: {Convert.ToInt32(IMC)}");

            if (IMC < 20)
            {
                System.Console.WriteLine("Seu Índice de Massa Corporal é abaixo do peso");
            }
            
            else if ((IMC <= 25) && (IMC >= 20))
            {
                System.Console.WriteLine("Seu Índice de Massa Corporal é normal");
            }
            
            else if ((IMC <= 30) && (IMC > 25))
            {
                System.Console.WriteLine("Seu Índice de Massa Corporal é excesso de peso");
            }

            else if ((IMC > 30) && (IMC <= 35))
            {
                System.Console.WriteLine("Seu Índice de Massa Corporal é obesidade");
            }

            else if (IMC > 35)
            {
                System.Console.WriteLine("Seu Índice de Massa Corporal é obesidade mórbida");
            }
        }
    }
}
