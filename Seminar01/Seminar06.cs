using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    internal class Seminar06
    {
        public static void Seminar06Solution()
        {
            //Задача 41.Пользователь вводит с клавиатуры M чисел.Посчитайте, сколько чисел больше 0 ввёл пользователь.
            //0, 7, 8, -2, -2-> 2
            //- 1, -7, 567, 89, 223-> 3
            //Задача 43.Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
            //значения b1, k1, b2 и k2 задаются пользователем.
            //b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

            //CountOfPositiveNums();
            //Seminar03.Seminar03Solution(); // Задачку с пересечением прямых мы уже решали...
        }
        private static void CountOfPositiveNums()
        {
            int n = 5;
            int count = 0;
            while (n > 0)
            {
                int num = Utility.UserInputINT();
                if (num > 0) count++;
                n--;
            }
            Console.WriteLine($"You entered {count} positive numbers\n");
        }
    }
}
