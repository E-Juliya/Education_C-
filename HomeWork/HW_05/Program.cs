/* Задача 10: Напишите метод, который принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трёхзначное число"); 
string a = Console.ReadLine();

NewMethod(SecondNumber);

static void NewMethod(string a)
{
    //for (int i = 0; i < str.Length; i++)
    //{
    Console.WriteLine("Вторая цифра числа: " + a[1]);
    //}
    //Console.ReadKey();
}
