﻿using System;

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
            if(lado1 < (lado2 + lado3) ||)
            {
                trianguloValido = true;
            } else {
                trianguloValido = false;
            }
            

        }
    }
}