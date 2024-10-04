using System;

class Program
{
    static long Factorial(long n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return Factorial(n - 1) * n;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("n = ");
        long n = (long)Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine($"Факториал числа {n} равен {Factorial(n)}");

    }
}