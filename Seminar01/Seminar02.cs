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
            //PrintThirdNum(Utility.UserInputINT()); //Solution for the Problem 13
            //MassivePrintThirdNum(); //Solution for the Problen 13, but with array of RND Nums
            //GetDayOfWeek(); //Solution for the Problem 15

            //Additional Problems



        }
        private static void ReverseNum()
        {
            int newnum = 0;
            int num = Utility.UserInputINT();
            int oldnum = num;

            while (num > 0)
            {
                newnum = newnum * 10 + num % 10;
                num /= 10;
            }

            Console.WriteLine(newnum);
         
           
        }

        private static void PrintThirdNum(int num)
        {
            int temp = num;
            
            if (num < 100) Console.WriteLine("Number of digits < 3, nothing to print");
            else
            { 
                while (num >= 1000) num /= 10;               
                Console.WriteLine("Third digit in the " + temp + " is: " + num % 10);
            }
        }

        private static void GetDayOfWeek()
        {
            int day = Utility.UserInputINTRange(1, 7);
            switch (day)
            {
                case <= 5:
                    Console.WriteLine("Work Harder");
                    break;
                case > 6:
                    Console.WriteLine("You have some extra sleep today");
                    break;
            }
        }

        private static void MassivePrintThirdNum()
        {
            Console.WriteLine("Input lenght of the Array: ");
            int a = Utility.UserInputINT();
            Console.WriteLine("Input MIN num of RND Range: ");
            int b = Utility.UserInputINT();
            Console.WriteLine("Input MAX num of RND Range: ");
            int c = Utility.UserInputINT();
            int[] array = Utility.GetRndNumsArray(a, b, c);

            for (int i = 0; i < array.Length - 1; i++) PrintThirdNum(array[i]);
        }
    }
}
