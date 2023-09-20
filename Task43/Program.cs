// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите k1");
Double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b2");
Double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите k2");
Double k2 = Convert.ToDouble(Console.ReadLine());

Double X = (b2-b1)/(k1-k2);
Double Y = k1*X+b1; 
Console.WriteLine("x=" + X);
Console.WriteLine("y=" + Y);