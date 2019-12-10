using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string spalva = "";
            while (spalva != "gana")
            {
                Console.WriteLine("Kokia spalva tau patinka?");
                spalva = Console.ReadLine();
                Console.WriteLine("Man taip pat patinka {0} spalva", spalva);
                Console.WriteLine("Pakartojam :)");
            }

            Console.Clear();
            Console.WriteLine("Visi Geria :)");
            Console.ReadLine()
                ;
        }
    }
    
}
