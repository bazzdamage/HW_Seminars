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
            //++Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
            //++Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
            //++Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

            //CountOfEvenNumsInArray(Utility.GetRndNumsArray(10, 100, 1000, 0));
            //SumOfOddNumsInArray(Utility.GetRndNumsArray(20, 1, 1000, 0));
            //DifferenceBetweenMaxAndMin(Utility.GetRndDoubleNumsArray(20, 1000, - 500));

            //Допы
            //++Задача 1.Задан массив из случайных цифр на 15 элементов.На вход подаётся трёхзначное натуральное число. 
            //  Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.
            //++Задача 2.На вход подаются два числа случайной длины. Найдите произведение каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив.
            //++Задача 3.Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений.Подсчитайте их количество.

            //FindSequenceOfDigitsInArray(Utility.GetRndNumsArray(500, 0, 10, 0));
            //ProductOfTwoDifferentGrades();
            //FindAllNumsWithTrickyCondition();

            //Супер доп
            //++Задача 1 *.Дан массив массивов, состоящих из натуральных чисел, размер которого 5.
            //  Для каждого элемента-массива определить найти сумму его элементов и вывести массив с наибольшей суммой.
            //  Если таких массивов несколько, вывести массив с наименьшим индексом.
            
            //JaggedArrayFindMaxSum();
            




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
        private static void FindSequenceOfDigitsInArray(int[] array)
        {
            Console.WriteLine("Please enter number, which sequence of digits we are looking for: ");
            int num = Utility.UserInputINTRange(100, 1000);
            string userNum = num.ToString();
            string arrayNums = "";
            Utility.PrintArray(array);
            foreach (int i in array) arrayNums += array[i];
            if (arrayNums.Contains(userNum)) Console.WriteLine($"Array contains {userNum}");
            else Console.WriteLine($"Array doesn't contains {userNum}");
        }
        private static void ProductOfTwoDifferentGrades() 
        {
            Random random = new Random();
            int numA = random.Next(1, 150);
            int numB = random.Next(1, 150);
            int countOfDigitsA = Utility.CountOfDigits(numA);
            int countOfDigitsB = Utility.CountOfDigits(numB);
            Console.WriteLine($"Number #1 = {numA}");
            Console.WriteLine($"Number #2 = {numB}");
            int[] result = new int[countOfDigitsA * countOfDigitsB];
            int position = 0;
            while (position < result.Length)
            {
                int temp = numB;
                for (int j = 0; j < countOfDigitsB; j++)
                {
                    result[position] = (numA % 10) * (temp % 10);
                    temp /= 10;
                    position++;
                }
                numA /= 10;
            }
            Console.WriteLine("Result array: \n");
            Utility.PrintArray(result);
        }
        private static void FindAllNumsWithTrickyCondition()
        {
            int number = 1;
            List<int> trickyNums = new List<int>();
            while (number < 1000000)
            {
                int temp = number;
                int sum = 0;
                int product = 1;
                while (temp > 0)
                {
                    sum += (temp % 10);
                    product *= (temp % 10);
                    temp /= 10;
                }
                if (sum * 3 == product) trickyNums.Add(number);
                number++;
            }
            Console.WriteLine("Tricky Elements: \n");
            foreach (int num in trickyNums) Console.WriteLine($" {num} ");
            Console.WriteLine($"\nNumber of Elements, whose Product in 3 times bigger than Sum = {trickyNums.Count}");
        }
        private static void JaggedArrayFindMaxSum()
        {
            int [][] jaggedarray = new int [5][];
            Random random = new Random();
            int sum = 0;
            int maxsum = 0;
            int maxsumindex = 0;
            for (int i = 0; i < jaggedarray.GetLength(0); i++) //Create fully random JaggedArray 
            {
                jaggedarray[i] = new int[random.Next(6,16)];
                for (int j = 0; j < jaggedarray[i].Length; j++)
                {
                    jaggedarray [i][j] = random.Next(100);
                    sum += jaggedarray[i][j];
                    Console.Write(jaggedarray[i][j] + " ");
                }
                if (sum > maxsum)
                {
                    maxsum = sum;
                    maxsumindex = i;
                }
                sum = 0;
                Console.WriteLine($"\ni = {i}");
            }
            Console.WriteLine($"\nMaximum Sum of Array's Elements of are: {maxsum}, index of that Array are: {maxsumindex}");

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
