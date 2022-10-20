// Задача: В тексте нужно все пробелы заменить ......

string text = "_Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие русского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
// s[3] // r

string Replece(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replece(text, ' ', '/');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replece(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();