using ComplexNumbers;

var z1 = new Complex(2, 3);
var z2 = new Complex(9, 7);



Console.WriteLine(z1);
Console.WriteLine(z2);
Console.WriteLine(Complex.Add(z1, z2));
Console.WriteLine(z1 + z2);
Console.WriteLine(z1.Abs());


Console.ReadKey();