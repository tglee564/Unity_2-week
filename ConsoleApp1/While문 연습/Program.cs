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
            int numberlimit = 15;
            while (numberlimit > 0)
            {
                System.Console.WriteLine($"폭탄이 터지기까지 앞으로 {numberlimit}초");

                numberlimit--;
            }
            int Material = 1000;
        }
    }
}
