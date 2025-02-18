namespace fødselsdagen_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indsæt fødselsdag på denne måde dd-MM-yyyy Eksempel: 01012001"); //printer intruktioner
            DateTime birthday = new DateTime(0001,01,01,0,0,0);//definere birthday til år 0001 måned 01 dag 01 time 0 minut 0 sekund 0
            birthday = DateTime.ParseExact(Console.ReadLine(), "ddMMyyyy", null); //læser datoen bruger indskriver
            TimeSpan difference = DateTime.Now - birthday; //regner differentialet
            int years = (int)Math.Floor(difference.TotalDays / 365.2425); //giver antal år bruger er, sikre 0 decimal tal
            int days = (int)Math.Floor(difference.TotalDays - (years * 365.2425)); //giver antal dage brugeren er efter at have trukket årene fra og sikre 0 decimal tal
            Console.WriteLine($"du er {years} år og {days} dage gammel"); //giver brugeren sin alder
        }
    }
}
