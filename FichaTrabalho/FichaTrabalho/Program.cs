using System;

namespace FevereiroTrabaalhoPratico
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


            login();


            int a, b, c;

            /*
            Console.WriteLine("Select one game:  \n 1-Generator Game \n 2- Generator Game with attemps \n 3- Special Generator \n 0-Exit");
            c = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            while (c != 0)
            {
                if (c == 1) //game 1
                {
                    Console.WriteLine("Change your option: \n 1-Easy \n 2-Hard \n 3-Expert \n 0-Exit");
                    a = int.Parse(Console.ReadLine());
                    while (a != 0)
                    {
                        if (a == 1) //requested level ; level easy
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Random random = new Random();
                            int rasp = random.Next(1, 20);
                            Console.WriteLine(rasp);

                            int arma = 0;


                            Console.WriteLine("Insert one number (1-20)");
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (n != rasp)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                }
                                else if (n < rasp)
                                {
                                    Console.WriteLine("The number is bigger");
                                    arma++;
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }
                        else if (a == 2) //system levels level hard
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Random random = new Random();
                            int rasp = random.Next(1, 50);
                            Console.WriteLine(rasp);

                            int arma = 0;


                            Console.WriteLine("Insert one number (1-50)");
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (n != rasp)
                            {
                                Console.Clear();
                                Console.WriteLine("Insert one number (1-50)");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {

                                    Console.WriteLine("The number is correct");

                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n < rasp)
                                {

                                    Console.WriteLine("The number is bigger");


                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();

                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            System.Threading.Thread.Sleep(4000);
                            Environment.Exit(0);
                        }

                        else if (a == 3) //system levels level expert
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Random random = new Random();
                            int rasp = random.Next(1, 100);
                            Console.WriteLine(rasp);

                            int arma = 0;


                            Console.WriteLine("Insert one number (1-100)");
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (n != rasp)
                            {
                                Console.Clear();
                                Console.WriteLine("Insert one number (1-100)");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {

                                    Console.WriteLine("The number is correct");

                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n < rasp)
                                {

                                    Console.WriteLine("The number is bigger");


                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();

                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            System.Threading.Thread.Sleep(4000);
                            Environment.Exit(0);
                        }


                        else
                        {
                            Console.WriteLine("Your option is unviable");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }

                    }
                    Environment.Exit(0);
                }
                else if (c == 2) //game 2
                {
                    Console.WriteLine("Change your option: \n 1-Easy \n 2-Hard \n 3-Expert \n 0-Exit");
                    a = int.Parse(Console.ReadLine());
                    while (a != 0)
                    {
                        if (a == 1)
                        {
                            Console.WriteLine("Insert one number (1-20)");
                            b = int.Parse(Console.ReadLine());
                            while (b == b)
                            {

                                Console.WriteLine("Insert one number (1-20)");
                                b = int.Parse(Console.ReadLine());

                            }
                        }
                        else if (a == 2)
                        {

                        }
                        else if (a == 3)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Your option is unviable");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }

                    }
                }
                else if (c == 1) //game 3
                {
                    Console.WriteLine("Change your option: \n 1-Easy \n 2-Hard \n 3-Expert \n 0-Exit");
                    a = int.Parse(Console.ReadLine());
                    while (a != 0)
                    {
                        if (a == 1)
                        {
                            Console.WriteLine("Insert one number (1-20)");
                            b = int.Parse(Console.ReadLine());
                            while (b == b)
                            {

                                Console.WriteLine("Insert one number (1-20)");
                                b = int.Parse(Console.ReadLine());

                            }
                        }
                        else if (a == 2)
                        {

                        }
                        else if (a == 3)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Your option is unviable");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }

                    }
                }


            }*/

        }

        private static void login()
        {
            string request, requestp, player = "Fevereiro", admin = "Admin", pplayer = "fevereiro123", padmin = "admin123";

            Console.WriteLine("Insert username");
            request = Console.ReadLine();

            Console.WriteLine("Insert password");
            requestp = Console.ReadLine();



            if (request == player || request == pplayer)
            {

                Console.Clear();
                Console.WriteLine("User Panel");
                Muser();

            }
            else if (requestp == admin || requestp == padmin)
            {
                Console.Clear();
                Console.WriteLine("Admin Panel");
                MAdmin();


            }
            else
            {
                Console.WriteLine("User or password invalid, try again");

                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                login();
            }
        }

        private static void MAdmin()
        {
            int a, b, c;


            Console.WriteLine("Select one game:  \n 1-Generator Game \n 2- Generator Game with attemps \n 3- Special Generator \n 0-Exit");
            c = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            while (c != 0)
            {
                if (c == 1) //game 1
                {
                    Console.WriteLine("Change your option: \n 1-Easy \n 2-Hard \n 3-Expert \n 0-Exit");
                    a = int.Parse(Console.ReadLine());
                    while (a != 0)
                    {
                        if (a == 1) //requested level ; level easy
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Random random = new Random();
                            int rasp = random.Next(1, 20);
                            Console.WriteLine(rasp);

                            int arma = 0;


                            Console.WriteLine("Insert one number (1-20)");
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (n != rasp)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                }
                                else if (n < rasp)
                                {
                                    Console.WriteLine("The number is bigger");
                                    arma++;
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }
                        else if (a == 2) //system levels level hard
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Random random = new Random();
                            int rasp = random.Next(1, 50);
                            Console.WriteLine(rasp);

                            int arma = 0;


                            Console.WriteLine("Insert one number (1-50)");
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (n != rasp)
                            {
                                Console.Clear();
                                Console.WriteLine("Insert one number (1-50)");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {

                                    Console.WriteLine("The number is correct");

                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n < rasp)
                                {

                                    Console.WriteLine("The number is bigger");


                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();

                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            System.Threading.Thread.Sleep(4000);
                            Environment.Exit(0);
                        }

                        else if (a == 3) //system levels level expert
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Random random = new Random();
                            int rasp = random.Next(1, 100);
                            Console.WriteLine(rasp);

                            int arma = 0;


                            Console.WriteLine("Insert one number (1-100)");
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (n != rasp)
                            {
                                Console.Clear();
                                Console.WriteLine("Insert one number (1-100)");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {

                                    Console.WriteLine("The number is correct");

                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n < rasp)
                                {

                                    Console.WriteLine("The number is bigger");


                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();

                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            System.Threading.Thread.Sleep(4000);
                            Environment.Exit(0);
                        }


                        else
                        {
                            Console.WriteLine("Your option is unviable");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }

                    }
                    Environment.Exit(0);
                }
                else if (c == 2) //game 2
                {
                    Console.WriteLine("Change your option: \n 1-Easy \n 2-Hard \n 3-Expert \n 0-Exit");
                    a = int.Parse(Console.ReadLine());
                    while (a != 0)
                    {
                        if (a == 1)
                        {
                            Console.WriteLine("Insert one number (1-20)");
                            b = int.Parse(Console.ReadLine());
                            while (b == b)
                            {

                                Console.WriteLine("Insert one number (1-20)");
                                b = int.Parse(Console.ReadLine());

                            }
                        }
                        else if (a == 2)
                        {

                        }
                        else if (a == 3)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Your option is unviable");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }

                    }
                }
                else if (c == 1) //game 3
                {
                    Console.WriteLine("Change your option: \n 1-Easy \n 2-Hard \n 3-Expert \n 0-Exit");
                    a = int.Parse(Console.ReadLine());
                    while (a != 0)
                    {
                        if (a == 1)
                        {
                            Random random = new Random();
                            int rasp = random.Next(1, 20);
                            int arma = 0;
                            Console.WriteLine("Insert one number (1-20).");
                            int n = int.Parse(Console.ReadLine());
                            arma++;


                            while (n != rasp)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());
                                Console.WriteLine(rasp);

                                if (n == rasp)
                                {
                                    Console.WriteLine(n);
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if ((rasp + 2) == n || (rasp - 2) == n || (rasp - 1) == n || (rasp + 1) == n)
                                {
                                    Console.WriteLine(rasp);
                                    Console.WriteLine("near");
                                    arma++;
                                }
                                else if ((rasp + 3) == n || (rasp + 4) == n || (rasp + 5) == n || (rasp - 3) == n || (rasp - 4) == n || (rasp - 5) == n)
                                {
                                    Console.WriteLine(rasp);
                                    Console.WriteLine("near / far");
                                    arma++;
                                }
                                else if ((rasp + 5) > n || (rasp - 5) < n)
                                {
                                    Console.WriteLine("far");
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }
                    
                        else if (a == 2)
                        {
                            Random random = new Random();
                            int rasp = random.Next(1, 20);
                            int arma = 0;
                            Console.WriteLine("Insert one number (1-20).");
                            int n = int.Parse(Console.ReadLine());
                            arma++;


                            while (n != rasp)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());
                                Console.WriteLine(rasp);

                                if (n == rasp)
                                {
                                    Console.WriteLine(n);
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if ((rasp + 2) == n || (rasp - 2) == n || (rasp - 1) == n || (rasp + 1) == n)
                                {
                                    Console.WriteLine(rasp);
                                    Console.WriteLine("near");
                                    arma++;
                                }
                                else if ((rasp + 3) == n || (rasp + 4) == n || (rasp + 5) == n || (rasp - 3) == n || (rasp - 4) == n || (rasp - 5) == n)
                                {
                                    Console.WriteLine(rasp);
                                    Console.WriteLine("near / far");
                                    arma++;
                                }
                                else if ((rasp + 5) > n || (rasp - 5) < n)
                                {
                                    Console.WriteLine("far");
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }

                    
                        else if (a == 3)
                        {
                            Random random = new Random();
                            int rasp = random.Next(1, 20);
                            int arma = 0;
                            Console.WriteLine("Insert one number (1-20).");
                            int n = int.Parse(Console.ReadLine());
                            arma++;


                            while (n != rasp)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());
                                Console.WriteLine(rasp);

                                if (n == rasp)
                                {
                                    Console.WriteLine(n);
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if ((rasp + 2) == n || (rasp - 2) == n || (rasp - 1) == n || (rasp + 1) == n)
                                {
                                    Console.WriteLine(rasp);
                                    Console.WriteLine("near");
                                    arma++;
                                }
                                else if ((rasp + 3) == n || (rasp + 4) == n || (rasp + 5) == n || (rasp - 3) == n || (rasp - 4) == n || (rasp - 5) == n)
                                {
                                    Console.WriteLine(rasp);
                                    Console.WriteLine("near / far");
                                    arma++;
                                }
                                else if ((rasp + 5) > n || (rasp - 5) < n)
                                {
                                    Console.WriteLine("far");
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }

            
                        else
                        {
                            Console.WriteLine("Your option is unviable");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }

                    }
                }


            }

        }
        private static void Muser()
        {
            int a, b, c;


            Console.WriteLine("Select one game:  \n 1-Generator Game \n 2- Generator Game with attemps \n 3- Special Generator \n 0-Exit");
            c = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            while (c != 0)
            {
                if (c == 1) //game 1
                {
                    Console.WriteLine("Change your option: \n 1-Easy \n 2-Hard \n 3-Expert \n 0-Exit");
                    a = int.Parse(Console.ReadLine());
                    while (a != 0)
                    {
                        if (a == 1) //requested level ; level easy
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Random random = new Random();
                            int rasp = random.Next(1, 20);
                            /*Console.WriteLine(rasp);*/

                            int arma = 0;


                            Console.WriteLine("Insert one number (1-20)");
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (n != rasp)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                }
                                else if (n < rasp)
                                {
                                    Console.WriteLine("The number is bigger");
                                    arma++;
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }
                        else if (a == 2) //system levels level hard
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Random random = new Random();
                            int rasp = random.Next(1, 50);
                            /*Console.WriteLine(rasp);*/

                            int arma = 0;


                            Console.WriteLine("Insert one number (1-50)");
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (n != rasp)
                            {
                                Console.Clear();
                                Console.WriteLine("Insert one number (1-50)");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {

                                    Console.WriteLine("The number is correct");

                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n < rasp)
                                {

                                    Console.WriteLine("The number is bigger");


                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();

                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            System.Threading.Thread.Sleep(4000);
                            Environment.Exit(0);
                        }

                        else if (a == 3) //system levels level expert
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Random random = new Random();
                            int rasp = random.Next(1, 100);
                            /*Console.WriteLine(rasp);*/

                            int arma = 0;


                            Console.WriteLine("Insert one number (1-100)");
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (n != rasp)
                            {
                                Console.Clear();
                                Console.WriteLine("Insert one number (1-100)");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {

                                    Console.WriteLine("The number is correct");

                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                }
                                else if (n < rasp)
                                {

                                    Console.WriteLine("The number is bigger");


                                    arma++;
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();

                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            System.Threading.Thread.Sleep(4000);
                            Environment.Exit(0);
                        }


                        else
                        {
                            Console.WriteLine("Your option is unviable");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }

                    }
                    Environment.Exit(0);
                }
                else if (c == 2) //game 2
                {
                    Console.WriteLine("Change your option: \n 1-Easy \n 2-Hard \n 3-Expert \n 0-Exit");
                    a = int.Parse(Console.ReadLine());
                    while (a != 0)
                    {
                        if (a == 1)
                        {

                            Random random = new Random();
                            int rasp = random.Next(1, 20);
                            int arma = 0;
                            Console.WriteLine("Insert one number (1-20). You have 3 attemps");
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (arma <= 2)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                }
                                else if (n < rasp)
                                {
                                    Console.WriteLine("The number is bigger");
                                    arma++;
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }
                        else if (a == 2)
                        {
                            Random random = new Random();
                            int rasp = random.Next(1, 50);
                            int arma = 0;
                            Console.WriteLine("Insert one number (1-50). You have 5 attemps"); //5 attemps
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (arma <= 4)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                }
                                else if (n < rasp)
                                {
                                    Console.WriteLine("The number is bigger");
                                    arma++;
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }
                        else if (a == 3)
                        {
                            Random random = new Random();
                            int rasp = random.Next(1, 100);
                            int arma = 0;
                            Console.WriteLine("Insert one number (1-100). You have 10 attemps"); // 10 attemps
                            int n = int.Parse(Console.ReadLine());
                            arma++;

                            while (arma <= 10)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());

                                if (n == rasp)
                                {
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if (n > rasp)
                                {
                                    Console.WriteLine("The number is smaller");
                                    arma++;
                                }
                                else if (n < rasp)
                                {
                                    Console.WriteLine("The number is bigger");
                                    arma++;
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Your option is unviable");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }

                    }
                }
                else if (c == 3) //game 3
                {
                    Console.WriteLine("Change your option: \n 1-Easy \n 2-Hard \n 3-Expert \n 0-Exit");
                    a = int.Parse(Console.ReadLine());
                    while (a != 0)
                    {
                        if (a == 1)
                        {
                            Random random = new Random();
                            int rasp = random.Next(1, 20);
                            int arma = 0;
                            Console.WriteLine("Insert one number (1-20).");
                            int n = int.Parse(Console.ReadLine());
                            arma++;


                            while (n != rasp)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());
                                

                                if (n == rasp)
                                {
                                    
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if ((rasp + 2) == n || (rasp - 2) == n || (rasp - 1) == n || (rasp + 1) == n)
                                {
                                    
                                    Console.WriteLine("near");
                                    arma++;
                                }
                                else if ((rasp + 3) == n || (rasp + 4) == n || (rasp + 5) == n || (rasp - 3) == n || (rasp -4) == n || (rasp -5) == n )
                                {
                                   
                                    Console.WriteLine("near / far");
                                    arma++;
                                }
                                else if ((rasp + 5) > n || (rasp - 5) < n)
                                {
                                    Console.WriteLine("far");
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }
                        else if (a == 2)
                        {
                            Random random = new Random();
                            int rasp = random.Next(1, 50);
                            int arma = 0;
                            Console.WriteLine("Insert a number (1-50).");
                            int n = int.Parse(Console.ReadLine());
                            arma++;


                            while (n != rasp)
                            {

                                Console.WriteLine("Insert a number");
                                n = int.Parse(Console.ReadLine());
                                

                                if (n == rasp)
                                {
                                    
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if ((rasp + 2) == n || (rasp - 2) == n || (rasp - 1) == n || (rasp + 1) == n)
                                {
                                    
                                    Console.WriteLine("near");
                                    arma++;
                                }
                                else if ((rasp + 3) == n || (rasp + 4) == n || (rasp + 5) == n || (rasp - 3) == n || (rasp - 4) == n || (rasp - 5) == n)
                                {
                                    
                                    Console.WriteLine("near / far");
                                    arma++;
                                }
                                else if ((rasp + 5) > n || (rasp - 5) < n)
                                {
                                    Console.WriteLine("far");
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }

                    
                        else if (a == 3)
                        {
                            Random random = new Random();
                            int rasp = random.Next(1, 100);
                            int arma = 0;
                            Console.WriteLine("Insert one number (1-100).");
                            int n = int.Parse(Console.ReadLine());
                            arma++;


                            while (n != rasp)
                            {

                                Console.WriteLine("Insert one number");
                                n = int.Parse(Console.ReadLine());
                                

                                if (n == rasp)
                                {
                                    Console.WriteLine(n);
                                    Console.WriteLine("The number is correct");
                                    arma++;
                                }
                                else if ((rasp + 2) == n || (rasp - 2) == n || (rasp - 1) == n || (rasp + 1) == n)
                                {
                                    
                                    Console.WriteLine("near");
                                    arma++;
                                }
                                else if ((rasp + 3) == n || (rasp + 4) == n || (rasp + 5) == n || (rasp - 3) == n || (rasp - 4) == n || (rasp - 5) == n)
                                {
                                    
                                    Console.WriteLine("near / far");
                                    arma++;
                                }
                                else if ((rasp + 5) > n || (rasp - 5) < n)
                                {
                                    Console.WriteLine("far");
                                }
                            }
                            Console.WriteLine("The number of attempts is " + arma);
                            Environment.Exit(0);
                        }

                    
                        else
                        {
                            Console.WriteLine("Your option is unviable");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }

                    }
                }


            }
            Environment.Exit(0);

        }

    }

}
