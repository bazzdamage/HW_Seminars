using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    internal class Seminar10
    {
        public static void Seminar10Solution()
        {
            int num = 123456789;
            //++1.Дано число n. Получите число, записанное в обратном порядке.
            //ReverseNumRecursivePrint(num);
            //++2.Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... Дано число m.Выведите первые m членов этой последовательности.
            //SequenceOfNumbers(40);
            //++3.Дано натуральное число n > 1.Вывести все простые множители данного числа.
            //SimpleMultiplyers(10);

            //AxorB();

            //++Задача 1.Даны два числа a, b.Сложите их, используя только операции инкремента и декремента.
            //Console.WriteLine(SumIncremently(5, 10));
            //++Задача 2.Дана последовательность натуральных чисел.Определите значение второго по величине элемента в этой последовательности.
            //FindSecondMax();
            //++Задача 3.Дан массив, состоящий из случайных целых чисел.Дано число M.Выведите случайное подмножество массива, сумма элементов в котором не превосходит M.

            //FindCombinationsOfSumRec(6, 50); // Выводит все возможные комбинации, укладывающиеся в сумму (второй параметр метода). Пока он выводит все варианты перестановок. (как с подбором пароля)
            FindReplacingCombOfSum(10, 100); // Наконец то выводит то что я хотел - неповторяющиеся всевозможные комбинации чисел из массива с суммой меньше maxsum (второе значение в методе)
        }

        static int ReverseNumRecursive(int num, int result = 0)
        {
            if (num == 0) return result;
            result = result * 10 + num % 10;
            num /= 10;
            return ReverseNumRecursive(num, result);
        }
        static void ReverseNumRecursivePrint(int num)
        {
            ReverseNumRecursive(num);
            Console.WriteLine($"Initial num = {num}");
            Utility.SloMoPrint("...reversing...", 100);
            Utility.SloMoPrint(ReverseNumRecursive(num), 100);
        }
        static void SequenceOfNumbers(int count, int num = 1, int seq = 1)
        {
            if (count == 0) return;
            Console.Write(num + " ");
            if (seq < num) SequenceOfNumbers(--count, num, seq + 1);
            else SequenceOfNumbers(--count, num + 1);
        }
        static void SimpleMultiplyers(int currentNum, int mult = 1)
        {
            if (currentNum == 1) return;
            mult++;
            if (currentNum % mult == 0)
            {
                Console.Write(mult + " ");
                SimpleMultiplyers(currentNum / mult);
            }
            else SimpleMultiplyers(currentNum, mult);
        }
        static void AxorB()
        {
            int[] arrayA = { 1, 3, 5, 7 };
            int[] arrayB = { 4, 5, 6, 7 };
            HashSet<int> xor = new HashSet<int>();
            for (int i = 0; i < arrayA.Length; i++) xor.Add(arrayA[i]);
            for (int i = 0; i < arrayB.Length; i++) xor.Add(arrayB[i]);
            var result = xor.ToArray();
            Utility.PrintArray(result);
        }
        static int SumIncremently(int a, int b, int sumcount = 0)
        {
            if (sumcount == b) return a;
            else return SumIncremently(a + 1, b, ++sumcount);
        }
        static void FindSecondMax()
        {
            int[] array = Utility.GetRndNumsArray(30, 0, 100, 0);
            int max = 0;
            int secmax = 0;
            MaxRec();
            Utility.PrintArray(array);
            Console.WriteLine();
            Console.WriteLine($"max = {max}, secmax = {secmax}");

            void MaxRec (int count = 0)
            {
                if (count == array.Length - 1) return;
                else if (array[count] > max)
                {
                    secmax = max;
                    max = array[count];
                }
                MaxRec(count + 1);
            }
        }
        static void FindCombinationsOfSumRec(int arraysize, int maxsum)
        {
            int[] array = Utility.GetRndNumsArray(arraysize, 1, 50, 0);
            int[] sum = new int[arraysize];
            int n = 1;
            int templength = 0;
            for (int i = 1; i <= arraysize; i++)
            {
                FindCombinationsOfSum(maxsum, templength + i);
            }
            void FindCombinationsOfSum(int maxsum, int templength, int length = 0, int tempsum = 0)
            {
                if (length == templength)
                {
                    foreach (int i in sum) tempsum += i;

                    if (tempsum <= maxsum)
                    {
                        Console.Write($"{n++}. sum of elements = {tempsum}\n");
                        Utility.PrintArray(sum);
                        tempsum = 0;
                    }
                    return;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    sum[length] = array[i];
                    FindCombinationsOfSum(maxsum, templength, length + 1, tempsum);
                }
            }
                
        }
        static void FindReplacingCombOfSum(int arraysize, int maxsum)
        {
            int[] array = Utility.GetRndNumsArray(arraysize, 1, 50, 0);
            int n = 1;
            HashSet<string> combinations = new HashSet<string>(arraysize*arraysize*arraysize);

            permute(array, 0, arraysize, maxsum);

            foreach (string comb in combinations) Console.WriteLine($"{n++}. " + comb);
            void permute(int[] array, int start, int end, int maxsum)
            {
                if (start == end)
                {
                    int tempsum = 0;
                    string print = "|  ";
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (tempsum + array[i] < maxsum & i != array.Length)
                        {
                            print += array[i] + "  |  ";
                            tempsum += array[i];
                        }
                        combinations.Add(print + $"\nSum = {tempsum} and {maxsum - tempsum} to MAX sum");
                    }
                }
                else
                {
                    for (int i = start; i < end; i++)
                    {
                        (array[start], array[i]) = (array[i], array[start]);
                        permute(array, start + 1, end, maxsum);
                        (array[start], array[i]) = (array[i], array[start]);
                    }
                }
            }
        }
    }
}
