using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For문
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(초기식 ; 조건식 ; 증감식)
            //{
            //}

            for (int number = 0; number < 5; number++)
                System.Console.WriteLine($"hi({number})");
        }
    }
}
