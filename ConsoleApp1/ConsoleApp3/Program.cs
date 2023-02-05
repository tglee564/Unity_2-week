using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //숫자 입력 2개를 받고 값을 더한 후 숫자 10,20,30,40,else

            System.Console.WriteLine("첫번째 숫자를 입력하세요");
            string no1 = System.Console.ReadLine();
            System.Console.WriteLine("두번째 숫자를 입력하세요");
            string no2 = System.Console.ReadLine();
            int no3 = Convert.ToInt32(no1);
            int no4 = Convert.ToInt32(no2);
            int no5 = no3 + no4;

            if (no5 < 10)
            {
                System.Console.WriteLine($"두 숫자의 합은 {no5}이며, 10보다 작습니다");
            }
            else if (no5 < 20)
            {
                System.Console.WriteLine($"두 숫자의 합은 {no5}이며, 10보다 크고 20보다 작습니다");
            }
            else if (no5 < 30)
            {
                System.Console.WriteLine($"두 숫자의 합은 {no5}이며, 20보다 크고 30보다 작습니다");
            }
            else if (no5 < 40)
            {
                System.Console.WriteLine($"두 숫자의 합은 {no5}이며, 30보다 크고 40보다 작습니다");
            }
            else
            {
                System.Console.WriteLine($"두 숫자의 합은 {no5}이며, 40보다 큽니다");
            }
        }
    }
}
