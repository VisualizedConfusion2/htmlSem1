namespace morsekode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Dictionary<char, string> morseAlphabet = new Dictionary<char, string>
            {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
            {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
            {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
            {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
            {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
            {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
            {'9', "----."}, {' ', "/"}
            };

                Console.Write("Indtast en tekst: ");
                string input = Console.ReadLine().ToUpper();

                string morseCode = "";

                foreach (char c in input)
                {
                    if (morseAlphabet.ContainsKey(c))
                    {
                        morseCode += morseAlphabet[c] + " ";
                    }
                }

                Console.WriteLine("Morsekode: " + morseCode);
            }
        }
    }
}
