using System.Media;

namespace dyresymfonien_v2
{
    internal class Program

    {
        static void Main(string[] args)

        {
            SoundPlayer player = new SoundPlayer();
            // Create a SoundPlayer instance to play sounds
            // Variable for the user's guess
            string userGuess = "";
            // Randomly select an animal
            Random random = new Random();
            int chosenAnimalIndex = random.Next(1, 6);

            // Randomlyselects a number between 1 and 5
            // Do-while loop to ask until the user guesses correctly
            do
            {
                // Ask the user which animal makes this sound
                Console.WriteLine("Hvilket dyr laver denne lyd?");
                Console.WriteLine("Muligheder: hund, kat, ko, fugl, hest");

                // Read the user's guess
                userGuess = Console.ReadLine().ToLower();
                // Play the appropriate sound depending on the animal
                if (chosenAnimalIndex == 1) // Dog
                {
                    player.SoundLocation = @"C:\path\hund.wav";
                    // Set the path to the dog sound file
                    player.Play(); // Play the sound
                    if (userGuess == "hund")
                    {
                        Console.WriteLine("Tillykke! Du gættede rigtigt. Dyret var en hund.");
                    }
                    else
                    {
                        Console.WriteLine("Forkert gæt. Prøv igen.");
                    }
                }
                else if (chosenAnimalIndex == 2) // Cat
                {
                    player.SoundLocation = @"C:\path\kat.wav";
                    // Set the path to the cat sound file
                    player.Play(); // Play the sound
                    if (userGuess == "kat")
                    {
                        Console.WriteLine("Tillykke! Du gættede rigtigt. Dyret var en kat.");
                    }
                    else
                    {
                        Console.WriteLine("Forkert gæt. Prøv igen.");
                    }
                }
            } while (userGuess != "hund" && userGuess != "kat");
            // Continue until the user guesses correctly

        }
    }
}
