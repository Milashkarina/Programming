using System;

namespace MyTask
{
    class Program
    {
        private static int n;

        public static void Main(string[] args)
        {

            Console.Write($"Введите положительное значение n:");
            n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
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
