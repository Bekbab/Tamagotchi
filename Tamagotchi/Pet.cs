using System;
using System.Numerics;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Pet
    {
        private int hunger;

        private int boredom;

        private List<string> words = new List<string>();

        private bool isAlive;

        private Random generator = new Random();

        public string name;

        public void Feed()
        {

        }

        public void Hi()
        {

        }

        public void Teach(string words)
        {

        }

        public void PrintStats()
        {

        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {

        }
    }
}