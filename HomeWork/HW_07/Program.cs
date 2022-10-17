/* Задача 15: Напишите метод, который принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите цифру от 1 до 7:");
int L = Convert.ToInt32(Console.ReadLine());


WeekMethod(L);

void WeekMethod(int L)
{
    if (L > 5)
        Console.WriteLine("Выходной :)");
    else
        Console.WriteLine("Будний день :(");
}
if (L>7)
Console.WriteLine("Цифра не соответствует условиям");