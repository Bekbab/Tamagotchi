using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet p1 = new Pet();
            Console.WriteLine("Name your pet.");
            p1.name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You have chosen the name " + p1.name + " for your pet.");
            Console.ReadLine();


            while (p1.GetAlive() == true)
            {
                p1.Tick();
                p1.GetAlive();
                p1.CheckState();
                p1.PrintStats();
                p1.Act();

            }
            Console.ReadLine();
        }
    }
}
