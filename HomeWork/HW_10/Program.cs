/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N+1; i++)
        { int K=i*i*i; Console.Write(K); Console.Write(" ");}
       // for (J = 0; N > 100; J++)
       // { N = N - 100; }
       // Console.Write("Третья цифра введённого числа = ");
       // Console.Write(J);
