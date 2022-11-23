using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tihi_a_teknos
{
    internal class Turtle
    {
        protected int happiness,fedLevel;
        public int Happiness
        {
            get { return happiness; }
            set
            {
                happiness = rand();
            }
        }
        public int FedLevel
        {
            get { return fedLevel; }
            set
            {
                fedLevel = rand();
            }
        }
        private static Random rnd = new Random();
        public int rand()
        {
            int a = rnd.Next(0, 1000);
            return a;
        }
        public void equ()
        {
            Happiness = happiness;
            FedLevel = fedLevel;
        }
        public void Eat(int tap, int tap2)
        {
            if (fedLevel+tap < 1000)
            {
                fedLevel += tap;
            }
            if (fedLevel + tap2 < 1000)
            {
                fedLevel += tap2;
            }
            if (fedLevel < 500)
            {
                happiness += 2 * (tap + tap2);
            }
            else
            {
                happiness -= 2 * (tap + tap2);
            }
        }
    }
}
