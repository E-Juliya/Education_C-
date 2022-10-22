/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
Polindrom(); 
void Polindrom()
{
    int N = Convert.ToInt32(Console.ReadLine());
    int J5, J4, J3, J2, J1;
    if (N > 99999)
        Console.WriteLine("Число больше пяти знаков");
    else
    {if (N < 10000)
     Console.WriteLine("Число меньше пяти знаков");
    else
    {    for (J5 = 0; N > 10000; J5++)
        { N = N - 10000; }
        for (J4 = 0; N > 1000; J4++)
        { N = N - 1000; }
        for (J3 = 0; N > 100; J3++)
        { N = N - 100; }
        for (J2 = 0; N > 10; J2++)
        { N = N - 10; }
        for (J1 = 0; N > 0; J1++)
        { N = N - 1; }
        if (J5 == J1)
        if (J4 == J2)
        Console.WriteLine("Число является полиндромом");
    else
    Console.WriteLine("Число не является полиндромом");
    else
           Console.WriteLine("Число не является полиндромом");
           }           }
        
}
