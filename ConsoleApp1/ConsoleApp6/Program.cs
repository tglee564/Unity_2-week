using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static int Main(string[] args)
        {
            System.Console.WriteLine("0");
            //메소드
            ShowUpNewSentence(6);
            System.Console.WriteLine("3");
        }

        //private,protectic,public
        private static void ShowUpNewSentence(int number)
        {
            int NewNumber2 = number * 5;
            System.Console.WriteLine(NewNumber2);

            return NewNumber2;
            System
        }
    }
}
