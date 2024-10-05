using System;
namespace Program
{
    class FactorialTer
    {
        private static long F(long n)
        {
            long rez = 1;
                for (long i = 1; i <= n; i++)
                {
                     rez *=i;
                }
                return rez;

        }
            static void Main(string[] args)
        {
                Console.Write("n = ");
                long n = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine($"Факториал числа {n} равен {F(n)}");
               
        }
    }
}


