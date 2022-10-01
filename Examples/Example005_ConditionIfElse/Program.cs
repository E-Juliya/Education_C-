Console.Write("Введите имя пользователя^ ");
string username = Console.ReadLine();

if(username.ToLower() == "juliya")
{
    Console.WriteLine("Ура, это же Juliya!"); 
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}