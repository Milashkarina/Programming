
using System;

namespace OutPut
{
    public class HelloWorld
    {
        //Проверка является ли число простым
        static bool IsPrime(int j)
        {
            // Проверка делимости чисел от 2 до корня из j
            for (int i=2;i*i<=j;i++)
                {
                // Если j делится на i, то это не простое число
                if (j % i == 0)
                    return false;
                }
           return true;
        }

            public static void Main(string[] args)
        {
            Console.Write("n=");
            int n;
            n = Int32.Parse(Console.ReadLine());
            // Сообщение о выводе простых чисел
            Console.Write("Простые числа меньшие {0}:", n);
            // Перебор чисел от 2 до n
            for (int i = 2; i < n; i++)
            {
                // Если число i простое, выводим его на экран
                if (IsPrime(i))
                    Console.Write(" {0}", i);

            }
            Console.WriteLine();
        }
    }
}