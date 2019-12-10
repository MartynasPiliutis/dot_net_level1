using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Dalyba
    {
        private double num1;
        private double num2;

        public void AcceptNumbers()
        {
            num1 = 24;
            num2 = 5;
        }

        public double GetDal()
        {
            return num1 / num2;
        }

        public void Display()
        {
            Console.WriteLine("Pirmas skaicius yra {0}", num1);
            Console.WriteLine("Antras skaicius yra {0}", num2);
            Console.WriteLine("{0} padaline is {1} gausime {2}", num1, num2, GetDal());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dalyba s = new Dalyba();
            s.AcceptNumbers();
            s.Display();
            Console.ReadLine();
        }
    }
}