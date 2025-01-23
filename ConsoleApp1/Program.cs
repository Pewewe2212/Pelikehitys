namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float total = 0;
            List<float> head = new List<float>();
            head.Add(3);
            head.Add(5);
            head.Add(50);

            List<float> feather = new List<float>();
            feather.Add(0);
            feather.Add(1);
            feather.Add(5);

            while (true)
            {
                Console.WriteLine("Minkälainen kärki? (puu, teräs, timantti)");
                string change = Console.ReadLine();
                if (change.ToLower() == "puu")
                {
                    total += head[0];
                    break;
                }
                if (change.ToLower() == "teräs")
                {
                    total += head[1];
                    break;
                }
                if (change.ToLower() == "timantti")
                {
                    total += head[2];
                    break;
                }
                else
                {
                    Console.WriteLine("Did not understand");
                }

            }

            while (true)
            {
                Console.WriteLine("Minkälaiset sulat? (lehti, kanansulka, kotkansulka)");
                string change = Console.ReadLine();
                if (change.ToLower() == "lehti")
                {
                    total += feather[0];
                    break;
                }
                if (change.ToLower() == "kanansulka")
                {
                    total += feather[1];
                    break;
                }
                if (change.ToLower() == "kotkansulka")
                {
                    total += feather[2];
                    break;
                }
                else
                {
                    Console.WriteLine("Did not understand");
                }
            }

            while (true)
            {
                Console.WriteLine("Kuinka pitkä varsi? (60-100)");
                float price = Single.Parse(Console.ReadLine());
                if (price < 101 && price >59)
                {
                    total += price * 0.05f;
                    break;
                }
                else
                {
                    Console.WriteLine("Did not understand");
                }
            }

            Console.WriteLine($"Nuolen hinta on {total}");

            

        }
    }
}
