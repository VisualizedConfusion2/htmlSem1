namespace bmi_maskine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv din vægt i kg her");
            string weight = Console.ReadLine(); //input in kg
            float weightFLT = float.Parse(weight); //converts to comma
            Console.WriteLine("skriv din højde cm");
            string height = Console.ReadLine(); //input in cm
            float heightFLT = float.Parse(height); //converts to comma
            double bmi = weightFLT / ((heightFLT / 100.0) * (heightFLT / 100.0));
            Console.WriteLine($"din bmi er {bmi}");

            if (bmi > 16)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("u dead?");
            }
            else if ((bmi >= 16) && (bmi < 18.50))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("du er undervægtig");
            }
            else if ((bmi >= 18.50) && (bmi < 24))
                    {
                Console.WriteLine("du er nomal vægtig");
                    }
            else if ((bmi >= 24) && (bmi < 30))
                    {
                Console.WriteLine("du er overvægtig");
                    }
            else
            {
                Console.WriteLine("du er meget overvægtig");
            }
        }
    }
}
