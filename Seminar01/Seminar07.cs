using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    internal class Seminar07
    {
        public static void Seminar07Solution ()
        {
            double[,] array = Utility.GetRndRealNumsArray2D(10, 4, 100);
            int[,] intarray = Utility.GetRndNumsArray2D(3, 4, 100, 10000);
            int[,] matrix2 = {
                { 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1},
                { 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1},
                { 0, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1},
                { 1, 0, 1, 1, 0, 1, 0, 0, 1, 1, 0, 0},
                { 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0},
                { 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0},
                { 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 1},
                { 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0},
                { 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1} };
    
            //++Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            //Utility.PrintArray2D(array);

            //++Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            //PrintElementIn2DArray(array, 5, 2);    

            //++Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            //MeanOf2DArrayColumns(array);


            //++Задача 1.Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, заполнены числами от - 9 до 9.Выполните умножение матриц.
            //Дополнительный материал по задаче:
            //https://portal.tpu.ru/SHARED/k/KONVAL/Sites/Russian_sites/1/04.htm
            //ProduсtOfTwoMatrices(matrixA, matrixB);

            //++Задача 2.Двумерный массив размером 3х4 заполнен числами от 100 до 9999.
            //Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения.Выведите оба массива.
            //TrickyNumsIn2DArray(intarray);

            //Задача 3.Двумерный массив размером 5х5 заполнен случайными нулями и единицами.
            //Игрок может ходить только по полям, заполненным единицами.
            //Проверьте, существует ли путь из точки[0, 0] в точку[4, 4] (эти поля требуется принудительно задать равными единице).
            //LeePath(matrix2, 0,0,0,4); // Не знаю зачем в простой задаче решил сделать это, но делал в первый раз, когда то надо набивать руку на алгоритмах поиска пути... 8)
            Random rand = new Random();
            int startrow = 2;
            int startcol = 1;
            int endrow = 8;
            int endcol = 10;
            LeePath(matrix2, startrow, startcol, endrow, endcol);
                //Задача 1 *.Создайте игру морской бой:
                //  1) выведете на экран поле 10х10;
                //  2) отрисуйте на поле корабли(1 корабль длиной 4 клетки, 2 корабля длиной 3 клетки, 3 корабля длиной 2 клетки, 4 корабля длиной 1 клетка), на этапе отладки корабли должны быть видны, в последующем они должны быть скрыты;
                //  3) добавьте возможность вводить координаты атакуемого поля, атакованное поле должно пометиться символом “+”, подбитый корабль обозначается знаками “@”;
                //  4) если подбиты все корабли, выводится сообщение о победе.

                //Задача 2 *.Добавить бота в морской бой.



        }
        
        private static bool IsElementIn2DArrayExist(double[,] array, int row, int column)
        {
            if (array.GetLength(0) >= row && array.GetLength(1) >= column) return true;
            else return false;
        }
        private static bool IsProductOfTwoMatricesPossible(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.GetLength(1) == matrixB.GetLength(0)) return true;
            else return false;
        }
        private static void PrintElementIn2DArray(double[,] array, int row, int column)
        {
            if (IsElementIn2DArrayExist(array, row, column) == true)
            {
                Console.WriteLine($"Element [{row}][{column}] = {array[row,column]}");
            }
            else Console.WriteLine($"Element [{row}][{column}] doesn't exist in Array");
        }
        private static void MeanOf2DArrayColumns(double[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j,i];
                }
                Console.WriteLine($"\nMean of row[{i}] = {sum / array.GetLength(0)}");
            }
        }
        private static void ProduсtOfTwoMatrices(int [,] matrixA, int [,] matrixB)
        {

            if (IsProductOfTwoMatricesPossible(matrixA, matrixB))
            {
                int matrixArows = matrixA.GetLength(0);
                int matrixAcolumns = matrixA.GetLength(1);
                int matrixBrows = matrixB.GetLength(0);
                int matrixBcolumns = matrixB.GetLength(1);
                int[,] result = new int[matrixArows, matrixBcolumns];

                for (int i = 0; i < matrixArows; i++)
                {
                    for (int j = 0; j < matrixBcolumns; j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < matrixAcolumns; k++)
                        {
                            sum += matrixA[i, k] * matrixB[k, j];
                        }
                        result[i, j] = sum;
                    }
                }
                Utility.PrintArray2D(matrixA);
                Console.WriteLine("\n\tX\n");
                Utility.PrintArray2D(matrixB);
                Console.WriteLine("\n Product of Matrix A and Matrix B are = \n");
                Utility.PrintArray2D(result);

            }
            else Console.WriteLine("Matrix A number of rows and columns are not equal to Matrix B, Product not defined");
            
        }
        private static void TrickyNumsIn2DArray(int[,] array)
        {
            Utility.PrintArray2D(array);
            List<int> list = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                        int temp = array[i,j];
                        int sum = 0;
                        int product = 1;
                        while (temp > 0)
                        {
                            sum += (temp % 10);
                            product *= (temp % 10);
                            temp /= 10;
                        }
                        if (sum > product) list.Add(array[i,j]);
                }
            }
            int[] result = list.ToArray();
            Console.WriteLine();
            Utility.PrintArray(result);
            
        }
        private static int[,] MatrixForLee (int[,] matrix)              // Generate walls outside the initial matrix
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
                    if (matrix[i,j] == 0) leematrix[i + 1,j + 1] = -1;
                    if (matrix[i, j] == 1) leematrix[i + 1, j + 1] = -2;
                }
            }
            return leematrix;
        }
        class Point
        {
            public int row;
            public int column;
            
            public Point (int x, int y)
            {
                this.row = x;
                this.column = y;
            }
        }                                                 
        private static void LeePath (int [,] matrix, int startrow, int startcol, int endrow, int endcol)
        {

            matrix = MatrixForLee(matrix); //Generate new complex matrix with wall
            List<Point> oldWave = new List<Point>();
            List<Point> newWave = new List<Point>();
            Point start = new Point(startrow + 1, startcol + 1);
            Point end = new Point(endrow + 1, endcol + 1);
                       
            matrix [start.row, start.column] = 0;
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
                if (matrix[p.row - 1, p.column] == -1)
                {
                    matrix[p.row - 1, p.column] = matrix[p.row, p.column] + 1;
                    Point point = new Point(p.row - 1, p.column);
                    newWave.Add(point);
                }
                if (matrix[p.row + 1, p.column] == -1)
                {
                    matrix[p.row + 1, p.column] = matrix[p.row, p.column] + 1;
                    Point point = new Point(p.row + 1, p.column);
                    newWave.Add(point);
                }
                if (matrix[p.row, p.column - 1] == -1)
                {
                    matrix[p.row, p.column - 1] = matrix[p.row, p.column] + 1;
                    Point point = new Point(p.row, p.column - 1);
                    newWave.Add(point);
                }
                if (matrix[p.row, p.column + 1] == -1)
                {
                    matrix[p.row, p.column + 1] = matrix[p.row, p.column] + 1;
                    Point point = new Point(p.row, p.column + 1);
                    newWave.Add(point);
                }
                return newWave;
            }
            bool IsFinish (Point p)
            {
                if (p.row == end.row && p.column == end.column) return true;
                else return false;
            }
            void DrawMaze (int[,] matrix)
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
