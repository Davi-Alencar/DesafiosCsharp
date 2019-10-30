using System;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1;
            int lado2;
            int lado3;

            System.Console.WriteLine("Digite o 1° número de Lados: ");
            lado1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o 2° número de Lados: ");
            lado2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o 3° número de Lados: ");
            lado3 = int.Parse(Console.ReadLine());

            bool trianguloValido = false;
            if(lado1 < (lado2 + lado3) || lado2 < (lado1 + lado3) || lado3 < (lado1 + lado2) )
            {
                trianguloValido = true;
            } else {
                trianguloValido = false;
            }
            
            if (trianguloValido == true) {
                if (lado1 == lado2 && lado1 == lado3 && lado2 == lado1 && lado2 == lado3 && lado3 == lado1 && lado3 == lado2)
                {
                    System.Console.WriteLine("Este é um triângulo equilátero (lados equivalentes");
                }

                if (lado1 != lado2 && lado1 != lado3 && lado2 != lado1 && lado2 != lado3 && lado3 != lado1 && lado3 != lado2)
                {
                    System.Console.WriteLine("Este é um triângulo escaleno (lados diferentes)");
                }

                if (lado1 == lado2 && lado1 != lado3 || lado1 != lado2 && lado1 == lado3 || lado2 == lado1 && lado2 != lado3 || lado2 != lado1 && lado2 == lado3 || lado3 == lado1 && lado3 != lado2 || lado3 != lado1 && lado3 == lado2)
                {
                    System.Console.WriteLine("Este é um triângulo isóceles (dois lados iguais)");
                }


            } else {
                System.Console.WriteLine("Não é um triângulo válido");
            }

        }
    }
}
