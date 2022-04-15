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
            int number = 3456;
            //ReverseNumberRecursive(number);
            //SequenceOfNumbers(10);
            //SimpleMultiplyers(10);
            //AxorB();
            
        }
        
        static void ReverseNumberRecursive(int currentNum, int result = 0)
        {
            if(currentNum == 0)
            {
                Console.Write(" >> " + result);
                return;
            }
            result = result * 10 + currentNum % 10;
            currentNum /= 10;
            ReverseNumberRecursive(currentNum, result);
        }
        static void SequenceOfNumbers(int countAll, int currentNum = 1, int countNum = 0)
        {
            if (countAll == 0) return;
            countAll--;
            countNum++;
            if (currentNum < countNum)
            {
                currentNum++;
                countNum = 1;
            }
            Console.WriteLine(currentNum + "\t");
            SequenceOfNumbers(countAll, currentNum, countNum);
        }
        static void SimpleMultiplyers(int currentNum, int mult = 1)
        {
            if (currentNum == 1) return;
            mult++;
            if (currentNum % mult == 0)
            {
                Console.Write(mult + "\t");
                currentNum /= mult;
                mult = 1;
            }
            SimpleMultiplyers(currentNum, mult);

        }
        static void AxorB()
        {
            int[] arrayA = { 1, 3, 5, 7 };
            int[] arrayB = { 4, 5, 6, 7 };
            int[] result = new int[arrayA.Length + arrayB.Length];
            int resultcount = 0;
            bool flag = false;

            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    if (arrayA[i] != arrayB[j])
                    {
                        result[resultcount] = arrayB[j];
                        resultcount++;
                    }
                    if (arrayA[i] == arrayB[j]) flag = true;
                }
                if (flag == false)
                {
                    result[resultcount] = arrayA[i];
                    resultcount++;
                }
            }
            Utility.PrintArray(result);
        }
        static void ReplaceElements()
        {
            int[] arrayA = {};
        }
    }
}
