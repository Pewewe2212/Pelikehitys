namespace Ruudukko_koordinaatisto
{
    internal class Program
    {
        struct Coordinates
        {
            public int X;
            public int Y;
        }

        public class Cords()
        {
            Coordinates Coordinates1;

            public void Loop()
            {
                Coordinates1 = new Coordinates();

                Coordinates1.X = 0;
                Coordinates1.Y = 0;

                int CX = Coordinates1.X;
                int CY = Coordinates1.Y;

                int x = 0;
                int y = 0;

                int i = 0;

                while (true)
                {
                    Console.WriteLine("Give 2 coordinates (ex. 0,0 or 1,0)");
                    string answer = Console.ReadLine();
                    string[] cords = answer.Split(",");
                    i = 0;

                    try
                    {
                        x = (int)Int128.Parse(cords[0]);
                    }
                    catch
                    {
                        Console.WriteLine("Et antanut X coordinaattia");
                        i = 1;
                    }
                    try
                    {
                        y = (int)Int128.Parse(cords[1]);
                    }
                    catch
                    {
                        Console.WriteLine("Et antanut Y coordinaattia");
                        i = 1;
                    }

                    if (CX == x && CY == y && i == 0)
                    {
                        Console.WriteLine($"Annettu koordinaatti {x},{y} on koodinaatissa {CX},{CY}");
                    }
                    else if (CX == x + 1 || CX == x - 1 || CY == y - 1 || CY == y + 1 && i == 0)
                    {
                        Console.WriteLine($"Annettu koordinaatti {x},{y} on koodinaatin {CX},{CY} vieressä");
                    }
                    else if (i == 0)
                    {
                        Console.WriteLine($"Annettu koordinaatti {x},{y} ei ole koodinaatin {CX},{CY} vieressä");
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            Cords cord = new Cords();
            cord.Loop();
        }
    }
}
