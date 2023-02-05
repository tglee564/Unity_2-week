using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_메소드_연습
{
    class Program
    {
        static void Main(string[] args)
        {
            int Plusmethod1 = Plusmethod(5);
            System.Console.WriteLine(Plusmethod1);
            int Minusmethod1 = Minusmethod(5);
            System.Console.WriteLine(Minusmethod1);
            int Multmethod1 = Multmethod(5);
            System.Console.WriteLine(Multmethod1);
            int Divmethod1 = Divmethod(5);
            System.Console.WriteLine(Divmethod1);
            int Permethod1 = Permethod(5);
            System.Console.WriteLine(Permethod1);


        }
        private static int Plusmethod(int number1)
        {
            int Plusmethod1 = number1 + 5;
            return Plusmethod1;
        }
        private static int Minusmethod(int number2)
        {
            int Minusmethod1 = number2 - 5;
            return Minusmethod1;
        }
        private static int Multmethod(int number3)
        {
            int Multmethod1 = number3 * 5;
            return Multmethod1;
        }
        private static int Divmethod(int number4)
        {
            int Divmethod1 = number4 / 5;
            return Divmethod1;
        }
        private static int Permethod(int number5)
        {
            int Permethod1 = number5 % 5;
            return Permethod1;
        }
    }
}
