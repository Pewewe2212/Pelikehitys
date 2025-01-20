namespace teht1_Ovi
{
    internal class Program
    {
        public class DoorClass
        {
            public enum Door { Open, Closed, Locked };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("There is a door. The door is closed, what would you like to do?");
            DoorClass.Door state = DoorClass.Door.Open;
            while (true)
            {
                string change = Console.ReadLine();
                if (change.ToLower() == "open".ToLower())
                {
                    if (state == DoorClass.Door.Closed)
                    {
                        state = DoorClass.Door.Open;
                        Console.WriteLine("Door is open. What do you want to do next?");
                    }
                    else if (state == DoorClass.Door.Locked)
                    {
                        Console.WriteLine("Door is locked, you need to unlock it before opening");
                    }
                    else if (state == DoorClass.Door.Open)
                    {
                        Console.WriteLine("Door is already open");
                    }
                }

                else if (change.ToLower() == "close".ToLower())
                {
                    if (state == DoorClass.Door.Closed)
                    {
                        Console.WriteLine("Door is already closed");
                    }
                    else if (state == DoorClass.Door.Locked)
                    {
                        Console.WriteLine("Door is locked, you need to unlock and open it before closing");
                    }
                    else if (state == DoorClass.Door.Open)
                    {
                        state = DoorClass.Door.Closed;
                        Console.WriteLine("Door is closed. What do you want to do next?");
                    }
                }

                else if (change.ToLower() == "lock".ToLower())
                {
                    if (state == DoorClass.Door.Closed)
                    {
                        state = DoorClass.Door.Locked;
                        Console.WriteLine("Door is locked. What do you want to do next?");
                    }
                    else if (state == DoorClass.Door.Locked)
                    {
                        Console.WriteLine("Door is already locked");
                    }
                    else if (state == DoorClass.Door.Open)
                    {
                        Console.WriteLine("Door is open. You need to close it before you can lock it");
                    }
                }

                else if (change.ToLower() == "unlock".ToLower())
                {
                    if (state == DoorClass.Door.Closed)
                    {
                        Console.WriteLine("Door is closed, not locked. The door needs to be locked to unlock it");
                    }
                    else if (state == DoorClass.Door.Locked)
                    {
                        state = DoorClass.Door.Closed;
                        Console.WriteLine("Door is unlocked, but closed. What do you want to do next?");
                    }
                    else if (state == DoorClass.Door.Open)
                    {
                        Console.WriteLine("Door is open. You need to close and lock it before you can unlock it");
                    }
                }

                else
                {
                    Console.WriteLine("Did not recognize action");
                }

            }
        }
    }
}
