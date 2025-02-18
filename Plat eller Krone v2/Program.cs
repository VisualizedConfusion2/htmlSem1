using System.Xml.Serialization;

namespace Plat_eller_Krone_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // changes text color to cyan
                Random random = new Random(); // defines Random
                int coinResult = random.Next(0, 2);  // 0 or 1
                string coinResultSTR = (coinResult == 0) ? "plat" : "krone"; //converts 0 and 1 to plat and krone
                Console.WriteLine("plat eller krone"); // prints inital line
                string datacoin = Console.ReadLine(); //checks what has been quessed
                if (datacoin == coinResultSTR) // if statement for if user guess is correct
                {
                    Console.WriteLine("DU VANDT!"); //prints if user quess is correct
                }
                else if (datacoin != coinResultSTR) // else if statement for if user guess is correct
                {
                    Console.WriteLine("DU TABTE!"); //prints if user quess is incorrect
                }
            
            }
        }
    }
}
