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

            //IsoScalesTriangle(); //Solution for AddProblem 01
            //CalculateAge(); //Solution for AddProblem 02, but all months are equal (31days) for simplify code.
            //CalculateCompoundInterest(); //Solution for AddProblem 03

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

        private static void IsoScalesTriangle()
        {
            Console.WriteLine("Please input A Side of Triangle: ");
            int a = Utility.UserInputINT();
            Console.WriteLine("Please input B Side of Triangle: ");
            int b = Utility.UserInputINT();
            Console.WriteLine("Please input C Side of Triangle: ");
            int c = Utility.UserInputINT();

            if (a == b & b == c) Console.WriteLine("This is Equilateral Triangle");
            else if (a == b | b == c | c == a) Console.WriteLine("This is IsoScales Triangle");
            else Console.WriteLine("Size of Triangles sides is not equal at all");
        }
        private static void CalculateAge()
        {
            int dateyear = 2022;
            int datemonth = 2;
            int dateday = 1;
            Console.WriteLine("Please input your birthYEAR: ");
            int birthyear = Utility.UserInputINTRange(1900, dateyear);
            Console.WriteLine("Please input your birthMONTH: ");
            int birthmonth = Utility.UserInputINTRange(1, 12);
            Console.WriteLine("Please input your birthDAY: ");
            int birthday = Utility.UserInputINTRange(1, 31);

            birthyear = dateyear - birthyear;
            birthmonth = datemonth - birthmonth;
            birthday = dateday - birthday;
            if (birthmonth < 0)
            {
                birthyear -= 1;
                birthmonth += 12;
            }
            if (birthday < 0)
            {
                birthmonth -= 1;
                birthday += 31;
            }
            Console.WriteLine($"Your Age are {birthyear} years, {birthmonth} months and {birthday} days");
            
        }
        private static void CalculateCompoundInterest()
        {
            Console.WriteLine("Please input your deposit size: ");
            double deposit = Utility.UserInputDouble();
            Console.WriteLine("Please input interest rate: ");
            double proc = Utility.UserInputDoubleRange(0, 100);
            Console.WriteLine("Please input number of months: ");
            int months = Utility.UserInputINT();
            double temp = deposit;
            int temp2 = months;

            while (months > 0)
            {
                deposit += deposit * (proc * 0.01);
                months--;
            }

            Console.WriteLine($"Your deposit after {temp2} months increased by {deposit - temp} and will make: {deposit}");

        }
    }
}
