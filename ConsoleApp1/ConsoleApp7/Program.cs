using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("첫번째 숫자를 입력하세요");
            string s1 = System.Console.ReadLine();
            int s1number = Convert.ToInt32(s1);
            System.Console.WriteLine("두번째 숫자를 입력하세요");
            string s2 = System.Console.ReadLine();
            int s2number = Convert.ToInt32(s2);
            System.Console.WriteLine("기호를 입력하세요(+,-,*,/,%)");
            string s3 = System.Console.ReadLine();
            if (s3 == "+")
            {
                int newint = plus(s1number, s2number);
                System.Console.WriteLine($"결과값 {newint}");
            }
            else if (s3 == "-")
            {
                int newint = minus(s1number, s2number);
                System.Console.WriteLine($"결과값 {newint}");
            }
            else if (s3 == "*")
            {
                int newint = mult(s1number, s2number);
                System.Console.WriteLine($"결과값 {newint}");
            }
            else if (s3 == "/")
            {
                int newint = Division(s1number, s2number);
                System.Console.WriteLine($"결과값 {newint}");
            }
            else if (s3 == "%")
            {
                int newint = Per(s1number, s2number);
                System.Console.WriteLine($"결과값 {newint}");
            }
            else
            {
                System.Console.WriteLine("잘못된 입력 값입니다.");
                
            }




        }
        private static int plus(int number1, int number2)
        {
            int resultnumber = number1 + number2;
            return resultnumber;
        }
        private static int minus(int number1, int number2)
        {
            int resultnumber = number1 - number2;
            return resultnumber;
        }
        private static int mult(int number1, int number2)
        {
            int resultnumber = number1 * number2;
            return resultnumber;
        }
        private static int Division(int number1, int number2)
        {
            int resultnumber = number1 / number2;
            return resultnumber;
        }
        private static int Per(int number1, int number2)
        {
            int resultnumber = number1 % number2;
            return resultnumber;
        }

    }
}
