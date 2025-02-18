namespace Juleaften_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indsæt dagens dato på denne måde dd-MM-yyyy Eksempel: 01012001"); //printer intruktioner
            DateTime birthday = new DateTime(0001, 01, 01, 0, 0, 0);//definere birthday til år 0001 måned 01 dag 01 time 0 minut 0 sekund 0
            birthday = DateTime.ParseExact(Console.ReadLine(), "ddMMyyyy", null); //læser datoen bruger indskriver
            DateTime juleaften = new DateTime(2025, 12, 24);
            TimeSpan difference = juleaften - birthday; //regner differentialet
            int years = (int)Math.Floor(difference.TotalDays / 365.2425); //giver antal år bruger er, sikre 0 decimal tal
            int days = (int)Math.Floor(difference.TotalDays - (years * 365.2425)); //giver antal dage brugeren er efter at have trukket årene fra og sikre 0 decimal tal
            Console.WriteLine($"jule aften 2025 er om {years} år og {days} dage"); //giver brugeren sin alder
        }
    }
}
