using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int number = 2 + 3;


            if(number < 0) // number가 0보다 작은가?
            {
                System.Console.WriteLine("Number는 0보다 작습니다.");

            }
            else if(number < 2) // number는 2보다 작은가?
            {
                System.Console.WriteLine("Number는 0보다 크고 2보다 작습니다.");
            }
            else if (number < 4)
            {
                System.Console.WriteLine("Number는 2보다 크고 4보다 작습니다."); // number는 4보다 작은가? 2보다 크고 4볻 작습니다.
            }
            else
            {
                System.Console.WriteLine("Number는 4보다 큽니다."); // number는 4보다 큽니다.
            }

            System.Console.WriteLine("-------------------------------------------------------")
            
        }
    }
}
