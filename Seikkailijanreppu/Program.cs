namespace Seikkailijanreppu
{
    internal class Program
    {
        public class Stuff
        {
            protected float weight;
            protected float volume;
            public virtual float Weight()
            {
                return weight;
            }
            public virtual float Volume()
            {
                return volume;
            }
        }

        public class Arrow : Stuff
        {
            public override float Weight()
            {
                weight = 0.1f;
                return weight;
            }
            public override float Volume()
            {
                volume = 0.05f;
                return volume;
            }
        }

        public class Bow : Stuff
        {
            public override float Weight()
            {
                weight = 1;
                return weight;
            }
            public override float Volume()
            {
                volume = 4;
                return volume;
            }
        }

        public class Rope : Stuff
        {
            public override float Weight()
            {
                weight = 1;
                return weight;
            }
            public override float Volume()
            {
                volume = 1.5f;
                return volume;
            }
        }

        public class Water : Stuff
        {
            public override float Weight()
            {
                weight = 2;
                return weight;
            }
            public override float Volume()
            {
                volume = 2;
                return volume;
            }
        }

        public class Food : Stuff
        {
            public override float Weight()
            {
                weight = 1;
                return weight;
            }
            public override float Volume()
            {
                volume = 0.5f;
                return volume;
            }
        }

        public class Sword : Stuff
        {
            public override float Weight()
            {
                weight = 5;
                return weight;
            }
            public override float Volume()
            {
                volume = 3;
                return volume;
            }
        }

        public class Backpack()
        {
            public int maxItems = 10;
            public int currentItems = 0;
            public float maxWeight = 30;
            public float currentWeight = 0;
            public float maxVolume = 20;
            public float currentVolume = 0;

            public bool Lisää(Stuff stuff)
            {
                if (currentWeight + stuff.Weight() > maxWeight)
                {
                    Console.WriteLine("Could not fit item in backpack");
                    return false;
                }
                else if (currentVolume + stuff.Volume() > maxVolume)
                {
                    Console.WriteLine("Could not fit item in backpack");
                    return false;
                }
                else if (currentItems + 1 > maxItems)
                {
                    Console.WriteLine("Could not fit item in backpack");
                    return false;
                }
                else
                {
                    currentWeight += stuff.Weight();
                    currentVolume += stuff.Volume();
                    currentItems += 1;
                    return true;
                }
            }
        }

        static void Main(string[] args)
        {
            Backpack backpack = new Backpack();
            Arrow arrow = new Arrow();
            Bow bow = new Bow();
            Rope rope = new Rope();
            Water water = new Water();
            Food food = new Food();
            Sword sword = new Sword();

            while (true)
            {
                // arrow bugs out without this, since after inputting 7 it adds a random 0.000002 to the volume and 0.000005 to the weight
                decimal items = backpack.currentItems;
                items = Math.Round(items, 2);
                decimal volume = (decimal)backpack.currentVolume;
                volume = Math.Round(volume, 2);
                decimal weight = (decimal)backpack.currentWeight;
                weight = Math.Round(weight, 2);

                Console.WriteLine($"Backpack currently has {items}/{backpack.maxItems} items with a weight of {weight}/{backpack.maxWeight} and a volume of {volume}/{backpack.maxVolume}");
                Console.WriteLine("What do you want to add? \n1 - Arrow \n2 - Bow \n3 - Rope \n4 - Water \n5- Food \n6 - Sword");

                string question = Console.ReadLine();
                if (question == "1")
                {
                    backpack.Lisää(arrow);
                }
                else if (question == "2")
                {
                    backpack.Lisää(bow);
                }
                else if (question == "3")
                {
                    backpack.Lisää(rope);
                }
                else if (question == "4")
                {
                    backpack.Lisää(water);
                }
                else if (question == "5")
                {
                    backpack.Lisää(food);
                }
                else if (question == "6")
                {
                    backpack.Lisää(sword);
                }
                else
                {
                    Console.WriteLine("Chosen item not in list");
                }
            }
        }
    }
}
