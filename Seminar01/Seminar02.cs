using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar01
{
    public class Seminar02
    {
        public static void Seminar02Solution()
        {
            //ReverseNum(); //Solution for The Problem 10
            //PrintThirdNum(); //Solution for the Problem 13
        }
        private static void ReverseNum()
        {
            int revnum = 0;
            int count = 0;
            int num = Utility.UserInputINT();
            int temp = num;

            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }

            while (num > 0)
            {
                revnum = revnum + (num % 10) * (int) Math.Pow(10,count - 1);
                num = num / 10;
                count--;  
                                
            }
            Console.WriteLine("revnum: " + revnum);
            Console.WriteLine("count: " + count);
        }

        private static void PrintThirdNum()
        {
            int thirdnum = 0;
            int count = 0;
            int num = Utility.UserInputINT();
            int temp = num;

            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }

            temp = num;

            if (count < 3) Console.WriteLine("Number of digits < 3, nothing to print");
            else
            {
                while (num > 0)
                {
                    thirdnum = num % 10;
                    num = num / 10;
                    if (count == 3) Console.WriteLine("Third digit in the " + temp + " is: " + thirdnum);
                    count--;
                    
                }
            }
        }

    }
}
