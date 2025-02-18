﻿using System.ComponentModel.Design;

namespace balls_and_cups_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Vælg, Hvilket bæger du tror der har bolden i");
                Random r = new Random();
                int cup = r.Next(1, 3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("#       ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("#       ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("#       ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1       ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("2       ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3       ");
                string userchoice = Console.ReadLine();
                float userchoiceFLT = float.Parse(userchoice);
                if (userchoiceFLT == cup)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du vandt");
                }
                else if (userchoiceFLT != cup)
                {
                    Console.WriteLine("Du tabte");
                }


                if (cup == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("#       ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("#       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("#       ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("O       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X       ");
                }
                else if (cup == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("#       ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("#       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("#       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X       ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("O       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X       ");
                }
                else if (cup == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("#       ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("#       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("#       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X       ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("X       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O       ");
                }
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }
}
