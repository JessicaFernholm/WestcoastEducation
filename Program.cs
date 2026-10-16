namespace WestcoastEducation;

class Program
{
    static void Main()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Välkommen till Westcoast Education!");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Studenter tryck S");
        Console.WriteLine("För att se alla kurser tryck K");
        Console.WriteLine("Lärare tryck L");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("För utbildningsledare tryck U");
        Console.WriteLine("För administratörer tryck A");
        Console.WriteLine("För att avsluta tryck Q");
        Console.WriteLine(" ");
        
        App();
    }

    static void App()
    {
        try
        {
            while (true)
            {
                var val = Console.ReadLine()?.Trim().ToUpper();

                if (string.IsNullOrWhiteSpace(val) || val == "Q")
                {
                    Environment.Exit(0);
                }

              switch (val)
                {
                    case "S":
                        new Student().Show();
                        break;
                    case "K":
                        new Course().Show();
                        break;
                    case "L":
                        new Teacher().Show();
                        break;
                    case "U":
                        new EduManager().Show();
                        break;
                    case "A":
                        new Admin().Show();
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;

                }
            }
        }
                finally
        {
            Console.WriteLine("Tack för att du använde vår applikation!");
        }
    }
}
            
         


