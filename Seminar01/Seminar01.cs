using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar01
{
    internal class Seminar01
    {
        public static void Seminar01Solution()
        {
            int a = 115;
            int b = 18;         //2 ints for Problem_01 (Max of 2 Nums)
            int c = 955;        //int for Problem_02 (Max of 3 Nums)

            DoSimpleMath(a, b);     //Solution Method for Problem_01
            DoAltMath(a, b);     //Alt. Solution Method for Problem_01
            MaxOfThree(a, b, c);        //Solution Method for Problem_02

            int count = Utility.CountOfInput();     //get count of nums in Array from user
            int[] numsarray = Utility.GetArrayOfInt(count);     //get Array of custom size and user input for nums

            foreach (int i in numsarray) Console.Write(i + ", ");       //print Array
            Console.WriteLine("\n" + "Even Numbers are: " + EvenNums(numsarray));       //print string with only even nums in array (Problem_03)
            Console.WriteLine(PrintAllEvenNums());      // Solution for Problem_04
        }

        private static void DoSimpleMath(int a, int b)
        {
            Console.WriteLine("(Variant 1) Max Of 2 nums are: " + Math.Max(a, b));
        }
        private static void DoAltMath(int a, int b)
        {
            if (a < b) Console.WriteLine("(Variant 2) Max Of 2 nums are: " + b);
            else Console.WriteLine("(Variant 2) Max Of 2 nums are: " + a);
        }
        private static void MaxOfThree(int a, int b, int c)
        {
            int max = 0;
            if (a > b) max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            Console.WriteLine("Max Of 3 nums are: " + max);
        }

        private static string EvenNums(int[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) result = result + array[i] + " ";
            }
            return result;
        }
        private static string PrintAllEvenNums()
        {
            Console.WriteLine("Please enter N: ");
            int n = Utility.UserInputINT();
            string result = "";
            for (int i = 2; i <= n; i += 2)
            {
                result = result + i + " ";
            }
            return result;
        }
    }
}
