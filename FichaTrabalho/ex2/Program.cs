using System;

namespace ex2
{
    class Program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n \n \t \tFevereiro\n\nLoading:");
            for (int i = 0; i < 40; i++)
            {

                System.Threading.Thread.Sleep(60);
                Console.Write("▀");
            }
            System.Threading.Thread.Sleep(2500);
            Console.Clear();

            int utilizador1 = 0, utilizador2 = 0, fosfuros = 0;


            while (fosfuros != 21 && fosfuros < 21 )
            {
                Console.WriteLine("Quantos fósforos deseja retirar Utilizador 1");
                utilizador1 = int.Parse(Console.ReadLine());
                if (utilizador1 > 4 || utilizador1 < 0)
                {
                    Console.WriteLine(  "Não podes utilziar essa quantia de fosfuros ");
                }
                else
                {
                    fosfuros += utilizador1;
                    Console.WriteLine("Sobram " + (21-fosfuros));
                }

                Console.WriteLine("Quantos fósforos deseja retirar Utilizador 2");
                utilizador2 = int.Parse(Console.ReadLine());

                if (utilizador2 > 4 || utilizador2 < 0)
                {
                    Console.WriteLine("Não podes utilziar essa quantia de fosfuros ");
                }
                else
                {
                    fosfuros += utilizador2;
                    Console.WriteLine("Sobram " + (21 - fosfuros));
                }
                
                
                
            }
            Console.WriteLine("O utilizador que retioru o ultimo fosforo perdeu");

        }
    }
}




