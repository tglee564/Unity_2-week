using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //while문
            int numberlimit = 10;
            while(numberlimit > 0)
            {
                System.Console.WriteLine($"Hi({numberlimit})");

                numberlimit--;
            }

            //do while문
            do
            {
                System.Console.WriteLine("Hi");

            } while (numberlimit > 5);

        }
    }
}
