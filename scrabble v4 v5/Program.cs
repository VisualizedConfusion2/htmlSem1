namespace scrabble_v4_v5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*************************************************************************
            *  Opgave:  Scrabble Score Calculator
            *  By:      THLJB
            *  Date:    2025-02-15
            *  Version: 01.02.05
            **************************************************************************/

            // define variables 
            string scrabbleWord = ""; // word input from user - base for the calculation
            int i = 0; // counter for looping letters in the word 
            bool legalWord = true; // set to false if the input in scrabbleWord contains space, numer or special characters
            char currentLetter; // the current letter from the word
            string currentLetterstring; // the current letter from the word - as string for loop 2
            int score = 0; // the calculated score
            string points1 = "AEIOULNSTR";
            string points2 = "DG";
            string points3 = "BCMP";
            string points4 = "FHVWY";
            string points5 = "K";
            string points8 = "JX";
            string points10 = "QZ";



            // Get user input - and handle null input (test null input : ctl+Z Enter)
            Console.WriteLine("Enter your Scrabble word (no numbers, spaces or special characters)):");
            string? line = Console.ReadLine();
            if (line != null)
            {
                scrabbleWord = line;
            }
            else
            {
                legalWord = false;
                Console.WriteLine("** null input **");
            }

            // Change to upper case and remove blanks 
            scrabbleWord = scrabbleWord.ToUpper().Trim();

            //start with first letter
            i = 0;


            //loop all letters in word
            while ((i < scrabbleWord.Length) && (legalWord))
            {
                currentLetter = scrabbleWord[i];
                switch (currentLetter)
                {
                    case char a when points1.Contains(a):
                        score = score + 1;
                        break;
                    case char a when points2.Contains(a):
                        score = score + 2;
                        break;
                    case char a when points3.Contains(a):
                        score = score + 3;
                        break;
                    case char a when points4.Contains(a):
                        score = score + 4;
                        break;
                    case char a when points5.Contains(a):
                        score = score + 5;
                        break;
                    case char a when points8.Contains(a):
                        score = score + 8;
                        break;
                    case char a when points10.Contains(a):
                        score = score + 10;
                        break;
                    default:
                        legalWord = false;
                        break;
                }
                i++;
            }

            Console.WriteLine("Your Scrabble word is: " + scrabbleWord);
            if (legalWord)
            {
                Console.WriteLine("Your points are: {0}", score);
            }
            else
            {
                Console.WriteLine("Your get NO points - your word is not a legal word");
            }


            /***********************************************************
            * for loop version - with Substring / switch on a string
            ************************************************************/

            // the for loop:  - for  (statement 1; statement 2; statement 3) {}
            // Statement 1 is executed (one time) before the execution of the code block.
            // Statement 2 defines the condition for executing the code block.
            // Statement 3 is executed (every time) after the code block has been executed.

            // reset score
            score = 0;

            //loop all letters in word
            for (i = 0; ((i < scrabbleWord.Length) && (legalWord)); i++)
            {
                currentLetterstring = scrabbleWord.Substring(i, 1);
                switch (currentLetterstring)
                {
                    case string a when points1.Contains(a):
                        score += 1;
                        break;
                    case string a when points2.Contains(a):
                        score += 2;
                        break;
                    case string a when points3.Contains(a):
                        score += 3;
                        break;
                    case string a when points4.Contains(a):
                        score += 4;
                        break;
                    case string a when points5.Contains(a):
                        score += 5;
                        break;
                    case string a when points8.Contains(a):
                        score += 8;
                        break;
                    case string a when points10.Contains(a):
                        score += 10;
                        break;
                    default:
                        legalWord = false;
                        break;
                }
            }

            Console.WriteLine("** for loop version **");
            Console.WriteLine("Your Scrabble word is: " + scrabbleWord);
            if (legalWord)
            {
                Console.WriteLine("Your points are: {0}", score);
            }
            else
            {
                Console.WriteLine("Your get NO points - your word is not a legal word");
            }


        }
    }
}
