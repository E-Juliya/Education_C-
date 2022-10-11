/* Задача 10: Напишите метод, который принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

double GetValue(string text)
{
    Console.WriteLine(text + " ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

double Index2(double N)
{
double a1 = (N % 100);
double a2 = (N % 10);
double a3 = (a1 - a2) / 10;
return a3;
}

double N = GetValue("Ваше трёхзначное число?");
Index2(N);

Console.WriteLine("Вторая цифра " + Index2(N));