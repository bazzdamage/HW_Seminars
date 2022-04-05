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
            PascalTriangle();
            
                        
        }
        private static void PascalTriangle()
        {
            int rowsTriangle = 13;
            int[][] array = new int[rowsTriangle][];
            array[0] = new int[1] { 1 };

            for (int i = 1; i < array.Length; i++)
            {
                array[i] = new int[i + 1];
                int rowLength = array[i].Length;

                for (int j = 0; j < rowLength; j++)
                {
                    if (j == 0 || j == rowLength - 1)
                    {
                        array[i][j] = 1;
                    }
                    else
                    {
                        array[i][j] = array[i - 1][j - 1] + array[i - 1][j];
                    }
                }
            }
            PrintArray(array);
            static void PrintArray(int[][] array)
            {
                int length = array.Length;

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        if (j == 0)
                        {
                                IEnumerable<string> space2 = Enumerable.Repeat("\t", (length - i - 1) / 2);
                                foreach (String str in space2)
                                {
                                    Console.Write(str);
                                }
                        }
                        if (j == array[i].Length / 2 && i % 2 != 0) Console.Write("\t");
                        
                        Console.Write(array[i][j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("------------------------------------------------");
            }

        }
        
    }
}
