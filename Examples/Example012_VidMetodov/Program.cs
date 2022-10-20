// изучаем виды методов
// вид 1
void Method1()
{
    Console.WriteLine("Автор ...."); // используем, если хотим указать авторство
}
//Method1(); // вызываем нужный метод


// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//идентификатор метода(его имя)
//Method2("Текст сообщения");
//Method2(msg: "Текст сообщения"); //исп какому аргументы какое значение мы хотим указать.
//Нужно, когда методы принимают какое-то количество аргуметов

//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);


//Вид 4
/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}*/
//синтаксис цикла for
string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;

    }
    return result;
}
string res = Method4(10, "qwerty ");
//Console.WriteLine(res);

//таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine();
}