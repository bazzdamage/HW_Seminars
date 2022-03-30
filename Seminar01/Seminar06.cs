using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Seminars
{
    internal class Seminar06
    {
        public static void Seminar06Solution()
        {
            //++Задача 41.Пользователь вводит с клавиатуры M чисел.Посчитайте, сколько чисел больше 0 ввёл пользователь.
            //++Задача 43.Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;

            //CountOfPositiveNums();
            //Seminar03.Seminar03Solution(); // Задачку с пересечением прямых мы уже решали...

            //++Задача 1.Написать перевод десятичного числа в двоичное, используя рекурсию.
            //++Задача 2.На вход подаётся поговорка
            string example = "без труда не выловишь и рыбку из пруда";

            //  Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.
            //++Задача 3.Дано число N. Используя рекурсию, определите, что оно является степенью числа 3.

            //Console.WriteLine(Utility.AddZerosToBinary(Dec2BinRecursive(19)));
            //Console.WriteLine(CountVowels(example));
            Console.WriteLine(IsPowerOfN(27, 3));

            //Задача 1 *.Создайте программу, показывающую текущее время.
            //DigitalClock();



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
        private static string Dec2BinRecursive(int decNum)
        {
            if (decNum == 0) return "";
            return Dec2BinRecursive(decNum / 2) + decNum % 2 + "";
        }
        static char[] vowels = { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю', 'ё' };
        
        private static int CountVowels(string example, int index = 0)
        {
            if (example.Length == index) return 0;
            if (vowels.Contains(example[index])) return 1 + CountVowels(example, ++index);
            else return 0 + CountVowels(example, ++index);
        }
        private static bool IsPowerOfN(int Num, int power, int result = 1)
        {
            if (result > Num) return false;
            if (result == Num) return true;
            else return IsPowerOfN(Num, power, result *= power);
        }
        

        private static void DigitalClock()
        {

            void RenderHour(int hour)
            {

            }
            void RenderMinute(int minute)
            {

            }
            void RenderSeconds(int seconds)
            {

            }
            void PaintDigit(int digit) 
            {
                
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.Hour);
                Console.WriteLine(DateTime.Now.Minute);
                Thread.Sleep(100);
                //Console.Clear();

               
            }
            
        }
        
    }
}
