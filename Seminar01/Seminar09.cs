using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    internal class Seminar09
    {
        public static void Seminar09Solution()
        {
            //Задача 64: Задайте значения M и N.Напишите программу, которая выведет все натуральные числа кратные 3 - ём в промежутке от M до N.
            MultipleOf(2, 55);
            //Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            Console.WriteLine($"\n Sum of each num = " + SumOf(1, 4));
            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            //m = 2, n = 3->A(n, m) = 29
            Console.WriteLine($"\n Ackerman = " + Ackerman(3, 10));
        }
        static void MultipleOf(int start, int end)
        {
            if(start > end) return;
            if (start % 3 == 0) Console.Write($"{start}\t");
            MultipleOf(start + 1, end);
        }
        static int SumOf(int start, int end)
        {
            if (start > end) return 0;
            else return start + SumOf(start + 1, end);
        }
        static int Ackerman(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m > 0 && n == 0) return Ackerman(m - 1, 1);
            else return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }
}
