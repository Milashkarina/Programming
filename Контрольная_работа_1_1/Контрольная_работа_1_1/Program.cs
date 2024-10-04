using System;

namespace OutPut
{
    public class Program
    {
        static double Factorial(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else
            {
                return Factorial(n - 1) * n;
            }

        }

        public static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToUInt32(Console.ReadLine());
            double rez = x - ((Math.Pow(x, 3)) / (Factorial(3))) + ((Math.Pow(x, 5)) / (Factorial(5))) - ((Math.Pow(x, 7)) / (Factorial(7))) + ((Math.Pow(x, 9)) / (Factorial(9))) - ((Math.Pow(x, 11)) / (Factorial(11))) + (((Math.Pow(x, 13)) / (Factorial(13))));
            Console.WriteLine($"Результат выражения  равен {rez}");

        }
    }
}
