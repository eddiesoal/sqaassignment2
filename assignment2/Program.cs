using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
        }

        public void Go()
        {
            try
            {
                // Menu
                int menuOption = 0;
                do
                {
                    // receive the user option
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("================================");
                        Console.WriteLine("Triangle Solver Program");
                        Console.WriteLine(" 1. Enter triangle dimensions");
                        Console.WriteLine(" 2. Exit");
                        Console.Write("Please, choose an option: ");
                    } while (!int.TryParse(Console.ReadLine(), out menuOption) || menuOption < -1);

                    // act based on the user option
                    switch (menuOption)
                    {
                        case 1:
                            int a;
                            int b;
                            int c;

                            do
                            {
                                Console.Write("Please, inform triangle's side #1: ");

                            } while (!int.TryParse(Console.ReadLine(), out a) || a < 0);

                            do
                            {
                                Console.Write("Please, inform triangle's side #2: ");

                            } while (!int.TryParse(Console.ReadLine(), out b) || b < 0);

                            do
                            {
                                Console.Write("Please, inform triangle's side #3: ");

                            } while (!int.TryParse(Console.ReadLine(), out c) || c < 0);

                            string response = TriangleSolver.Analyze(a, b, c);
                            if (response != "NotATriangle")
                            {
                                Console.WriteLine("The triangle is {0}.", response);
                            }
                            else
                            {
                                Console.WriteLine("Sorry, it's not a triangle.");
                            }

                            MessageEndMenuItem();
                            break;
                        case 2:
                            break;
                    }
                } while (menuOption != 2);
                Console.WriteLine("Thank you!");

                void MessageEndMenuItem()
                {
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
