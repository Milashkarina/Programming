using System;

namespace Program
{
    class Hypothesis
    {

        static void Main(string[] args)
        {
           
            Console.Write($"Введите n:");
            int n = Convert.ToInt32(Console.Read());
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
                Console.Write("Либо Вы ввели 0,либо отрицательной число");
            }
           
        }
    }
}