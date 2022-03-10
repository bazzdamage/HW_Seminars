using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    internal class Seminar03
    {
        public static void Seminar03Solution()
        {
            //PalindromeNum(Utility.UserInputINT()); //Solution for Problem 01
            //CalcDistanceBetween2Points3D(); //Solution for Problem 02
            //TableOfCube(Utility.UserInputINT()); //Solution for Problem 03
            //MinimalPathForNpoints(); //Solution for Add.Problem 01 and 03
            //IntersectionOf2Lines(); //Solution for Add.Problem 02 and 04
            //SeasonHighLowTemp(); //Soltion for Add.Problem 05
            //GeneratePassN(); //Solution for Add.Problem 06
        }
        private static void PalindromeNum(int num)
        {
            int newnum = 0;
            int oldnum = num;

            while (num > 0)
            {
                newnum = newnum * 10 + (num % 10);
                num /= 10;
            }

            Console.WriteLine($"Your number: {oldnum}");
            if (newnum == oldnum) Console.WriteLine("Your Number is Palindrome!!!");
            else Console.WriteLine("Your Number is not Palidrome!!!");
            Console.WriteLine($"Reversed Number is: {newnum}");
        }
        private static void CalcDistanceBetween2Points3D()
        {
            Console.WriteLine("Please input coordinates of point A [x;y;z]");
            int aX = Utility.UserInputINT();
            int aY = Utility.UserInputINT();
            int aZ = Utility.UserInputINT();
            Console.WriteLine($"Point A: [{aX};{aY};{aZ}]");
            Console.WriteLine("Please input coordinates of point B [x;y;z]");
            int bX = Utility.UserInputINT();
            int bY = Utility.UserInputINT();
            int bZ = Utility.UserInputINT();
            double distanceAB;
            Console.WriteLine($"Point A [{aX}; {aY}; {aZ}]");
            Console.WriteLine($"Point B [{bX}; {bY}; {bZ}]");
            distanceAB = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY) + (aZ - bZ) * (aZ - bZ));
            Console.WriteLine($"Distance between A and B are: {distanceAB}");
        }
        private static void TableOfCube(int n)
        {
            for (int i = 1; i <= n; i++)        
            {
                Console.WriteLine($"{i}^3 = " + i * i * i);
            }
        }
        private static void MinimalPathForNpoints()
        {
            Random random = new Random();
            int npoints = random.Next(5) + 5;
            Console.WriteLine($"Number of points we must visit: {npoints}");
            Console.WriteLine();
            //int npoints = 3;
            int numofq = random.Next(4) + 1;
            //int numofq = 4;
            int[,] points = new int[npoints,2];
            Console.WriteLine($"Quarter: {numofq}");
            Console.WriteLine();
            if (numofq == 2)
            {
                points = Utility.GetRndNumsArray2D(npoints, 2,  1, 100);
                for (int i = 0; i < points.GetLength(0); i++)
                {
                    points[i, 0] *= -1;
                }
            }
            if (numofq == 1)
            {
                points = Utility.GetRndNumsArray2D(npoints, 2, 1, 100);
            }
            if (numofq == 3)
            {
                points = Utility.GetRndNumsArray2D(npoints, 2, 1, 100);
                for (int i = 0; i < points.GetLength(0); i++)
                {
                    for (int j = 0; j < points.GetLength(1); j++)
                    {
                        points[i, j] *= -1;
                    }
                }
            }
            if (numofq == 4)
            {
                points = Utility.GetRndNumsArray2D(npoints, 2, 1, 100);
                for (int i = 0; i < points.GetLength(0); i++)
                {
                    for (int j = 1; j < points.GetLength(1); j++)
                    {
                        points[i, j] *= -1;
                    }
                }
            }
            Console.WriteLine("Points [x ; y]");
            Console.WriteLine();
            Utility.PrintArray2D(points);
            Console.WriteLine();
            Console.WriteLine("Find Distances for points from O");
            int[] distances = new int[npoints];
            for (int i = 0; i < npoints; i++)
            {
                distances[i] = (int)Math.Sqrt((points[i,0] * points[i,0]) + (points[i, 1] * points[i, 1]));
            }
            Utility.PrintArray(distances);
            Console.WriteLine("And...");
            Console.WriteLine("...Sorting points in order of increasing distance to them");
            Array.Sort(distances);
            Utility.PrintArray(distances);
        }

        private static void IntersectionOf2Lines()
        {
            Random random = new Random();
            double ax = random.NextDouble() * 10;
            double ay = random.NextDouble() * 10;
            double bx = random.NextDouble() * 10;
            double by = random.NextDouble() * 10;
            double cx = random.NextDouble() * 10;
            double cy = random.NextDouble() * 10;
            double dx = random.NextDouble() * 10;
            double dy = random.NextDouble() * 10;
            double crossx;
            double crossy;
            Console.WriteLine($"Line AB : ");
            Console.WriteLine($"[{ax} ; {ay}] | [{bx} ; {by}]");
            Console.WriteLine($"Line CD : ");
            Console.WriteLine($"[{cx} ; {cy}] | [{dx} ; {dy}]");
            Console.WriteLine();

            double a1 = by - ay;
            double b1 = ax - bx;
            double c1 = -ax * by + ay * bx;

            double a2 = dy - cy;
            double b2 = cx - dx;
            double c2 = -cx * dy + cy * dx;

            if ((a1 * b2 - a2 * b1) == 0) Console.WriteLine("Lines are Parallel, point of Intersection not exist");
            else if (a1 * b2 == b1 * a2 && a1 * c2 == a2 * c1 && b1 * c2 == c1 * b2) Console.WriteLine("lines coincide and have an infinite number of solutions");
            else
            {
                if ((a1 * a2 + b1 * b2) == 0) Console.WriteLine("Lines are perpendicular to each other");
                crossx = (b1 * c2 - b2 * c1) / (a1 * b2 - a2 * b1);
                crossy = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);
                Console.WriteLine($"Lines crosses in point [{crossx} ; {crossy}]");
                if (crossx < 0 && crossy > 0) Console.WriteLine("Crosspoint lies in 2st Quarter");
                if (crossx > 0 && crossy > 0) Console.WriteLine("Crosspoint lies in 1st Quarter");
                if (crossx < 0 && crossy < 0) Console.WriteLine("Crosspoint lies in 3st Quarter");
                if (crossx > 0 && crossy < 0) Console.WriteLine("Crosspoint lies in 4st Quarter");
            }
            
            

            


        }
        private static void SeasonHighLowTemp()
        {
            //Задача 5. Дан массив средних температур (массив заполняется случайно) за последние 10 лет. На ввод подают номер месяца и год начали и конца.
            //Определить самые высокие и низкие температуры для лета, осени, зимы и весны в заданном промежутке.Если таких температур нет, сообщить, что определить не удалось.

            int yearrange = 10;
            int[] array = Utility.GetRndNumsArray(yearrange * 12, 0, 60, -30);
            int wintermax = int.MinValue;
            int wintermin = int.MaxValue;
            int springmax = int.MinValue;
            int springmin = int.MaxValue;
            int summermax = int.MinValue;
            int summermin = int.MaxValue;   
            int autumnmax = int.MinValue;
            int autumnmin = int.MaxValue;

            Console.WriteLine("Please enter start year (from 1 to 10) for measurement range");
            int startyear = Utility.UserInputINTRange(1, 10);
            Console.WriteLine("Please enter end year(from 1 to 10) for measurement range");
            int endyear = Utility.UserInputINTRange(1, 10);
            Console.WriteLine("Please enter start month (from 1 to 12) for measurement range");
            int startmonth = Utility.UserInputINTRange(1, 12);
            int countmonth = startmonth;
            
            for (int i = ((startyear-1)*12); i < array.GetLength(0) - ((yearrange-endyear)*12); i++)
            {
                if (countmonth >= 1 & countmonth <= 2 | countmonth == 12)
                {
                    if (array[i] > wintermax) wintermax = array[i];
                    if (array[i] < wintermin) wintermin = array[i];
                }
                if (countmonth >= 3 & countmonth <= 5)
                {
                    if (array[i] > springmax) springmax = array[i];
                    if (array[i] < springmin) springmin = array[i];
                }
                if (countmonth >= 6 & countmonth <= 8)
                {
                    if (array[i] > summermax) summermax = array[i];
                    if (array[i] < summermin) summermin = array[i];
                }
                if (countmonth >= 9 & countmonth <= 11)
                {
                    if (array[i] > autumnmax) autumnmax = array[i];
                    if (array[i] < autumnmin) autumnmin = array[i];
                }
                if (countmonth >= 12) countmonth = 1;
                countmonth++;
            }
            Console.WriteLine();
            Utility.PrintArray(array);
            Console.WriteLine();
            Console.WriteLine($"Winter Max Temperature was: {wintermax}");
            Console.WriteLine($"Winter Min Temperature was: {wintermin}");
            Console.WriteLine($"Spring Max Temperature was: {springmax}");
            Console.WriteLine($"Spring Min Temperature was: {springmin}");
            Console.WriteLine($"Summer Max Temperature was: {summermax}");
            Console.WriteLine($"Summer Min Temperature was: {summermin}");
            Console.WriteLine($"Autumn Max Temperature was: {autumnmax}");
            Console.WriteLine($"Autumn Min Temperature was: {autumnmin}");

        }
        private static void GeneratePassN()
        {
            Console.WriteLine("Please enter lenght of Password (Minimum four symbols): ");
            int n = Utility.UserInputINTRange(4, int.MaxValue);
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            sb.Append((char)random.Next(48, 58));
            sb.Append((char)random.Next(65, 91));
            sb.Append((char)random.Next(33, 48));
            sb.Append((char)random.Next(97, 123));

            for (int i = 4; i < n; i++)
            {
                switch (random.Next(1, 5))
                {
                    case 1:
                        sb.Append((char)random.Next(48, 58));
                        break;
                    case 2:
                        sb.Append((char)random.Next(65, 91));
                        break;
                    case 3:
                        sb.Append((char)random.Next(33, 48));
                        break;
                    case 4:
                        sb.Append((char)random.Next(97, 123));
                        break;
                }
            }
            for (int i = sb.Length-1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                char temp = sb[j];
                sb[j] = sb[i];
                sb[i] = temp;
            }
            Console.WriteLine("Your new pass are SO STRONG: ");
            Console.WriteLine(sb.ToString());
        }

    }
}
