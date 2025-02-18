using System.Diagnostics.Metrics;
using static System.Formats.Asn1.AsnWriter;

namespace scrabble_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast en tekst: ");
                string userinput = Console.ReadLine().ToUpper(); // reads user input
                char[] sentence = userinput.ToCharArray();

                int point = 0;

                foreach (char letter in sentence)
                {
                    switch (letter)
                    {
                        case 'E':
                        case 'A':
                        case 'N':
                        case 'R':
                            point += 1;
                            break;
                        case 'D':
                        case 'L':
                        case 'O':
                        case 'S':
                        case 'T':
                            point += 2;
                            break;
                        case 'B':
                        case 'I':
                        case 'K':
                        case 'F':
                        case 'G':
                        case 'M':
                        case 'U':
                        case 'V':
                            point += 3;
                            break;
                        case 'H':
                        case 'J':
                        case 'P':
                        case 'Y':
                        case 'Æ':
                        case 'Ø':
                        case 'Å':
                            point += 4;
                            break;
                        case 'C':
                        case 'X':
                        case 'Z':
                        case 'W':
                        case 'Q':
                            point += 8;
                            break;
                        default:
                            break; // Hvis der er mellemrum eller tegn, ignorer dem
                    }



                }
                Console.WriteLine($"her er din score {point}");
            }
            
        }
    }
}
