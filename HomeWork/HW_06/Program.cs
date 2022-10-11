/* Задача 13: Напишите метод, который выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 6
78 -> третьей цифры нет
32679 -> 6

int Number(int number);
{
    else
{
	if (number < 100)
	    {
	        Console.WriteLine("Третьей цифры в числе нет");
	    }
	    while (number > 100)
	    {
	        if (number > 999)
	        {
	            number = number / 10;
	        }
	        else
	        {
	            number = number % 10;
	            Console.WriteLine($"Третья цифра числа = {number}");
	        }
	    }
	    return number;
}
}
//Console.Write("Введите число ");
//int number = int.Parse(Console.ReadLine());
*/
static void task13(int num)
    {

        if(num.ToString().Length>=3)
        {
            System.Console.WriteLine($" Третья цифра {num.ToString()[2]}");
        }
        else   Console.WriteLine("Третьего числа нет");
    }