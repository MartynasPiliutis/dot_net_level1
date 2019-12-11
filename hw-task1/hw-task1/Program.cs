using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_task1
{
    class Skaiciofke
    {
        int num1 = 0;
        int num2 = 0;

        public void KintamujuIvedimas()
        {

            Console.Write("Iveskite pirmaji kintamaji: ");
            num1 = Console.Read();
            Console.ReadLine();
            Console.Write("Iveskite antraji kintamaji: ");
            num2 = Console.Read();
            Console.ReadLine();
            Console.WriteLine("Suma yra: {0}", Sum());
        }

        public double Sum()
        {
            return num1 + num2;
        }



    }
    class Program
    {

        static void Main(string[] args)
        {
            Skaiciofke s = new Skaiciofke();
            s.KintamujuIvedimas();
            Console.ReadLine();

        }
    }
}
