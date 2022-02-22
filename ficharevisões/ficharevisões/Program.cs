
using System;

namespace ficharevisões
{
    class Program
    {
        static double iva = 0.23;
        /*
 a - Lista de Números múltiplos de 10 (O utilizador escolhe o 1º e o ultimo numero) 
b - Calculo da raiz quadrada 
c - Calculo do expoente (O utilizador escolhe a base e o expoente)
d - Metros para milímetros
e - Horas para segundos
f - Calculadora (+ - * / e que apresente os valores arredondados a 2 casas decimais)
g - Compra de produtos (2 ou 3 produtos com um preço - a variável saldo tem de ser local e passar os valores para outros métodos - acrescentar ao preço o valor do iva [variavel global])
h - Euromilhões (5nrs 1 a 50) + (2estrelas 1 a 12)
0 - Sair*/

        static void Main(string[] args)
        {
            double saldo = 100;
            /*
            Console.WriteLine("\n \n \t \tFevereiro\n\nLoading:");
            for (int i = 0; i < 40; i++)
            {

                System.Threading.Thread.Sleep(60);
                Console.Write("▀");
            }
            System.Threading.Thread.Sleep(2500);
            Console.Clear();*/

            Menuopcoes(ref saldo);



        }

        public static void Menuopcoes(ref double saldo)
        {
            
            string op;
            Console.WriteLine("Escolhe uma das seguintes opçoes ! \n a -  Lista de Números múltiplos de 10 \n b - Calculo da raiz quadrada \n c - Calculo do expoente \n d - Metros para milímetros \n e - Horas para segundos \n f - Calculadora \n g - Compra de produtos \n h - Euromilhões \n Saldo="+saldo+" \n 0 - Sair");
            op = Console.ReadLine();
            
            while (op != "0")
            {
                if (op == "a")
                {
                    Listan(ref saldo);
                }
                else if (op == "b")
                {
                    raiz(ref saldo);
                }
                else if (op == "c")
                {
                    expoente(ref saldo);
                }
                else if (op == "d")
                {
                    Metros(ref saldo);
                }
                else if (op == "e")
                {
                    horas(ref saldo);
                }
                else if (op == "f")
                {
                    cal(ref saldo);
                }
                else if (op == "g")
                {
                    compra(ref saldo);
                }
                else if (op == "h")
                {
                    euromilhoes(ref saldo);
                }
            }

            Environment.Exit(0);
        }

        private static void euromilhoes(ref double saldo)
        {
            int rand2 = 0, num = 4, num1 = 1; //declara a variavel tipo inteiro

            Console.Clear();


            var rand = new Random();
            List<int> listNumbers = new List<int>();
            int numbers = rand.Next(1, 50);

            //Console.WriteLine("Insira o numero de numeros"); //pedir ao utilizador o valor 
            //num = int.Parse(Console.ReadLine()); //ler e armazenar na variavel num 
            Console.WriteLine("Os numeros são:");


            for (int i = 0; i <= num; i++) //fazer um ciclo for como o num escolhido 
            {
                numbers = rand.Next(1, 50);
                listNumbers.Add(numbers);
                //Console.WriteLine(listNumbers);

            }
            listNumbers.ForEach(Console.WriteLine);





            Random s = new Random();

            Console.WriteLine("A estrela é :");

            for (int i = 1; i <= 2; i++) //fazer um ciclo for como o num escolhido 
            {
                rand2 = s.Next(1, 13);
                Console.WriteLine(rand2); //print 
            }
            Thread.Sleep(5000); //tempo de espera de 2.0s
            Console.Clear();//apagar no que esta na consola
            Menuopcoes(ref saldo);//ir para o menu 1 
        }

        private static void compra(ref double saldo)
        {
            double produto1 = 10, produto2 = 20;
            int op2 =0;

            Console.WriteLine("Escolha um dos produtos \n 1-Dicas para o Lopes 10euros \n 2-Dicas avançadas para o Lopes 20euros");
            op2 = int.Parse(Console.ReadLine());
            if  (op2 == 1)
            {
                Console.WriteLine("Compra válida 1");
                saldo -= (produto1 * iva)+ produto1;
                Menuopcoes(ref  saldo);
            }
            else if (op2 == 2)
            {
                Console.WriteLine("Compra válida 2");
                saldo -= (produto2 * iva) + produto2;
                Menuopcoes(ref saldo);
            }
            else
            {
                Console.WriteLine("Não existe esta opção tenta outra vez");
                Thread.Sleep(2500);//tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menuopcoes(ref saldo);
            }


        }

        private static void cal(ref double saldo)
        {
            int opcao1;
            double n1, n2, contas;

            Console.WriteLine("Insira a opção ! \n 1 - Somar \n 2 - Subtrair \n 3 - Dividir \n 4 - Multiplicar ");
            opcao1 = int.Parse(Console.ReadLine());

            if (opcao1 == 1)
            {
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine("Insira o primeiro numero");//pedir ao utilzador o primeiro valor 
                n1 = double.Parse(Console.ReadLine());//armazenar em n1 com double 
                Console.WriteLine("Insira o segundo numero");//pedir ao utilzador o segundo valor 
                n2 = double.Parse(Console.ReadLine());//armazenar em n2 com double 
                contas = n1 + n2;//algoritmo de subtração
                contas = Math.Round(contas, 2);
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine(+n1 + " + " + n2 + " = " + contas);// apresentar o resultado concatenado
                Thread.Sleep(2500);//tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menuopcoes(ref saldo);

            }
            else if (opcao1 == 2)
            {
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine("Insira o primeiro numero");//pedir ao utilzador o primeiro valor 
                n1 = double.Parse(Console.ReadLine());//armazenar em n1 com double 
                Console.WriteLine("Insira o segundo numero");//pedir ao utilzador o segundo valor 
                n2 = double.Parse(Console.ReadLine());//armazenar em n2 com double 
                contas = n1 - n2;//algoritmo de subtração
                contas = Math.Round(contas, 2);
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine(+n1 + " - " + n2 + " = " + contas);// apresentar o resultado concatenado
                Thread.Sleep(2500);//tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menuopcoes(ref saldo);
            }
            else if (opcao1 == 3)
            {
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine("Insira o primeiro numero");//pedir ao utilzador o primeiro valor 
                n1 = double.Parse(Console.ReadLine());//armazenar em n1 com double 
                Console.WriteLine("Insira o segundo numero");//pedir ao utilzador o segundo valor 
                n2 = double.Parse(Console.ReadLine());//armazenar em n2 com double 
                contas = n1 / n2;//algoritmo de subtração
                contas = Math.Round(contas, 2);
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine(+n1 + " / " + n2 + " = " + contas);// apresentar o resultado concatenado
                Thread.Sleep(2500);//tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menuopcoes(ref saldo);
            }
            else if (opcao1 == 4)
            {
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine("Insira o primeiro numero");//pedir ao utilzador o primeiro valor 
                n1 = double.Parse(Console.ReadLine());//armazenar em n1 com double 
                Console.WriteLine("Insira o segundo numero");//pedir ao utilzador o segundo valor 
                n2 = double.Parse(Console.ReadLine());//armazenar em n2 com double 
                contas = n1 * n2;//algoritmo de subtração
                contas = Math.Round(contas, 2);
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine(+n1 + " * " + n2 + " = " + contas);// apresentar o resultado concatenado
                Thread.Sleep(2500);//tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menuopcoes(ref saldo);
            }
            else
            {
                Console.WriteLine("Não existe esta opção");
                Thread.Sleep(2500);//tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menuopcoes(ref saldo);
            }

        }

        private static void horas(ref double saldo)
        {
            Console.Clear();
            int m, a;
            Console.WriteLine("Insere o de horas este será convertido para segundos");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Para " + m + "h existe " + (a = m * 3600) + "segundos");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Menuopcoes(ref saldo);
        }

        private static void Metros(ref double saldo)
        {
            Console.Clear();
            int m, a;
            Console.WriteLine("Insere o numero de metros para converter");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Para " +m+ "m existe " + (a = m * 1000) +"mm");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Menuopcoes(ref saldo);
        }

        private static void expoente(ref double saldo)
        {
            Console.Clear();
            double n,d;
            Console.WriteLine("Insira o valor da base");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do expoente");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("o resultado é" + Math.Pow(n,d));
            Console.Clear();
            Menuopcoes(ref saldo);
        }

        private static void raiz(ref double saldo)
        {
            Console.Clear();
            double n;
            Console.WriteLine("Insira um valor ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("A raiz de "+n+ " é " + Math.Sqrt(n));
            Console.Clear();
            Menuopcoes(ref saldo);
        }

        private static void Listan(ref double saldo)
        {
            int pri, seg;
            Console.Clear();
            Console.WriteLine("Insira o primeiro valor ");
            pri = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o ultimo valor");
            seg = int.Parse(Console.ReadLine());

            if (pri == seg)
            {
                Console.WriteLine("o numeros são iguais ");
            }

            else if (pri != seg)
            {
                for ( int i = pri; i <= seg; i+= 10)
                {
                    System.Threading.Thread.Sleep(1000);
                    
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Tete outrz vez mais tarde! ");
                Menuopcoes(ref saldo);

            }

            Menuopcoes(ref saldo);
        }
        
    }
}
