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

static void task13(int num)
    {

        if(num.ToString().Length>=3)
        {
            System.Console.WriteLine($" Третья цифра {num.ToString()[2]}");
        }
        else   Console.WriteLine("Третьего числа нет");
    }

    */
    double GetValue(string text)
{
    Console.WriteLine(text + " ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}



double Index2(double N)
{
double a1 = (N % 100);
double a2 = (N % 10);
double a3 = (a1 - a2) / 10;
return a3;
}

double N = GetValue("Ваше трёхзначное число?");
Index2(N);

Console.WriteLine("Вторая цифра " + Index2(N));