using System;
class FactorialTer
{
   static void Main(string[] args)
   {
     double x1;
     double x2;
     double D;
     double E=0.0001;

    Console.Write("Введите коэффициент a: ");
    double a = Convert.ToSingle(Console.ReadLine());
    Console.Write("Введите коэффициент b: ");
    double b = Convert.ToSingle(Console.ReadLine());
    Console.Write("Введите коэффициент c: ");
    double c = Convert.ToSingle(Console.ReadLine());

    D = Math.Pow(b, 2) - 4 * a * c;

     if (D > 0 & D > E)
      {
       x1 = (-b + Math.Sqrt(D)) / (2 * a);
       x2 = (-b - Math.Sqrt(D)) / (2 * a);
       Console.WriteLine($"Уравнение имеет два решения: {x1}, {x2}");
                
       }
       else if ( D < 0 & D < -E)
       {
            Console.WriteLine($"Уравнение не имеет решение");
        }
       else
       {
        x1 = -b / (2 * a);
        Console.WriteLine($"Уравнение имеет один корень:{x1}");
            
       }
   }
}

