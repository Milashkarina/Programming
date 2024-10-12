using System;

namespace hometask_2_3
{
    class Program
    {
        private static int n;

        static void Main(string[] args)
        {
            int count = 0;
            Console.Write($"Введите положительное значение n:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                do
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    count++;
                }
                while (n != 1);

                Console.Write($"Количество замен, приводящих к 1:{count}");
            }
            else
            {
                Console.Write("Веденное число либо 0,либо отрицательное!");
            }
                
        }
    }
}