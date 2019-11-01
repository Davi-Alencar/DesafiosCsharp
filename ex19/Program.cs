using System;

namespace ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador = 0;
            int[] Vetor = new int[Contador];

            Console.Clear();
            System.Console.Write("Digite um número para contador: ");
            Contador = int.Parse(Console.ReadLine());

            if(Contador > 20)
            {
                Console.Clear();
                System.Console.WriteLine($"Você não vai querer contar até {Contador}, confie em mim.. ");
                System.Console.WriteLine("Tente um número menor que 20 para seu próprio bem");

            } else {

                /*bool numCorreto = true;*/

                for(int i = 0; i < Contador; i++) 
                {
                    System.Console.Write($"Digite o número {i+1} (Até o número {Contador}): ");
                    int Num = int.Parse(Console.ReadLine());

                    if(Num == i+1)
                    {
                        System.Console.WriteLine();
                        
                        if(Num == Contador)
                        {
                            System.Console.WriteLine($"Meus parabéns! Você agora sabe contar até {Contador}!");
                        }
                    } 

                    /* tentar fazer com que repita e continue do{*/
                        else if(Num != i+1)
                        {
                            System.Console.WriteLine("Este número não é correspondente à sequência");
                            System.Console.WriteLine();
                            /*numCorreto = false;*/
                        }
                    
                    /*  while (numCorreto == true); */
                }
            }
        }
    }
}
