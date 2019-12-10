using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Suma
    {
        private double num1;
        private double num2;

        public void AcceptNumbers()
        {
            num1 = 17;
            num2 = 23;
        }

        public double GetSum()
        {
            return num1 + num2;
        }

        public void Display()
        {
            Console.WriteLine("Pirmas skaicius yra {0}", num1);
            Console.WriteLine("Antras skaicius yra {0}", num2);
            Console.WriteLine("Suma yra {0}", GetSum());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Suma s = new Suma();
            s.AcceptNumbers();
            s.Display();
            Console.ReadLine();
        }
    }
}
