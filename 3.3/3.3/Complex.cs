using System;

namespace ComplexNumbers
{
    class Complex

        // Вводим вещественные переменные real и image
    {
        double _real;
        double _image;

        public Complex(double r, double i)
        {
            _real = r;
            _image = i;
        }

        // Создаем модификатор,который возвращает сумму комплексных чисел
        public static Complex Add(Complex z1, Complex z2)
        {
            return new Complex(z1._real + z2._real, z1._image + z2._image);
        }

        public static Complex operator +(Complex z1, Complex z2)
        {
            return Add(z1, z2);
        }

        // Создаем модификатор,который возвращает разницу комплексных чисел
        public static Complex Substract(Complex z1, Complex z2)
        {
            return new Complex(z1._real - z2._real, z1._image - z2._image);
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            return Substract(z1, z2);
        }

        // Создаем модификатор,который возвращает произведение комплексных чисел
        public static Complex Multiply(Complex z1, Complex z2)
        {
            return new Complex(
                z1._real * z2._real - z1._image + z2._image,
                z1._real * z2._image + z2._real * z1._image);
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            return Multiply(z1, z2);
        }

        public double Abs()
        {
            return Math.Sqrt(_real * _real + _image * _image);
        }

        public override string ToString()
        {
            return $"{_real}+{_image}i";
        }
    }
}