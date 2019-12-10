using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Veiksmai
    {
        private double num1;
        private double num2;
        private double num3;
        private double num4;
        private double num5;
        private double num6;
        private double num7;
        private double num8;
        private double num9;
        private double num10;
        public void AcceptNumbers()
        {
            num1 = -6;
            num2 = 3;
            num3 = 5;
            num4 = 13;
            num5 = 2;
            num6 = 7;
            num7 = 5;
            num8 = -2;
            num9 = 20;
            num10 = 10;

        }

        public double GetRez1()
        {
            return num1 + num2 * num3;
        }

        public double GetRez2()
        {
            return (num4 - num5) * num6;
        }

        public double GetRez3()
        {
            return (num7 + num8) + (num9 / num10);
        }

        public void Display()
        {
            Console.WriteLine("{0}+{1}*{2}={3}", num1, num2, num3, GetRez1());
            Console.WriteLine("({0}-{1})*{2}={3}", num4, num5, num6, GetRez2());
            Console.WriteLine("({0}+{1})+({2}/{3})={4}", num7, num8, num9, num10, GetRez3());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Veiksmai v = new Veiksmai();
            v.AcceptNumbers();
            v.Display();
            Console.ReadLine();
        }
    }
}