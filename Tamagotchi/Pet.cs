using System;
using System.Numerics;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Pet
    {
        private int hunger = 0;

        private int boredom = 0;

        private List<string> words = new List<string>();

        private bool isAlive = true;

        private Random generator = new Random();

        public string name;

        private string state;


        public void Feed()
        {
            hunger -= 5;

            Console.WriteLine("You feed" + name);
            if (hunger < 0)
            {
                hunger = 0;
            }

            Console.WriteLine(name + " is full, they can't eat another bite!");
        }

        public void Greet()
        {

        }

        public void CheckState()
        {
            if (hunger > 7 || boredom > 7)
            {
                state = "dying.";
            }
            else if (hunger > 4 && boredom > 4)
            {
                state = "hungry and bored";
            }
            else if (hunger > 4)
            {
                state = "hungry.";
            }
            else if (boredom > 4)
            {
                state = "bored.";
            }
            else
            {
                state = "happy!";
            }
        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
            Console.WriteLine(name + "learned to say" + word);
        }

        public void Tick()
        {
            hunger++;
            boredom++;
        }

        public void PrintStats()
        {
            if (GetAlive() == true)
            {

                Console.WriteLine("Hunger: " + hunger);
                Console.WriteLine("boredom: " + boredom);

                if (hunger > 10)
                {
                    Console.WriteLine(name + " is " + state);
                }

            }
            else
            {
                if (hunger > 10 && boredom > 10)
                {
                    Console.WriteLine(name + " died hungry and bored");
                }
                else if (hunger > 10)
                {
                    Console.WriteLine(name + " starved to death");
                }
                else if (boredom > 10)
                {
                    Console.WriteLine(name + " died of boredom");
                }
            }
            Console.ReadLine();
        }

        public bool GetAlive()
        {
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }
            return isAlive;
        }

        private void ReduceBoredom()
        {
            boredom -= 2;
            if (boredom < 0)
            {
                boredom = 0;
            }
        }

        public void Act()
        {
            bool acted = false;
            Console.WriteLine("What do you want to do? feed / teach / greet / nothing");

            while (acted == false)
            {

                string action = Console.ReadLine();

                if (action == "feed")
                {
                    Feed();
                    acted = true;
                }

                else if (action == "teach")
                {
                    Console.WriteLine("What word do you wish to teach " + name);
                    Teach(Console.ReadLine());
                    acted = true;
                }

                else if (action == "greet")
                {
                    Greet();
                    acted = true;
                }
                else if (action == "nothing")
                {
                    Console.WriteLine("You do nothing");
                    acted = true;
                }
            }
            Console.ReadLine();
        }
    }
}