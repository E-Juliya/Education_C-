void FindEven(int N)
{
    int index = 1;
    while (index < N)
    {
        if (index % 2 == 0)
        { Console.WriteLine(index); }
        index++;
    }

}

int GetN()
{
    Console.WriteLine("Ведите число N");
    int N = Convert.ToInt16(Console.ReadLine());
    return N;
}
int result = GetN();
FindEven(result); 