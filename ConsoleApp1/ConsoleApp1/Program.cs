using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //연산자
            int number1 = 10;
            int number2 = 16;

            int plusresult = number1 + number2;
            int minusresult = number1 - number2;
            int multresult = number1 * number2;
            int quioresult = number1 / number2; //몫
            int reminresult = number1 % number2; //나머지
            System.Console.WriteLine($"Plus result : {plusresult}");
            System.Console.WriteLine($"Plus result : {minusresult}");
            System.Console.WriteLine($"Plus result : {multresult}");
            System.Console.WriteLine($"Plus result : {quioresult}");
            System.Console.WriteLine($"Plus result : {reminresult}");

            //할당연산자

            int number3 = 123;
            int number4 = 532;

            number4 += number3;
            System.Console.WriteLine($"Plus result : {number4}");
            number4 -= number3;
            System.Console.WriteLine($"Plus result : {number4}");
            number4 *= number3;
            System.Console.WriteLine($"Plus result : {number4}");
            number4 /= number3;
            System.Console.WriteLine($"Plus result : {number4}");
            number4 %= number3;
            System.Console.WriteLine($"Plus result : {number4}");

            System.Console.WriteLine("-------------------------------------------------------------------------");

            int value = 123;

            System.Console.WriteLine($"result : {++value}");
            System.Console.WriteLine($"result : {value}");
            System.Console.WriteLine($"result : {value++}");
            System.Console.WriteLine($"result : {value}");

            System.Console.WriteLine("-------------------------------------------------------------------------");
            //실습

            int value2 = 10;
            int value3 = 20;
            int PlusResult = value3 + value2;
            int MinusResult = value3 - value2;
            int MultResult = value3 * value2;
            int QuioResult = value3 / value2;
            int ReminResult = value3 % value2;



            System.Console.WriteLine($"Plus result : {PlusResult}");
            System.Console.WriteLine($"Plus result : {MinusResult}");
            System.Console.WriteLine($"Plus result : {MultResult}");
            System.Console.WriteLine($"Plus result : {QuioResult}");
            System.Console.WriteLine($"Plus result : {ReminResult}");

            value2 += value3;
            System.Console.WriteLine($"Plus result : {value2}");
            value2 -= value3;
            System.Console.WriteLine($"Plus result : {value2}");
            value2 *= value3;
            System.Console.WriteLine($"Plus result : {value2}");
            value2 /= value3;
            System.Console.WriteLine($"Plus result : {value2}");
            value2 %= value3;
            System.Console.WriteLine($"Plus result : {value2}");

            System.Console.WriteLine("-------------------------------------------------------------------------");

            //const <- 절대로 변경되지 않는 값
            const int thenumber = 10;

            //bool <-
            bool isnametaegeun = true;
            bool isyournametaegeun = !isnametaegeun;

            System.Console.WriteLine($"{isnametaegeun}");
            System.Console.WriteLine($"{isyournametaegeun}");

            // == 같다
            // != 다르다
            // < 작다
            // > 크다
            // <= 작거나 같다
            // >= 크거나 같다

            bool issame = (3 == 3);
            System.Console.WriteLine(issame);
            bool issame2 = (3 == 4);
            System.Console.WriteLine(issame2);
            bool isnosame = (3 != 4);
            System.Console.WriteLine(isnosame);
            bool isnosame2 = (3 != 3);
            System.Console.WriteLine(isnosame2);
            bool issmall = (3 < 4);
            System.Console.WriteLine(issmall);
            bool issmall2 = (4 < 3);
            System.Console.WriteLine(issmall2);
            bool isbig = (4 > 3);
            System.Console.WriteLine(isbig);
            bool isbig2 = (3 > 4);
            System.Console.WriteLine(isbig2);
            bool issmallnsame = (5 >= 4);
            System.Console.WriteLine(issmallnsame);
            bool issmallnsame2 = (3 >= 4);
            System.Console.WriteLine(issmallnsame2);
            bool isbignsame = (3 <= 4);
            System.Console.WriteLine(isbignsame);
            bool isbignsame2 = (5 <= 4);
            System.Console.WriteLine(isbignsame2);

            //비교연산자
            System.Console.WriteLine("비교연산자");
            bool istrue = true;
            bool isfalse = false;


            bool isAnd = (istrue && isfalse);
            bool isOr = (istrue || isfalse);

            bool istrue1 = true;
            bool isfalse1 = false;

            System.Console.WriteLine("예제");
            System.Console.WriteLine(true && true); //true
            System.Console.WriteLine(true && false); //false
            System.Console.WriteLine(false && true); //false
            System.Console.WriteLine(false && false); //false

            System.Console.WriteLine(true || true); //true
            System.Console.WriteLine(true || false); //true
            System.Console.WriteLine(false || true); //true
            System.Console.WriteLine(false || false); //false

            System.Console.WriteLine("연습");
            System.Console.WriteLine(issame && issame); //true
            System.Console.WriteLine(issame && issame2); //false
            System.Console.WriteLine(issmall2 && isbig); //false
            System.Console.WriteLine(issmall2 && isbig2); //false

            System.Console.WriteLine(issmallnsame || isbignsame); //true
            System.Console.WriteLine(isbignsame || isbignsame2); //true
            System.Console.WriteLine(isbignsame2 || isbignsame); //true
            System.Console.WriteLine(isbignsame2 || isbignsame2); //false

            

        }
    }
}
