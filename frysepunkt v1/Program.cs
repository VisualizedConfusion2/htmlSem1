namespace frysepunkt_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("hvad er temperaturen"); string userinput = Console.ReadLine(); float userinputFLT = float.Parse(userinput); float temp = 0;
                if (userinputFLT == temp)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("temperaturen er ideel");
                }
                else if (userinputFLT > temp)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("temperaturen er for høj");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("temperaturen er god");
                }
            }
            

        }
    }
}
