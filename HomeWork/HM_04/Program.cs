// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа 
// от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

double GetValue();
{
    Console.Write("от 1 до N: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}
bool IsEven(Double x);

{
    if (x % 2 == 0) ;
    return true;
    else
        return false;
}

double next(double N);
{
    double x -1;
    while (x < N) ;
    {
        if = (IsEven(x));
        System.Console.WriteLine(x);
        x += 1;
    }
    return x;
}

double N - GetValue();
next(N);

