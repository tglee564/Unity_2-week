using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_별그리기
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("1.좌측 삼각형");
            for (int i = 0; i < 5; i++)
            {
                for (int row = 0; row < i + 1; row++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("2.우측 역삼각형");
            for (int j = 0; j < 5; j++)
            {
                for (int row1 = 5; row1 > j; row1--)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("3.우측 삼각형");
            for (int k = 0; k < 5; k++)
            {
                for (int row2 = 5; row2 > k + 1; row2--)
                {
                    System.Console.Write(" ");
                }
                for (int row3 = 0; row3 < k + 1; row3++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
        }
    }
}
