namespace Temp_beregner_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Beregn Celcius til anden temp enhed");
            double celcius = double.Parse(Console.ReadLine());
            double andentemp = 0.8;

            Console.WriteLine("Celcius= " + (celcius * andentemp) + " anden temp enhed");
        }
    }
}
