/*Урок 7. Как не нужно писать код. Часть 1.
Задача 50. Напишите программу, которая на вход принимает позиции элемента в
двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.WriteLine("Введите № строки массива ");
int K = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите № столбца массива ");
int L = Convert.ToInt32(Console.ReadLine());
int[,] Matrix1 = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
ArrayRandMatrix(Matrix1);
Console.WriteLine("Маcсив");
PrintMatrix(Matrix1);
Console.WriteLine();
if (K > Matrix1.GetLength(0) || L > Matrix1.GetLength(1)) 
{Console.WriteLine("Такого элемента нет в массиве");}
else {Console.Write($" Maxrix[{K},{L}] = {Matrix1[K-1, L-1]}");}

void ArrayRandMatrix(int[,] array)
{    for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < array.GetLength(1); j++)
        {array[i, j] = new Random().Next(1, 10); }
    }}

void PrintMatrix(int[,] array)
{    for (int i = 0; i < array.GetLength(0); i++)
    {  Console.Write("[ ");  for (int j = 0; j < array.GetLength(1); j++)
        {   Console.Write(array[i, j] + " ");        }
        Console.Write("]"); Console.WriteLine("");
    }}
