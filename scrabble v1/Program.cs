using System.Media;

namespace scrabble_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definer bogstavgrupper og deres tilhørende point
            string[] array1 = { "E", "A", "N", "R" };
            string[] array2 = { "D", "L", "O", "S", "T" };
            string[] array3 = { "B", "I", "K", "F", "G", "M", "U", "V" };
            string[] array4 = { "H", "J", "P", "Y", "Æ", "Ø", "Å" };
            string[] array5 = { "C", "X", "Z", "W", "Q" };

            Console.Write("Indtast et ord: ");
            string input = Console.ReadLine().ToUpper(); // Læs input og konverter til store bogstaver
            int score = 0;

            // Beregn score for hvert bogstav i ordet
            foreach (char c in input)
            {
                string letter = c.ToString();
                if (Array.Exists(array1, element => element == letter))
                    score += 1;
                else if (Array.Exists(array2, element => element == letter))
                    score += 2;
                else if (Array.Exists(array3, element => element == letter))
                    score += 3;
                else if (Array.Exists(array4, element => element == letter))
                    score += 4;
                else if (Array.Exists(array5, element => element == letter))
                    score += 8;
            }

            Console.WriteLine($"Ordet '{input}' giver {score} point.");



        }
    }
}
