namespace gæt_en_farve_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String red = "rød";//1
            String blue = "blå";
            String yellow = "gul";
            String green = "grøn";
            String pink = "pink";
            Random r = new Random();
            int color = r.Next(1, 6);
            string selectedcolor = "";
            switch(color)
            {
                case 1:
                    selectedcolor = red;
                    break;
                case 2:
                    selectedcolor = blue;
                    break;
                case 3:
                    selectedcolor = yellow;
                    break;
                case 4:
                    selectedcolor = green;
                    break;
                case 5:
                    selectedcolor = pink;
                    break;

            }
            int attempt = 3;
            for (int i = 0; i<attempt; i++)
            {
                Console.WriteLine("hvilken farve gætter du på ?");
                Console.WriteLine("det rigtige farve var " + selectedcolor);
                string input = Console.ReadLine();
                if (input == selectedcolor)
                {
                    Console.WriteLine("Du vandt");
                    i = attempt + 1;
                } 
                else
                {
                    Console.WriteLine("Du tabte");
                    if (i == attempt - 1)
                    {
                        Console.WriteLine("det rigtige farve var " + selectedcolor);
                    }
                }

            }

        }
    }
}
