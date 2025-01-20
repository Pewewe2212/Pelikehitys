namespace Ruoka_annos_generaattori
{
    internal class Program
    {
        public class Food
        {
            public enum Main { Nautaa, Kanaa, Kasviksia }
            public enum Side { Perunaa, Riisiä, Pastaa }
            public enum Sauce { Curry, Pippuri, Hapanimelä, Chili }
        }

        static void Main(string[] args)
        {
            Food food = new Food();
            string choice;
            string Main;
            string Side;
            string Sauce;

            while (true)
            {
                Console.WriteLine("Pääraaka-aine (Nautaa, Kanaa, Kasviksia): ");
                choice = Console.ReadLine();
                if (choice.ToLower() == "Nautaa".ToLower())
                {
                    Main = "Nautaa";
                    break;
                }
                else if (choice.ToLower() == "Kanaa".ToLower())
                {
                    Main = "Kanaa";
                    break;
                }
                else if (choice.ToLower() == "Kasviksia".ToLower())
                {
                    Main = "Kasviksia";
                    break;
                }
                else
                {
                    Console.WriteLine("En tunnistanut valintaasi");
                }
            }

            while (true)
            {
                Console.WriteLine("Lisukkeet (Perunaa, Riisiä, Pastaa): ");
                choice = Console.ReadLine();
                if (choice.ToLower() == "Perunaa".ToLower())
                {
                    Side = "Perunaa";
                    break;
                }
                else if (choice.ToLower() == "Riisiä".ToLower())
                {
                    Side = "Riisiä";
                    break;
                }
                else if (choice.ToLower() == "Pastaa".ToLower())
                {
                    Side = "Pastaa";
                    break;
                }
                else
                {
                    Console.WriteLine("En tunnistanut valintaasi");
                }
            }

            while (true)
            {
                Console.WriteLine("Kastike (Curry, Pippuri, Hapanimelä, Chili): ");
                choice = Console.ReadLine();
                if (choice.ToLower() == "Curry".ToLower())
                {
                    Sauce = "Curry";
                    break;
                }
                else if (choice.ToLower() == "Pippuri".ToLower())
                {
                    Sauce = "Pippuri";
                    break;
                }
                else if (choice.ToLower() == "Hapanimelä".ToLower())
                {
                    Sauce = "Hapanimelä";
                    break;
                }
                else if (choice.ToLower() == "Chili".ToLower())
                {
                    Sauce = "Chili";
                    break;
                }
                else
                {
                    Console.WriteLine("En tunnistanut valintaasi");
                }
            }

            Console.WriteLine($"{Main} ja {Side} {Sauce}-kastikkeella");

            Console.WriteLine("Custom order");

            List<string> list = new List<string>();

            Console.WriteLine("Pääraaka-aine: ");
            choice = Console.ReadLine();
            list.Add(choice);

            Console.WriteLine("Sivukkeet: ");
            choice = Console.ReadLine();
            list.Add(choice);

            Console.WriteLine("Kastike: ");
            choice = Console.ReadLine();
            list.Add(choice);

            Console.WriteLine($"{list[0]} ja {list[1]} {list[2]}-kastikkeella");
        }
    }
}
