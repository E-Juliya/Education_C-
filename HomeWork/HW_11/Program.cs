/* Урок 5. Функции продолжение Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] A = new int[new Random().Next(5, 10)];
int S = 0;
RandArray(A);
Console.WriteLine("Заданный маcсив");
PrintArray(A);
Console.WriteLine();
for (int i = 0; i < A.GetLength(0); i++)
{ if (i % 2 == 0) S = S + A[i]; }
Console.Write($"Сумма элементов нечётных позиций = {S}");
void RandArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { array[i] = new Random().Next(1, 10); }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.GetLength(0); i++)
    { Console.Write(array[i] + " "); }
    Console.Write("]"); Console.WriteLine("");
}