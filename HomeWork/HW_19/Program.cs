/* Урок 7. Как не нужно писать код. Часть 1.
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] Matrix1 = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
double[] Sum = new double[Matrix1.GetLength(1)];
ArrayRandMatrix(Matrix1);
Console.WriteLine("Заданный маcсив");
PrintMatrix(Matrix1);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбцов");

for (int j = 0; j < Matrix1.GetLength(1); j++)
{ for (int i = 0; i < Matrix1.GetLength(0); i++)
    { Sum[j] = Sum[j] + (Matrix1[i, j] ); } Sum[j] = Sum[j]/Matrix1.GetLength(1); Console.Write(Math.Round(Sum[j], 2) + " "); 
    } 

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