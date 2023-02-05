using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("숫자를 입력하세요");
            string number0 = System.Console.ReadLine();
            int number1 = Convert.ToInt32(number0);
            Counter(number1);
        }
        private static void Counter(int Limit0)
        {
            while (Limit0 > 0)
            {
                System.Console.WriteLine($"폭탄이 터지기 까지 앞으로 {Limit0}초");

                Limit0--;
            }
        }
    }
}
