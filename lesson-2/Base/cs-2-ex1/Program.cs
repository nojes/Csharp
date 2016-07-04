﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_2_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            do {
                //CheckTriangle();
                //CheckSeason();
                RandPrint();
                PythagoreanTable();
            } while (true);
            
        }

        static void CheckTriangle()
        {
            double a, b, c;

            try
            {
                Console.Write(" a -> ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write(" b -> ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write(" c -> ");
                c = Convert.ToDouble(Console.ReadLine());

                if (a < (b + c) && b < (b + c) && c < (a + b))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("[INFO]: It's triangle. \n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[INFO]: It's not triangle. \n");
                }
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: {0} \n", err.Message);
            }
            Console.ResetColor();
        }

        static void CheckSeason()
        {
            int month;

            try
            {
                Console.Write(" Number of month -> ");
                month = Convert.ToInt32(Console.ReadLine());

                switch(month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("[INFO]: It's Winter. \n");
                        break;

                    case 3:
                    case 4:
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("[INFO]: It's Spring. \n");
                        break;

                    case 6:
                    case 7:
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[INFO]: It's Summer. \n");
                        break;

                    case 9:
                    case 10:
                    case 11:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("[INFO]: It's Autumn. \n");
                        break;
                }
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: {0} \n", err.Message);
            }
            Console.ResetColor();
        }

        static void RandPrint()
        {
            Random r = new Random();
            
            int num;
            int quantity;

            try {
                Console.Write(" Put quantity -> ");
                quantity = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < quantity; i++)
                {
                    num = r.Next(0, 100);
                    Console.WriteLine("[{0}] => {1}", i, num);
                }
                Console.WriteLine();
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: {0} \n", err.Message);
            }
            Console.ResetColor();
        }

        static void PythagoreanTable()
        {
            Console.WriteLine("Press any key to print Pythagorean Table ...");
            Console.ReadLine();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(" {0, 4}", (i * j));
                }
                Console.WriteLine("\n");
            }
        }
    }
}
