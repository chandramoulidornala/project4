using System;

namespace project4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,rev,temp,sum=0;
            Console.WriteLine("enter the string");
            num = Convert.ToInt16(Console.ReadLine());
                temp = num;
            while (num > 0)
            {
                rev = num % 10;
                sum = (sum * 10) + rev;
                num = num / 10;
            }
            if (temp == sum)
                Console.WriteLine("Nmber is pallindrome");
            else
                Console.WriteLine("It is not pallindrome");
            }
        }
    }

