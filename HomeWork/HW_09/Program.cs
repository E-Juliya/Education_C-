/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Введите координату Х точки А");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Х точки B");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
double Z2 = Convert.ToDouble(Console.ReadLine());
double S = Convert.ToDouble(Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1)));
//int S = Math.Sqrt((X2-X1)^2+(Y2-Y1)^2+(Z2-Z1)^2);
Console.WriteLine("Расстоние между точками");
//double S = Convert.ToDouble(Math.Sqrt(1.44));
Console.Write(S); 