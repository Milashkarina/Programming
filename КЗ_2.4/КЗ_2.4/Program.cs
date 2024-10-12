using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
     static void Main(string[] args)
    {   //Добавление элементов в массив
        Console.Write("Введите количество элементов массива:\t");
        int elements = int.Parse(Console.ReadLine());
        int[] number = new int[elements];
        for (int i = 0; i < number.Length; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
       //Создаем внешний и внутренний циклы перебора чисел
       //Внешний нужен для того,чтобы перестановки были выполнены для всего массива
       //Внутренний сравнивает пары и меняет их местами (после каждой итерации max элемент переходит в конец массива)
       
        for (int i = 0; i < number.Length; i++)
        {
            for (int j = 0; j < number.Length-i-1; j++)
            {
                if (number[j] > number[j+1])
                { 
                    int b = number[j];
                    number[j]=number[j+1];
                    number[j+1]=b;

                }
            }
            
        }
        //Вывод отсортированного массива
        var s = string.Join(" ", number);
        Console.WriteLine($"Отсортированный массив: {s}");


    }

}
    