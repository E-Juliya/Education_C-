/*Урок 5. Функции продолжение Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
FillArrayRandomNumbers(nums);
Console.WriteLine("Вот наш массив: ");
PrintArray(nums);
int count = 0;
for (int i = 0; i < nums.Length; i++)
if (nums[i] % 2 == 0)
count++;
Console.WriteLine($"всего {nums.Length} чисел, {count} из них чётные");
void FillArrayRandomNumbers(int[] nums)
{
    for(int r = 0; r < nums.Length; r++)
    {
        nums[r] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] nums)
{
    Console.Write("[ ");
    for(int r = 0; r < nums.Length; r++)
    {
        Console.Write(nums[r] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}