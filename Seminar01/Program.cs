namespace Seminar01;

public class Seminar01
{

    public static void Main(String[] args)
    {
        int count = 0;
        int a = 115;
        int b = 18;
        int c = 955;
        dosimpleMath(a, b);
        domanualMath(a, b);
        maxOfThree(a, b, c);
        count = countOfInput();
        int[] numsarray = getArrayofInt(count);
        foreach (int i in numsarray) Console.Write(i + ", ");
        Console.WriteLine("\n" + "Even Numbers are: " + evenNums(numsarray));
        Console.WriteLine(printAllEvenNums());
    }
    private static void dosimpleMath(int a, int b)
    {
        Console.WriteLine("(Variant 1) Max Of 2 nums are: " + Math.Max(a, b));
    }
    private static void domanualMath(int a, int b)
    {
        if (a < b) Console.WriteLine("(Variant 2) Max Of 2 nums are: " + b);
        else Console.WriteLine("(Variant 2) Max Of 2 nums are: " + a);
    }
    private static void maxOfThree(int a, int b, int c)
    {
        int max = 0;
        if (a > b) max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        Console.WriteLine("Max Of 3 nums are: " + max);
    }
    private static int countOfInput()
    {
        Console.WriteLine("How big Array do you want?: ");
        int count = userinputINT();
        return count;
    }
    private static int[] getArrayofInt(int count)
    {
       int[] array = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Please fill Array [ " + (i+1) + "/" + count + " ]" + ": ");
            array[i] = userinputINT();
        }
        return array;
    
    }
    private static int userinputINT()
    {
        int num = 0;
        bool result = false;
        while (result == false)
        {
            Console.WriteLine("Number MUST be integer: ");
            string s = Console.ReadLine();
            result = int.TryParse(s, out num);            
        }

        return num;
    }
    private static string evenNums(int[] array)
    {
        string result = "";
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) result = result + array[i] + " ";
        }
        return result;
    }
    private static string printAllEvenNums()
    {
        Console.WriteLine("Please enter N: ");
        int n = userinputINT();
        string result = "";
        for (int i = 2; i <= n; i+=2)
        {
            result = result + i + " ";
        }
        return result;
    }

}