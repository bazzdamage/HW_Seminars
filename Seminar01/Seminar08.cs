using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    internal class Seminar08
    {
        public static void Seminar08Solution()
        {
            //int[,] array2D = Utility.GetRndNumsArray2D(15, 10, 0, 50);
            //Utility.PrintArray2D(array2D);
            //Console.WriteLine();


            //++Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            //Array2DDescendingSortRows(array2D);
            //++Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            //Array2DFindRowWithMinSum(array2D);
            //++Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
            //Already Solved in Seminar07Solution.
            //++Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, которая построчно выведет элементы и их индексы.
            //FillAndPrintArray3D();
            //++Задача 62: Заполните спирально массив 4 на 4 числами от 1 до 16.
            //SpiralFillMatrix(45, 25);

            //++Задача 1.Дан двумерный массив. Заменить в нём элементы первой строки элементами главной диагонали.А элементы последней строки, элементами побочной диагонали.
            //ChangeElementsInArray2DWithDiagonal(array2D);
            //++Задача 2.Дан двумерный массив, заполненный случайными числами от - 9 до 9.Подсчитать частоту вхождения каждого числа в массив, используя словарь.
            //FrequencyDictionaryArray2D(array2D);
            //++Задача 3.Найти минимальный по модулю элемент. Удалить столбец и диагонали, содержащие его.
            //FindCrossOnMinElementAndThrowOut(array2D);
            //++Задача 4.Заполните двумерный массив 3х3 числами от 1 до 9 змейкой.
            //SnakeFillMatrix(30,25);

            //PrintNumsRec();
            //Console.WriteLine("\n");
            //PrintNums2Rec();
            //Console.WriteLine("\n");
            //SumOfDigitsRec();
            //Console.WriteLine("\n");
            //PowerOfRec();
        }
        private static void Array2DDescendingSortRows(int [,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    int temp = Math.Min(array[i, j], array[i, j + 1]);
                    if (temp < array[i, j + 1]) (temp, array[i, j + 1]) = (array[i, j + 1], temp);  
                }
            }
            Console.WriteLine("Your Array is Sort in Descending Order\n");
            Utility.PrintArray2D(array);
        }
        private static void Array2DFindRowWithMinSum(int [,] array)
        {
            int minSumIndex = 0;
            int prevsum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                if (sum < prevsum) minSumIndex = i;
                prevsum = sum;
            }
            Console.WriteLine($"\nRow with Minimum Sum are {minSumIndex + 1} (For mature coders - index = {minSumIndex})");
        }
        private static void FillAndPrintArray3D()
        {
            int[,,] array = new int[5, 5, 5];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"▬▬▬▬▬▬▬▬▬▬Dimension [{i}]▬▬▬▬▬");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"\t▬▬Dimension [{i}, {j}]▬▬");
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(10, 100);
                        Console.Write($"Element [{i}, {j}, {k}] = {array[i,j,k]}\n");
                    }
                }
            }

        }
        private static void SnakeFillMatrix(int row, int column)
        {
            int[,] matrix = new int[row, column];
            int cellcount = 1;
            int currentcol = 0;

            while(cellcount < matrix.Length)
            {
                if (currentcol == matrix.GetLength(1)) break;
                for (int i = 0; i < matrix.GetLength(0); i++) matrix[i, currentcol] = cellcount++;
                currentcol++;
                if (currentcol == matrix.GetLength(1)) break;
                for (int i = matrix.GetLength(0) - 1; i >= 0; i--) matrix[i, currentcol] = cellcount++;
                currentcol++;
            }
            Utility.PrintArray2D(matrix);
        }
        private static void SpiralFillMatrix(int row, int column)
        {
            int[,] matrix = new int[row, column];

            int cellcount = 1;
            int currentrow = 0;
            int currentcol = 0;
            int stepsrow = row - 1;
            int stepscol = column - 1;
            int count = 0;
            int temp;

            while(cellcount < matrix.Length)
            {
                for (int i = currentcol; i < stepscol; i++)
                {
                    matrix[currentrow, i] = cellcount++;
                    currentcol++;
                }
                for (int i = currentrow; i < stepsrow; i++)
                {
                    matrix[i, currentcol] = cellcount++;
                    currentrow++;
                }
                temp = (currentcol + count) - stepscol;
                for (int i = currentcol; i > temp; i--)
                {
                    matrix[currentrow, currentcol] = cellcount++;
                    currentcol--;
                }
                temp = (currentrow + count) - stepsrow;
                for (int i = currentrow; i > temp; i--)
                {
                    matrix[currentrow, count] = cellcount++;
                    currentrow--;
                }
                count++;
                stepsrow --;
                stepscol --;
                currentcol ++;
                currentrow ++;
            }
            if (matrix.Length % 2 != 0) matrix[currentrow, currentcol] = cellcount;
            Utility.PrintArray2D(matrix);
        }
        private static void ChangeElementsInArray2DWithDiagonal (int [,] array)
        {
            int rowcount = array.GetLength(0) - 1;
            int colcount = array.GetLength(1) - 1;
            int mincount = Math.Min(rowcount, colcount); // За счет этого работает с любой конфигурацией количества строк
            int temp = array[mincount, 0];
            for (int i = 0; i < mincount + 1; i++)
            {
                array[0, i] = array[i, i];
                array[rowcount, i] = array[i, mincount - i];
            }
            array[rowcount, mincount] = temp;
            Utility.PrintArray2D(array);
        }
        private static void FrequencyDictionaryArray2D (int [,] array)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (dictionary.ContainsKey(array[i, j])) dictionary[array[i, j]]++;
                    else dictionary.Add(array[i, j], 1);
                }
            }
            dictionary = dictionary.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value); // Сортировка словаря
            foreach (KeyValuePair<int, int> item in dictionary) Console.WriteLine($"Num {item.Key} encounter {item.Value} times");
        }
        private static void FindCrossOnMinElementAndThrowOut(int[,] array)
        {
            int minRowIndex = 0;
            int minColumnIndex = 0;

            FindMin(array);
            Console.WriteLine($"Min Element index = [{minRowIndex}, {minColumnIndex}]\n");
            
            
            DrawArrayWithEmptyCells(DeleteDiagonals(array, minRowIndex, minColumnIndex));
            
            void FindMin(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < array[minRowIndex,minColumnIndex])
                        {
                            minRowIndex = i;
                            minColumnIndex = j;
                        }
                    }
                }
            }
            void DrawArrayWithEmptyCells(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (j == 0) Console.Write("|   ");
                        if (array[i, j] >= 0 & array[i, j] < 10) Console.Write("0" + array[i, j] + "   |   ");
                        if (array[i, j] >= 10 & array[i, j] < 100) Console.Write(array[i, j] + "   |   ");
                        if (array[i, j] == - 1) Console.Write("  " + "   |   ");
                    }
                    Console.WriteLine();
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        if (k == 0) Console.Write("▬▬▬▬");
                        if (k != array.GetLength(1) - 1) Console.Write("▬▬▬▬▬▬▬▬▬");
                        else Console.Write("▬▬▬▬▬▬");
                    }
                    Console.WriteLine();
                }
            }
            // вариант 1 - кто-то не прочитал условия ;)
            //int[,] DeleteCross(int[,] array, int minRowIndex, int minColumnIndex)
            //{
            //    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
            //    int iMod = 0;
            //    int jMod = 0;
            //    for (int i = 0; i < result.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < result.GetLength(1); j++)
            //        {
            //            if (i == minRowIndex | i > minRowIndex) iMod = 1;
            //            else iMod = 0;
            //            if (j == minColumnIndex | j > minColumnIndex) jMod = 1;
            //            else jMod = 0;
            //            result[i, j] = array[i + iMod, j + jMod];
            //        }
            //    }
            //    return result;

            // вариант 2 - удаление диагоналей и колонки "физически", создавая массив массивов
            //int [][] DeleteDiagonals(int[,] array, int minRowIndex, int minColumnIndex) 
            //{
            //    int shrinkColumns = 1;
            //    int[][] jaggedarray = new int[array.GetLength(0)][];
            //    for (int i = 0; i < jaggedarray.Length; i++)
            //    {
            //        int shrinkCount = 0;

            //        if (i != minRowIndex && minColumnIndex - Math.Abs(minRowIndex - i) >= 0) shrinkColumns++;
            //        if (i != minRowIndex && minColumnIndex + Math.Abs(minRowIndex - i) < array.GetLength(1)) shrinkColumns++;
            //        jaggedarray[i] = new int[array.GetLength(1) - shrinkColumns];
            //        shrinkColumns = 1;

            //        for (int j = 0; j < array.GetLength(1); j++)
            //        {
            //            if (j == minColumnIndex)
            //            {
            //                shrinkCount++;
            //            }
            //            else if (j == minColumnIndex - Math.Abs(minRowIndex - i)
            //                || j == minColumnIndex + Math.Abs(minRowIndex - i))
            //            {
            //                shrinkCount++;
            //            }
            //            else jaggedarray[i][j - shrinkCount] = array[i, j];
            //        }
            //    }
            //    return jaggedarray;
            //}

            // вариант 3 - "скрытие" удаленных ячеек для наглядности
            int[,] DeleteDiagonals(int[,] array, int minRowIndex, int minColumnIndex)
            {
                int[,] result = new int[array.GetLength(0), array.GetLength(1)];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (j == minColumnIndex)
                        {
                            result[i, j] = -1;
                        }
                        else if (j == minColumnIndex - Math.Abs(minRowIndex - i)
                            || j == minColumnIndex + Math.Abs(minRowIndex - i))
                        {
                            result[i, j] = -1;
                        }
                        else result[i,j] = array[i, j];
                    }
                }
                return result;
            }
        }
        //Семинар 9, решения
        private static void PrintNumsRec()
        {
            PrintNums(10);
            void PrintNums(int n)
            {
                if (n == 0) return;
                Console.Write(n + " ");
                PrintNums(n - 1);
            }
        }
        private static void PrintNums2Rec()
        {
            PrintNums2(5, 10);
            void PrintNums2(int m, int n)
            {
                if (m == n + 1) return;
                Console.Write(m + " ");
                PrintNums2(m + 1, n);
            }
        }
        //Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
        //Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
        private static void SumOfDigitsRec()
        {
            Console.WriteLine(SumOfDigits(455));
            int SumOfDigits(int num)
            {
                if (num == 0) return 0;
                else return num % 10 + SumOfDigits(num/10);
            }
        }
        private static void PowerOfRec()
        {
            int num = 10;
            int pow = 3;
            Console.WriteLine(PowerOf(num, pow));
            int PowerOf(int num, int pow)
            {
                if (pow == 1) return num;
                else return num * PowerOf(num, pow - 1);
            }
        }

    }
}
