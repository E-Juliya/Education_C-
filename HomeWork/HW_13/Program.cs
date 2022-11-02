/* Урок 7. Как не нужно писать код. Часть 1.
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.WriteLine("Введите размерность матриц ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] Matrix1 = new int[size, size];
int[,] Matrix2 = new int[size, size];
int[,] Matrix3 = new int[size, size];
ArrayRandMatrix(Matrix1);
ArrayRandMatrix(Matrix2);
Console.WriteLine("Матрица 1");
PrintMatrix(Matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2");
PrintMatrix(Matrix2);
Console.WriteLine();

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int y = 0; y < size; y++)
        { Matrix3[i, j] = Matrix3[i, j] + (Matrix1[i, y] * Matrix2[y, j]); }
    }
}

Console.WriteLine("Произведение матриц 1 и 2 равно ");
PrintMatrix(Matrix3);

void ArrayRandMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { array[i, j] = new Random().Next(1, 10); }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ "); for (int j = 0; j < array.GetLength(1); j++)
        { Console.Write(array[i, j] + " "); }
        Console.Write("]"); Console.WriteLine("");
    }
}
