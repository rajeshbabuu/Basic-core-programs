using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Powerof2
    {
        public void Power_Of_2()
        {
            Console.WriteLine("Enter a number : ");
            string inputByUser = Console.ReadLine();
            int numVal = Int32.Parse(inputByUser);
            if (numVal >= 0 || numVal < 31)
            {
                int temp = 1;
                for (int i = 0; i < numVal; i++)
                {
                    temp = 2 * temp;
                    Console.WriteLine(temp);
                }
            }
        }
    }
}
