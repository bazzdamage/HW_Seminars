namespace Seminar01;

public class Seminar01
{

    public static void Main(String[] args)
    {

        int a = 115;
        int b = 18;
        int c = 955;
        dosimpleMath(a, b);
        domanualMath(a, b);
        maxOfThree(a, b, c);
    }

    private static void dosimpleMath(int a, int b)
    {
        Console.WriteLine("Максимальное из двух чисел = " + Math.Max(a, b));
    }
    private static void domanualMath(int a, int b)
    {
        if (a < b) Console.WriteLine("Максимальное из двух чисел = " + b);
        else Console.WriteLine("Максимальное из двух чисел = " + a);
    }
    private static void maxOfThree(int a, int b, int c)
    {
        int max = 0;
        if (a > b) max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        Console.WriteLine("Максимальное из трёх чисел = " + max);

    }
}