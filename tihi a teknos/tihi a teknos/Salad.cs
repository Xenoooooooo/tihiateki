using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tihi_a_teknos
{
    class Salad : Food
    {
        static int taperetek = 10;
        public override int Value()
        {
            return taperetek;
        }
    }
}
