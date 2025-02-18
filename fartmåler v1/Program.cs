namespace fartmåler_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indsæt distance i km og tid i minutter");
            double km = double.Parse(Console.ReadLine());
            double tid = double.Parse(Console.ReadLine());
            double avgSpeed = km / (tid / 60);
            Console.WriteLine($"Bilisten kørte  {avgSpeed} km/t");
        }
    }
}
