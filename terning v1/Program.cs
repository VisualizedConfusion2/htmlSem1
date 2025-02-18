namespace terning_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("slå en seks sidet terning");
            Random random = new Random();
            int dice = random.Next(1, 7);
            if (dice == 1)
            {
                Console.WriteLine("Du slog en etter");
            }
            else if (dice == 2)
            {
                Console.WriteLine("Du slog en to'er");
            }
            else if (dice == 3)
            {
                Console.WriteLine("Du slog en treer");
            }
            else if (dice == 4)
            {
                Console.WriteLine("Du slog fire");
            }
            else if (dice == 1)
            {
                Console.WriteLine("Du slog en femmer");
            }
            else
            {
                Console.WriteLine("Du slog en seks'er");
            }
        }
    }
}
