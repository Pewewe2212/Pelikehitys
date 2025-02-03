namespace Robotti
{
    internal class Program
    {
        public interface IRobottiKäsky
        {
            public void Suorita(Robotti robotti);
        }

        public class Käynnistä : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                robotti.OnKäynnissä = true;
            }
        }

        public class Sammuta : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                robotti.OnKäynnissä = false;
            }
        }

        public class YlösKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    robotti.Y += 1;

                }
            }
        }
        public class AlasKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    robotti.Y -= 1;

                }
            }
        }
        public class VasenKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    robotti.X -= 1;

                }
            }
        }
        public class OikeaKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    robotti.X += 1;

                }
            }
        }

        public class Robotti
        {
            public int X { get; set; }
            public int Y { get; set; }
            public bool OnKäynnissä { get; set; }
            public IRobottiKäsky?[] Käskyt { get; } = new IRobottiKäsky?[3];

            public void Suorita()
            {
                foreach (IRobottiKäsky? käsky in Käskyt)
                {
                    käsky?.Suorita(this);
                    Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
                }
            }
        }




        static void Main(string[] args)
        {
            Robotti robotti = new Robotti();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Anna komento robotille. Vaihtoehdot: Käynnistä, Sammuta, Ylös, Alas, Oikea, Vasen");

                string answer = Console.ReadLine();

                switch (answer.ToLower())
                {
                    case "käynnistä":
                        {
                            robotti.Käskyt[i] = new Käynnistä();
                            break;
                        }
                    case "sammuta":
                        {
                            robotti.Käskyt[i] = new Sammuta();
                            break;
                        }
                    case "ylös":
                        {
                            robotti.Käskyt[i] = new YlösKäsky();
                            break;
                        }
                    case "alas":
                        {
                            robotti.Käskyt[i] = new AlasKäsky();
                            break;
                        }
                    case "vasen":
                        {
                            robotti.Käskyt[i] = new VasenKäsky();
                            break;
                        }
                    case "oikea":
                        {
                            robotti.Käskyt[i] = new OikeaKäsky();
                            break;
                        }
                    _:
                        {
                            break;
                        }
                }
            }
            robotti.Suorita();
        }
    }
}
