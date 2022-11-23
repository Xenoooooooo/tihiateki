using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tihi_a_teknos
{
    class Crab : Food
    {
        protected int meret;
        public int Meret
        {
            get { return meret; }
            set
            {
                meret = rand();
            } 
        }
        public int rand()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10);
        }
        public override int Value()
        {
            Meret = meret;
            meret *= 10;
            return meret;
        }
    }
}
