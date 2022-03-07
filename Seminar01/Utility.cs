using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar01
{
    internal class Utility
    {
        public static void PrintArray(int[] array)
        {
            Console.WriteLine(String.Join(", ", array));
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
        public static int CountOfInput()
        {
            Console.WriteLine("How big Array do you want?: ");
            int count = Utility.UserInputINT();
            return count;
        }
        public static int[] GetRndNumsArray(int count, int minValue, int maxValue)
        {
            int[] array = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
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
    }
}
