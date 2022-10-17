/* Задача 13: Напишите метод, который выводит третью цифру заданного числа 
 или сообщает, что третьей цифры нет.
645 -> 6
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Введите любое число: N = ");

ThirdMethod(); ;
void ThirdMethod()
{
    int N = Convert.ToInt32(Console.ReadLine());
    int J;
    if (N < 100)
        Console.WriteLine("Третьей цифры числа нет");
    else
    {
        for (int i = 0; N > 1000; i++)
        { N = N - 1000; }
        for (J = 0; N > 100; J++)
        { N = N - 100; }
        Console.Write("Третья цифра введённого числа = ");
        Console.Write(J);
    }
}