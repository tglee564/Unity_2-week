using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //A가 짝수이고 B가 0보다 작은 경우
            //A가 짝수이고 B가 3보다 작은 경우
            //A가 홀수이고 B가 5보다 작은 경우

            System.Console.WriteLine("첫번째 숫자를 입력하세요");
            string no1 = System.Console.ReadLine();
            System.Console.WriteLine("두번째 숫자를 입력하세요");
            string no2 = System.Console.ReadLine();
            int no3 = Convert.ToInt32(no1);
            int no4 = Convert.ToInt32(no2);

            if (no3 % 2 == 0 && no4 < 0)
            {
                System.Console.WriteLine("A는 짝수이며, B는 0보다 작습니다.");
            }
            else if (no3 % 2 == 0 && no4 < 3)
            {
                System.Console.WriteLine("A는 짝수이며, B는 3보다 작습니다.");
            }
            else if (no3 % 2 != 0 && no4 < 5)
            {
                System.Console.WriteLine("A는 홀수이며, B는 5보다 작습니다.");
            }
            else
            {
                System.Console.WriteLine("어느 값에도 해당되지 않습니다.");
            }
        }
    }
}