using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base;
            double Altura;
            double Perimetro;
            double Area;
            double Diagonal;



            Console.WriteLine("Digite a Base do Retângulo");
            Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Altura do Retângulo");
            Altura = double.Parse(Console.ReadLine());

            Perimetro = Base + Altura * 2;
            Area = Base * Altura;
            Diagonal = (Base * Base) + (Altura * Altura);
            Math.Sqrt(Diagonal);
            
            System.Console.WriteLine($"Eis vosso Perímetro: {Perimetro}");
            System.Console.WriteLine($"Eis vossa Área: {Area}");
            System.Console.WriteLine($"Eis vossa Diagonal: {Diagonal}");
        }
    }
}
