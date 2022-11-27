using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class LargestNo
    {
        public void Largest_Among_Three_Numbers()
        {
            // int num1 = 12;
            // int num2 = 23;
            // int num3 = 10;

            Console.WriteLine("Enter first number : ");
            string str1 = Console.ReadLine();
            int num1 = Int32.Parse(str1);
            Console.WriteLine("Enter second number : ");
            string str2 = Console.ReadLine();
            int num2 = Int32.Parse(str2);
            Console.WriteLine("Enter third number : ");
            string str3 = Console.ReadLine();
            int num3 = Int32.Parse(str3);
            Console.WriteLine(num1 + " @@@@@@@");
            Console.WriteLine(num1 + " %%%%%%");
            Console.WriteLine(num1 + " @@@@@@@&&&&&&");
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " is greatest ");
                }
                else
                {
                    Console.WriteLine(num3 + "  is greatest .");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    if (num2 > num1)
                    {
                        Console.WriteLine(num2 + " is greatest . ");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " is greatest . ");
                    }
                }
            }
        }
    }
}
