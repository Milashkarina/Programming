using ComplexNumbers;

var z1 = new Complex(2, 3);
var z2 = new Complex(9, 7);



Console.WriteLine($"Первое  число:{z1}");
Console.WriteLine($"Второе комплексное число:{z2}");
Console.WriteLine(Complex.Add(z1, z2));

Console.WriteLine($"Сумма комплексных чисел:{z1 + z2}");
Console.WriteLine($"Разность комплексных чисел: {z1 - z2}");
Console.WriteLine($"Произведение комплексных чисел:{z1 * z2}");
Console.WriteLine($"Деление комплексных чисел:{z1 / z2}");
Console.WriteLine($"Возведение комплексного числа в степень:{z1.Power(4)}");
Console.WriteLine($"Нахождение угла:{z1.Angle()}");
Console.WriteLine($"Модуль комплексного числа:{z1.Abs()}");


Console.ReadKey();


    

    