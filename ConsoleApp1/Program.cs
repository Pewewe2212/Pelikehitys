using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        private enum Head : byte
        {
            puu,
            teräs,
            timantti,
        }

        private enum Tail : byte
        {
            lehti,
            kanansulka,
            kotkansulka,
        }


        internal class Arrow()
        {
            // gets head
            public byte headPuu
            {
                get { return (byte)Head.puu; }
            }
            public byte headTeräs
            {
                get { return (byte)Head.teräs; }
            }
            public byte headTimantti
            {
                get { return (byte)Head.timantti; }
            }

            public byte tailLehti
            {
                get { return (byte)Tail.lehti; }
            }
            public byte tailKana
            {
                get { return (byte)Tail.kanansulka; }
            }
            public byte tailKotka
            {
                get { return (byte)Tail.kotkansulka; }
            }


        }



        static void Main(string[] args)
        {
            float total = 0;

            Console.WriteLine("Minkälainen kärki? (puu, teräs, timantti)");
            string tipChange = Console.ReadLine();
            Head pää = Enum.Parse<Head>(tipChange.ToLower());

            Console.WriteLine("Minkälaiset sulat? (lehti, kanansulka, kotkansulka)");
            string tailChange = Console.ReadLine();
            Tail tail = Enum.Parse<Tail>(tailChange.ToLower());

            int Price(Head head)
            {
                return head switch
                {
                    Head.puu => 3,
                    Head.teräs => 5,
                    Head.timantti => 50,
                    _ => 0,
                };
            }

            int Price2(Tail tail)
            {
                return tail switch
                {
                    Tail.lehti => 0,
                    Tail.kanansulka => 1,
                    Tail.kotkansulka => 5,
                    _ => 0,
                };
            }

            total += Price(pää);
            total += Price2(tail);

            while (true)
            {
                Console.WriteLine("Kuinka pitkä varsi? (60-100)");
                float price = Single.Parse(Console.ReadLine());
                if (price < 101 && price > 59)
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