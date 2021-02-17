namespace ENCRYPTOR.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.Write("*** ENCRYPTOR.exe®﻿");
                Console.Write("***");
                Console.WriteLine();
                Console.WriteLine("powered by: DamianK Inc");
                Thread.Sleep(4000);
                Console.Clear();
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                //Console.Beep(750, 500);
                //Thread.Sleep(50);
                //Console.Beep(750, 500);
                Console.WriteLine("DO YOU WANT TO PROCEED?(Y/N)");
                string user1 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            while (true)
            { 
                if (user1 == "Y" || user1 == "y")
                {
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.Write("do you want to");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(" encrypt");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(" or to ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("un-encrypt?(E/U)");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();
                    string user2 = Console.ReadLine();
                    if (user2 == "E" || user2 == "e")

                    {
                        Console.Clear();
                        Thread.Sleep(1000);
                        Console.WriteLine("write the message you want to encrypt");
                        string message = Console.ReadLine();
                        char[] digits = message.ToCharArray();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;


                        for (int i = 0; i < digits.Length; i++)
                        {
                            int number = digits[i];
                            number = number + 7;

                            digits[i] = (char)number;
                            Thread.Sleep(1000);
                            Console.Write(digits[i]);


                        }
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine();
                        Console.ReadKey();
                    }

                    else if (user2 == "U" || user2 == "u")
                    {

                        Console.Clear();
                        Thread.Sleep(1000);

                        Console.WriteLine("write the message you want to unencrypt");
                        string message = Console.ReadLine();
                        char[] digits = message.ToCharArray();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        for (int i = 0; i < digits.Length; i++)
                        {
                            int number = digits[i];
                            number = number - 7;

                            digits[i] = (char)number;
                            Thread.Sleep(1000);
                            Console.Write(digits[i]);


                        }
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine();
                        Console.ReadKey();


                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        Console.WriteLine("WRONG INPUTS.");
                        Thread.Sleep(1000);
                        Console.WriteLine("PLS TRY AGAIN.");
                        Thread.Sleep(5000);
                        Environment.Exit(0);
                        Console.ReadKey();

                    }



                }


                else if (user1 == "N" || user1 == "n")
                {
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("YOU HAVE DECIDED TO EXIT THE APK");
                    Console.Beep(450, 1000);
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    Console.ReadKey();
                }

                else
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("WRONG INPUTS.");
                    Thread.Sleep(1000);
                    Console.WriteLine("PLS TRY AGAIN.");
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                    Console.ReadKey();

                }

                Console.ReadKey();



            }

        }




    }
}
