namespace Skridttæller_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skridt til meter converter");
            int skridt = int.Parse(Console.ReadLine());
            Console.WriteLine(skridt * 0.762 + ("m"));
            Console.WriteLine(skridt * 0.762 * 0.001 + ("km"));
            Console.WriteLine(skridt * 0.762 / 1000 + ("km"));
        }
    }
}
