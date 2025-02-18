using System;
using System.Threading;

namespace spinnig_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleSpiner spin = new ConsoleSpiner();
            Console.Write("Working.... ");
            while (true)
            {
                spin.Turn();
                Thread.Sleep(200); // Slow down the loop to make it visible
            }
        }
    }

    public class ConsoleSpiner
    {
        int counter;
        int int3 = 3;  // Declare int3 here so it's accessible in Turn()

        public ConsoleSpiner()
        {
            counter = 0;
        }

        public void Turn()
        {
            counter++;

            string result = (int3 + int3).ToString(); // Calculate 3+3 (which is 6) and convert to string

            switch (counter % 4)
            {
                case 0: Console.Write($"\b{result}-"); break;
                case 1: Console.Write($"\b{result}\\"); break;
                case 2: Console.Write($"\b{result}|"); break;
                case 3: Console.Write($"\b{result}/"); break;
            }

            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}
