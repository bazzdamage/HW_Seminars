using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    internal class Utility
    {
        public static void PrintArray(int[] array)
        {
            //Console.WriteLine(String.Join(", ", array));
            for (int i = 0; i < array.GetLength(0); i++)
                Console.Write("| " + array[i] + " ");
            Console.WriteLine();
        }
        public static void PrintArray(long[] array)
        {
            //Console.WriteLine(String.Join(", ", array));
            for (int i = 0; i < array.GetLength(0); i++)
                Console.Write("| " + array[i] + " ");
            Console.WriteLine();
        }
        public static void PrintArray(double[] array)
        {
            //Console.WriteLine(String.Join(", ", array));
            for (int i = 0; i < array.GetLength(0); i++)
                Console.Write("| " + array[i] + " ");
            Console.WriteLine();
        }
        public static void PrintArray2D(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                    Console.Write(array[row, column] + "\t");
                Console.WriteLine();
            }
        }
        public static int UserInputINT()
        {
            int num = 0;
            bool result = false;
            while (result == false)
            {
                Console.WriteLine("Number MUST be integer: ");
                string s = Console.ReadLine();
                result = int.TryParse(s, out num);
            }
            return num;
        }
        public static double UserInputDouble()
        {
            double num = 0;
            bool result = false;
            while (result == false)
            {
                Console.WriteLine("Number MUST be double: ");
                string s = Console.ReadLine();
                result = double.TryParse(s, out num);
            }
            return num;
        }
        public static int UserInputINTRange(int min, int max)
        {
            int num = 0;
            bool result = false;
            while (result == false)
            {
                Console.WriteLine("Number MUST be integer from " + min + " to " + max + " : ");
                string s = Console.ReadLine();
                result = int.TryParse(s, out num);
                if (num >= min && num <= max) result = true;
                else result = false;
            }
            return num;
        }
        public static double UserInputDoubleRange(double min, double max)
        {
            double num = 0;
            bool result = false;
            while (result == false)
            {
                Console.WriteLine("Number MUST be double from " + min + " to " + max + " : ");
                string s = Console.ReadLine();
                result = double.TryParse(s, out num);
                if (num >= min && num <= max) result = true;
                else result = false;
            }
            return num;
        }
        public static int CountOfInput()
        {
            Console.WriteLine("How big Array do you want?: ");
            int count = Utility.UserInputINT();
            return count;
        }
        public static int[] GetRndNumsArray(int count, int minValue, int maxValue, int modificator)
        {
            int[] array = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(minValue, maxValue) + modificator;
            }
            return array;
        }
        public static double[] GetRndDoubleNumsArray(int count, double multiplier, double modificator)
        {
            double[] array = new double[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rand.NextDouble() * multiplier + modificator;
            }
            return array;
        }
        public static int[,] GetRndNumsArray2D(int rows, int columns, int minValue, int maxValue)
        {
            int[,] array = new int[rows,columns];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i,j] = rand.Next(minValue, maxValue);
                }
            }
            return array;
        }
        public static int[] GetArrayOfInt(int count)
        {
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please fill Array [ " + (i + 1) + "/" + count + " ]" + ": ");
                array[i] = Utility.UserInputINT();
            }
            return array;
        }
        public static string Dec2Binary(int num)
        {
            StringBuilder sb = new StringBuilder();
            while (num > 0)
            {
                sb.Insert(0, num % 2);
                num /= 2;
            }
            if (sb.Length % 4 != 0)
            {
                for (int i = 0; i < sb.Length % 4; i++)
                {
                    sb.Insert(0, "0");
                }
            }
            return sb.ToString();
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static string ShuffleString(string s)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder(s);
            for (int i = sb.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                char temp = s[j];
                sb[j] = s[i];
                sb[i] = temp;
            }
            return new string(sb.ToString());
        }
        public static int[] ShuffleArray(int[] arr)
        {
            Random random = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
        public static int CountOfDigits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num /= 10;
                count++;
            }
            return count;
        }
    }
}
