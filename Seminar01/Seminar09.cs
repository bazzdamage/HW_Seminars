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
            //MultipleOf(2, 55);
            //Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            //Console.WriteLine($"\n Sum of each num = " + SumOf(1, 4));
            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            //m = 2, n = 3->A(n, m) = 29
            //Console.WriteLine($"\n Ackerman = " + Ackerman(3, 10));

            //Задача 1.Дано предложение.Напишите рекурсивный метод, подсчитывающий количество слов в данном предложении.
            //Словом считается последовательность символов без пробелов.
            string text = "Дано предложение. Напишите рекурсивный метод, подсчитывающий количество слов в данном предложении. Словом считается последовательность символов без пробелов.";
            //Console.WriteLine(CountOfWords(text));

            //Задача 2.Известно, что пароль длиной 3 символа состоит из латинских букв строчного регистра и цифр от 0 до 9.
            string symbols = "1234567890qwertyuiopasdfghjklzxcvbnm";
            //FindCombinations(symbols, new char[4]);
            //Напишите рекурсивный метод, который перебирает все комбинации паролей. 

            //Задача 3.Даны натуральные числа a и b.Рекурсивно описать функцию возведения числа a в степень b, используя только операцию инкрементирования(“++”).
            //Console.WriteLine("Степень = " + PowIncremently(3, 4));
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
        
        static int CountOfWords(string text, int i = 0, int count = 1)
        {
            if (i == text.Length) return count;
            if (text[i] == ' ') count ++;
            return CountOfWords(text, ++i, count);
        }
        static int n = 1;
        static void FindCombinations(string symbols, char[] word, int length = 0)
        {
            
            if (length == word.Length)
            {
                Console.WriteLine($"{n++} {new String(word)}"); return;
            }
            for (int i = 0; i < symbols.Length; i++)
            {
                word[length] = symbols[i];
                FindCombinations(symbols, word, length + 1);
            }
        }
        
        

        static int PowIncremently(int a, int b, int result = 0, int countc = 0)
        {
            if (countc == 0) result = a;
            if (countc == b - 1) return result;
            else
            {
                countc++;
                result = MultiplyIncremently(result, a);
                return PowIncremently(a, b, result, countc);
            }
            static int MultiplyIncremently (int a, int b, int counta = 1, int countb = 0, int result = 0)
            {
                if (countb == b) return result;

                if (counta == a)
                {
                    counta = 0;
                    countb++;
                }
                result++;
                counta++;
                return MultiplyIncremently(a, b, counta, countb, result);
            }
        }
    }
}
