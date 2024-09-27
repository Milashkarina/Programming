
using System;

namespace OuputUser
{
    class Program
    {
        //Проверка является ли число простым
        
        static bool isPrime(int j)
        {
           for(int i=2;i*i<=j;i++)
                {
                if (j % i == 0)
                    return false;
                }
           return true;
        }

        static void Main(string[] args)
        {
            Console.Write("n=");
            int n;
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Простые числа меньшие {0}:", n);
            for (int i = 2; i < n; i++)
            {
                if (isPrime(i))
                    Console.Write(" {0}", i);

            }
            Console.WriteLine();
        }
    }
}