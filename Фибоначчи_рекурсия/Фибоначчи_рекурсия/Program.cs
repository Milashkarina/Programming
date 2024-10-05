using System;

class Program
{
    private static long Fib(long n)
    {
        if (n == 0|| n == 1)
        {
            return n;
        }
        else
        {
            return Fib(n - 1)+Fib(n-2);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("n = ");
        long n = (long)Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine($"Число Фибоначчи {n} : {Fib(n)}");

    }
}