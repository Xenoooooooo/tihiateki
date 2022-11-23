using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tihi_a_teknos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Crab rak = new Crab();
            Salad salata = new Salad();
            Food[] etelek = { rak, salata };
            Turtle tihi = new Turtle();
            tihi.equ();
            Console.WriteLine("A teknos lakottsagi szintje etetes elott:"+tihi.FedLevel);
            Console.WriteLine("A teknos boldogsag szintje etetes elott:" + tihi.Happiness+"\n");

            foreach (Food etel in etelek)
            {
                Console.Write("Taperteke az eteleknek:");
                Console.WriteLine(etel.Value());
                Console.WriteLine();
            }

            tihi.Eat(salata.Value(), salata.Value());

            Console.WriteLine("A teknos lakottsagi szintje etetes utan:" + tihi.FedLevel);
            Console.WriteLine("A teknos boldogsag szintje etetes utan:" + tihi.Happiness + "\n");
        }
    }
    
}
