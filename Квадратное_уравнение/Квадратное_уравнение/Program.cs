using System;
using System.Diagnostics.CodeAnalysis;
class FactorialTer
{
   static void Main(string[] args)
   {
     double a;
     double b;
     double c;
     double x1;
     double x2;
     double D;
     double E=0.0001;

    Console.Write("Введите коэффициент a (ввод без знака минуса): ");
     a = Convert.ToSingle(Console.ReadLine());
    Console.Write("Введите коэффициент b (ввод без знака минуса): ");
     b = Convert.ToSingle(Console.ReadLine());
    Console.Write("Введите коэффициент c (ввод без знака минуса): ");
     c = Convert.ToSingle(Console.ReadLine());

    D = Math.Pow(b, 2) - 4 * a * c;

        if (a != 0 & c != 0 & b != 0)
        {
            if (D > E)
            {

                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два решения: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет одно решение: x = {x1}");
               
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных решений.");

            }
        }
        else if (b == 0 & a!=0 & c!=0)
        {
            if ((-c / a) > E)
            {
                x1 = Math.Sqrt((-c / a));
                x2 = -(Math.Sqrt((-c / a)));
                Console.WriteLine($"Уравнение имеет два решения: x1 = {x1}, x2 = {x2}");
            }
            else
            {
                Console.WriteLine("Нет решений");
            }
        }
        else if (a!=0 & b!=0 & c == 0 & a > E)
        {
            x1 = b / a;
            x2 = 0;
            Console.WriteLine($"Уравнение имеет два решения: x1 = {x1},x2={x2}");
        }
        else if (b == 0 & c == 0)
        {
            x1 = 0;
            Console.WriteLine($"Уравнение имеет одно решение: x = {x1}");
            
        }
        else
        {
           Console.WriteLine($"Уравнение имеет бесконечное множество решений");
            
        }    



    }
}

