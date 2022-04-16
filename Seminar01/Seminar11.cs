using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    internal class Seminar11
    {
        public static void Seminar11Solution()
        {
            //Задача 1.На вход подуются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].
            int a = 100;
            int b = 20;
            var array = Utility.GetRndNumsArray(10, Math.Min(a, b), Math.Max(a, b), 0);
            Utility.PrintArray(array);
            Console.WriteLine();
            //Задача 2.Двумерный массив заполнен случайными натуральными числами от 1 до 10.Найдите количество элементов, значение которых больше 5, и их сумму.
            CountOfElementsAndSum(array, 50);
            //Задача 3.Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет.
            int year = 1992;
            Console.Write($"\nIs Year {year} are Leap?\nAnswer is: ");
            Console.WriteLine(IsYearLeap(year));
            int year2 = 1700;
            Console.Write($"\nIs Year {year2} are Leap?\nAnswer is: ");
            Console.WriteLine(IsYearLeap(year2));
            int year3 = 2000;
            Console.Write($"\nIs Year {year3} are Leap?\nAnswer is: ");
            Console.WriteLine(IsYearLeap(year));
        }
        static void CountOfElementsAndSum(int[] array, int n)
        {
            int sum = 0;
            foreach (int element in array)
            {
                if (element > n) 
                {
                    Console.WriteLine($"{element}");
                    sum += element;
                }
            }
            Console.WriteLine($"\nsum of this elements = {sum}");
        }
        static bool IsYearLeap(int year)
        {
            if (year % 400 == 0 || year % 100 == 0) return IsYearLeap(year / 100);
            else if (year % 4 == 0) return true;
            else return false;
        }
    }
}
