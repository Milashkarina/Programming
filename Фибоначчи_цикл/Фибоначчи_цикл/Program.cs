using System;
namespace Program
{
    class FactorialTer
    {
        private static long Fub(long n)
        {
            long num1 = 0;
            long num2= 1;
            long rez = 0;
            for (long i = 2; i <= n; i++)
            { // находим сумму двух последних чисел
                rez = num1 + num2;
              //переходим к следующим числам
                num1 = num2;
                num2 = rez;


            }
            return rez;

        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            long n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Число Фибоначчи под номером  {n} равен {Fub(n)}");

        }
    }
}



