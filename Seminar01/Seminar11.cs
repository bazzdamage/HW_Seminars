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
            int[,] knightBoard = new int[8, 8];
            ////Задача 1.На вход подуются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].
            //int a = 100;
            //int b = 20;
            //var array = Utility.GetRndNumsArray(10, Math.Min(a, b), Math.Max(a, b), 0);
            //Utility.PrintArray(array);
            //Console.WriteLine();
            ////Задача 2.Двумерный массив заполнен случайными натуральными числами от 1 до 10.Найдите количество элементов, значение которых больше 5, и их сумму.
            //CountOfElementsAndSum(array, 50);

            ////Задача 3.Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет.
            //int year = 1992;
            //Console.Write($"\nIs Year {year} are Leap?\nAnswer is: ");
            //Console.WriteLine(IsYearLeap(year));
            //int year2 = 1700;
            //Console.Write($"\nIs Year {year2} are Leap?\nAnswer is: ");
            //Console.WriteLine(IsYearLeap(year2));
            //int year3 = 2000;
            //Console.Write($"\nIs Year {year3} are Leap?\nAnswer is: ");
            //Console.WriteLine(IsYearLeap(year));

            //int[,] array = Utility.GetRndNumsArray2D(5, 5, -5, 5);
            //Arrray2Array(array);

            //Доп.задачи
            //Задача 1.Двумерная матрица заполнена натуральными числами. Найти тройку чисел, для которых площадь треугольника со сторонами, определяемыми данной тройкой, будет максимальна.

            //Задача 2.Шахматный конь стоит на поле с координатами(x1, y1). Сколько ходов ему потребуется сделать, чтобы забрать неподвижную фигуру на поле(x2, y2)?
            LeePathForKnight(knightBoard, 0, 0, 5, 5);
            //Задача 3.Дан отсортированный по возрастанию двумерный массив Matrix.На вход подаётся число A.
            //Напишите метод, реализующий поиск в массиве элементов, равных A.Выведите координаты элемента(при выводе нумерация строк и столбцов считается с единицы).

        }
        class Point
        {
            public int row { get; set; }
            public int column { get; set; }

            public Point(int x, int y)
            {
                this.row = x;
                this.column = y;
            }

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
        static void Arrray2Array(int [,] array)
        {
            Utility.PrintArray2D(array);
            int countC = 0;
            //int countR = 0;
            //int[][] jaggedresult = new int[array.GetLength(0)][];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0) countC++;
                }
                countC++;
            }
            Console.WriteLine($"countC = {countC}");
            int[] result = new int[countC];
            int temp = 0;
            int countnull = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        result[temp++] = array[i, j];
                    }
                }
                if (i < array.GetLength(1) - 1)
                {
                    result[temp] = 0;
                    if (temp > 0 & result[temp - 1] == 0) temp++;
                    else
                    {
                        countnull++;
                        temp++;
                    }
                }
            }
            Utility.PrintArray(result);

            int templength = 0;
            int temprows = 0;
            int tempprint = 0;
            Console.WriteLine(countnull);
            Console.WriteLine();
            int[][] jaggedresult = new int[countnull][];
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                {
                    templength++;
                }
                else
                {
                    if (i > 0 & result[i - 1] == 0) continue;
                    else jaggedresult[temprows++] = new int[templength];
                    Console.WriteLine($"{temprows} | {templength}\n");
                    templength = 0;
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine(jaggedresult.GetLength(0));
            Console.WriteLine(jaggedresult.Length);
            Console.WriteLine();
            for (int i = 0; i < jaggedresult.Length; i++)
            {
                for (int j = 0; j < jaggedresult[i].Length; j++)
                {
                    if(result[tempprint] != 0) jaggedresult[i][j] = result[tempprint++];
                    else tempprint++;
                }
            }
                Utility.PrintArray2D(jaggedresult);
        }

        private static int[,] MatrixForLee(int[,] matrix)              // Generate walls outside the initial matrix
        {
            int[,] leematrix = new int[matrix.GetLength(0) + 2, matrix.GetLength(1) + 2];

            for (int i = 0; i < leematrix.GetLength(0); i++)
            {
                for (int j = 0; j < leematrix.GetLength(1); j++)
                {
                    if (i == 0 | i == leematrix.GetLength(0) - 1) leematrix[i, j] = -2;
                    else if (j == 0 | j == leematrix.GetLength(1) - 1) leematrix[i, j] = -2;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) leematrix[i + 1, j + 1] = -1;
                    if (matrix[i, j] == 1) leematrix[i + 1, j + 1] = -2;
                }
            }
            return leematrix;
        }
        private static void LeePathForKnight(int[,] matrix, int startrow, int startcol, int endrow, int endcol)
        {

            matrix = MatrixForLee(matrix); //Generate new complex matrix with wall
            List<Point> oldWave = new List<Point>();
            List<Point> newWave = new List<Point>();
            Point start = new Point(startrow + 1, startcol + 1);
            Point end = new Point(endrow + 1, endcol + 1);

            matrix[start.row, start.column] = 0;
            oldWave.Add(start);
            bool finishIsReached = false;

            Console.WriteLine($"start = {start.row} | {start.column}");
            Console.WriteLine($"end = {end.row} | {end.column}");

            while (finishIsReached != true & oldWave.Count != 0)
            {
                foreach (Point p in oldWave)
                {
                    WaveFromPoint(p);
                    if (IsFinish(p)) finishIsReached = true;
                }
                oldWave.Clear();
                foreach (Point p in newWave) oldWave.Add(p);
                newWave.Clear();
            }
            Console.WriteLine();
            DrawMaze(matrix);
            if (finishIsReached) Console.WriteLine($"Labyrinth has solved and Point reach for {matrix[end.row, end.column]} steps");
            else Console.WriteLine("Labyrynth has no Solution");

            List<Point> WaveFromPoint(Point p)
            {
                MoveToPoint(p.row - 2, p.column + 1, p);
                MoveToPoint(p.row - 1, p.column + 2, p);
                MoveToPoint(p.row + 1, p.column + 2, p);
                MoveToPoint(p.row + 2, p.column + 1, p);
                MoveToPoint(p.row + 2, p.column - 1, p);
                MoveToPoint(p.row + 1, p.column - 2, p);
                MoveToPoint(p.row - 1, p.column - 2, p);
                MoveToPoint(p.row - 2, p.column - 1, p);
                return newWave;
            }
            void MoveToPoint(int row, int column, Point initialp)
            {
                Point point = new Point(row, column);
                if (IsMoveable(point))
                {
                    matrix[row, column] = matrix[initialp.row, initialp.column] + 1;
                    newWave.Add(point);
                }
            }
            bool IsMoveable (Point p)
            {
                if (p.row < 0 | p.column < 0 | p.row >= matrix.GetLength(0) | p.column >= matrix.GetLength(1))
                    return false;
                if (matrix[p.row, p.column] == -1) return true;
                else return false;
            }
            bool IsFinish(Point p)
            {
                if (p.row == end.row && p.column == end.column) return true;
                else return false;
            }
            void DrawMaze(int[,] matrix)
            {

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {

                        if (j == 0) Console.Write("|   ");
                        if (matrix[i, j] == -2) Console.Write("██   |   ");
                        else if (matrix[i, j] == -1) Console.Write("░░   |   ");

                        else
                        {
                            if (matrix[i, j] < 10) Console.Write("0" + matrix[i, j] + "   |   ");
                            if (matrix[i, j] >= 10 & matrix[i, j] < 100) Console.Write(matrix[i, j] + "   |   ");
                        }
                    }
                    Console.WriteLine();
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (k == 0) Console.Write("▬▬▬▬");
                        if (k != matrix.GetLength(1) - 1) Console.Write("▬▬▬▬▬▬▬▬▬");
                        else Console.Write("▬▬▬▬▬▬");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
