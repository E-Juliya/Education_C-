/*Урок 5. Функции продолжение Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
ArrayRandom(nums);
Console.WriteLine("Вот наш массив: ");
PrintArray(nums);
int Nmin = nums[0];
int Nmax = nums[0];
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] > Nmax) Nmax = nums[i];
    else { if (nums[i] < Nmin) Nmin = nums[i]; }
}
int diff = Nmax - Nmin;
Console.WriteLine($"Nmax = {Nmin}, Nmax = {Nmax}, разница между Nmax и Nmax равна {diff}");
void ArrayRandom(int[] nums)
{
    for (int r = 0; r < nums.Length; r++)
    {
        nums[r] = new Random().Next(0, 100);
    }
}
void PrintArray(int[] nums)
{
    Console.Write("[ ");
    for (int r = 0; r < nums.Length; r++)
    {
        Console.Write(nums[r] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
