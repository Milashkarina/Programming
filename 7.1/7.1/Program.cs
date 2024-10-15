using System;
using System.Xml.Linq;
namespace Program
{
    class MyProgram
    {
        public static void Main(string[] args)
        {


            try
            {
                Console.Write("Введите значение n: ");
                
                int n = (int)Convert.ToUInt32(Console.ReadLine());
                Console.Write($"Результат: {n}");

                
            }

            catch (FormatException)
            {
                Console.WriteLine("Введено не число");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Ошибка:Число либо слишком большое,либо маленькое.Будьте внимательны!");
            }

        }
    }
}



