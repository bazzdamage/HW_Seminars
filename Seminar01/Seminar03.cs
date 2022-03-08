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
            int npoints = random.Next(15) + 5;
            Console.WriteLine($"Number of points we must visit: {npoints}");
            Console.WriteLine();
            //int npoints = 3;
            int numofq = random.Next(4) + 1;
            //int numofq = 4;
            int[,] points = new int[npoints,2];
            Console.WriteLine($"Quarter: {numofq}");
            Console.WriteLine();
            if (numofq == 1)
            {
                points = Utility.GetRndNumsArray2D(npoints, 2,  1, 100);
                for (int i = 0; i < points.GetLength(0); i++)
                {
                    points[i, 0] *= -1;
                }
            }
            if (numofq == 2)
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
                if (crossx < 0 && crossy > 0) Console.WriteLine("Crosspoint lies in 1st Quarter");
                if (crossx > 0 && crossy > 0) Console.WriteLine("Crosspoint lies in 2st Quarter");
                if (crossx < 0 && crossy < 0) Console.WriteLine("Crosspoint lies in 3st Quarter");
                if (crossx > 0 && crossy < 0) Console.WriteLine("Crosspoint lies in 4st Quarter");
            }
            
            

            


        }

    }
}
