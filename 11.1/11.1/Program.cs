using System;
using System.IO;


class Test
{
     static void Main(string[] args)
    {   //Указываем путь файла 
        string path = @"..\..\f.txt";
        {
            // Создаем файл
            using (StreamWriter s = File.CreateText(path))
            {
                // Записываем в него  строку
                s.WriteLine("x sin(x)");
                //Вычисляем значение sin с заданным шагом и записываем вычисления  в файл
                for (double i = 0; i <= 1.01f; i += 0.1f)
                {
                    double sin = Math.Sin(i);

                    s.WriteLine($"{i},{sin}");
                }

            }
        }

        Console.WriteLine("Данные успешно записаны в файл");
    }
}