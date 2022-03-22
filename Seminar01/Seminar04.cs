using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    internal class Seminar04
    {
        public static void Seminar04Solution()
        {
            //ConsolePainter();
            //Console.WriteLine("EXponentiation: \n" + PowerOf(5,22) + "\n");
            //Console.WriteLine("Summary of Digits: \n" + SumOfDigits(451005) + "\n");
            //Utility.PrintArray(ArraySortByMod(Utility.GetRndNumsArray(8, 0, 100, -50)));
            //BinaryPalindrome(126);
            //Utility.PrintArray(ArraySqrCountOfOne(Utility.GetRndNumsArray(100, 0, 2, 0)));
            MostСommonElementInArray(Utility.GetRndNumsArray(100, 0, 100, 0));
        }
        private static void ConsolePainter() 
        {
            
            int Width = 100;
            int Height = 50;
            Console.SetWindowSize(Width, Height);
            Console.TreatControlCAsInput = false;
            ConsoleKeyInfo key;
            int Row;
            int Column;

            Console.WriteLine("Welcome to the ConsolePainter v0.0.1 Alpha");
            Console.WriteLine();
            Console.WriteLine("Arrows to navigate; Spacebar to paint █; X,C,V to paint half-tones; Z to paint ▬");
            Console.WriteLine("Backspace to erase");
            Console.WriteLine("Press ENTER to Start, Escape to Exit");
            
            while (true) 
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
            }
                 
            Console.Clear();
            Row = Console.CursorTop;
            Column = Console.CursorLeft;

            while (true)
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if(Row < Console.WindowHeight - 1) Row += 1;
                    else Row = 0;
                    Console.SetCursorPosition(Column, Row);
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (Row > 0) Row -= 1;
                    else Row = Console.WindowHeight - 1;
                    Console.SetCursorPosition(Column, Row);
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if(Column > 0) Column -= 1;
                    else Column = Console.WindowWidth - 1;
                    Console.SetCursorPosition(Column, Row);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (Column < Console.WindowWidth - 1) Column += 1;
                    else Column = 0;
                    Console.SetCursorPosition(Column, Row);
                }
                if (key.Key == ConsoleKey.Spacebar)
                {   
                    Console.Write("█");
                    Console.SetCursorPosition(Column, Row);
                }
                if (key.Key == ConsoleKey.Z)
                {
                    Console.Write("▬");
                    Console.SetCursorPosition(Column, Row);
                }
                if (key.Key == ConsoleKey.X)
                {
                    Console.Write("▓");
                    Console.SetCursorPosition(Column, Row);
                }
                if (key.Key == ConsoleKey.C)
                {
                    Console.Write("▒");
                    Console.SetCursorPosition(Column, Row);
                }
                if (key.Key == ConsoleKey.V)
                {
                    Console.Write("░");
                    Console.SetCursorPosition(Column, Row);
                }
                if (key.Key == ConsoleKey.Backspace)
                {
                    Console.Write(" ");
                    Console.SetCursorPosition(Column, Row);
                }
                if (key.Key == ConsoleKey.Escape) break;
            }
        }
        private static long PowerOf(int num, int pow)
        {
            long result = num;
            if (num == 0) return 0;
            if (num == 1) return 1;
            for (int i = 1; i < pow; i++) result *= num;
            return result;
        }
        private static int SumOfDigits(int num)
        {
            int sum = 0;
            if (num < 10) return num;
            while (num > 0)
            {
                sum += (num % 10);
                num /= 10;
            }
            return sum;
        }
        private static int[] ArraySortByMod(int[] array)
        { 
            int temp;

            Console.WriteLine("Initial array are: \n");
            Utility.PrintArray(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if(Math.Abs(array[j]) < Math.Abs(array[i]))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nResult array are: \n");

            return array;
        }
        private static void BinaryPalindrome(int num)
        {
            string binary = Utility.Hex2Binary(num);
            int lenght = binary.Length;

            string binarybegin = binary.Substring(0, lenght / 2);
            string binaryend = Utility.ReverseString(binary.Substring(lenght / 2, lenght / 2));
            
            if (binarybegin.Equals(binaryend))
            {
               Console.WriteLine($"The Number: {num} is palindrome in Binary number system: {binary}");
            }
            else Console.WriteLine($"The Number: {num} is NOT a palindrome in Binary number system: {binary}");

        }
        private static int[] ArraySqrCountOfOne(int[] arr)
        {
            int CountOfOne(int[] arr)
            {
                int countOfOne = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1) countOfOne++;
                }
                return countOfOne;
            }
            int countOfOne = CountOfOne(arr);
            int sqrcount = countOfOne * countOfOne;

            int[] array = new int[sqrcount];
            for (int i = 0; i < sqrcount; i++)
            {
                if (i <= countOfOne) array[i] = 1;
                else array[i] = 0;
            }
            Utility.ShuffleArray(array);


            return array;
        }
        private static void MostСommonElementInArray(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            int count = 1;
            int countMost = 1;
            int countMostIndx = 0;
            Array.Sort(arr);
            Utility.PrintArray(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) count++;
                else if (count > countMost)
                {
                    countMost = count;
                    countMostIndx = i;
                    count = 1;
                }
                else count = 1;
            }
            count = 1;
            for (int i = countMostIndx + 1; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) count++;
                else if (count == countMost && count > 1 && countMost > 1)
                {
                    if (sb.Length == 0) sb.Append(arr[i]);
                    else sb.Append(" & " + arr[i]);
                    count = 1;
                }
                else count = 1;
            }
            Console.WriteLine("Most Common Element in Array is : " + arr[countMostIndx] + "\nit encounters " + countMost + " times");
            if (sb.Length > 0) Console.WriteLine($"Also Elements: {sb.ToString()} occurs in the array the same number of times");
            
        }
    }
}
