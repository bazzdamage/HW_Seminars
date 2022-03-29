using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    internal class Seminar05
    {
        public static void Seminar05Solution()
        {
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
            //Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
            //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            //CountOfEvenNumsInArray(Utility.GetRndNumsArray(10, 100, 1000, 0));
            //SumOfOddNumsInArray(Utility.GetRndNumsArray(20, 1, 1000, 0));
            //DifferenceBetweenMaxAndMin(Utility.GetRndDoubleNumsArray(20, 1000, - 500));

        }
        private static void CountOfEvenNumsInArray(int[] array)
        {
            int countOfEven = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] % 2 == 0) countOfEven++;

            PrintResultArrayToConsole(array, "Count of EvenNums in Array = ", countOfEven);
        }
        private static void SumOfOddNumsInArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) if (i % 2 != 0) sum += array[i];

            PrintResultArrayToConsole(array, "Sum Of Odd indexes of array = ", sum);
        }
        private static void DifferenceBetweenMaxAndMin(double[] array)
        {
            double minElement = Double.MaxValue;
            double maxElement = Double.MinValue;
            
            for (int i = 0; i < array.Length; i++)
            {
                minElement = Math.Min(array[i], minElement);
                maxElement = Math.Max(array[i], maxElement);
            }
            double result = maxElement - minElement;
            PrintResultArrayToConsole(array, "Difference Between Max and Min Elements = ", result);
        }
        private static void PrintResultArrayToConsole(int[] array, string str, int result)
        {
            Console.WriteLine("Array of RND values: ");
            Utility.PrintArray(array);
            Console.Write("\n" + str + "" + result);
        }
        private static void PrintResultArrayToConsole(double[] array, string str, double result)
        {
            Console.WriteLine("Array of RND values: ");
            Utility.PrintArray(array);
            Console.Write("\n" + str + "" + result);
        }

    }
}
