// 22/10/22

/*C = A · B =  
2	2
1	4
  ·  
1	6
1	3
  =  
4	18
5	18
 
Компоненты матрицы С вычисляются следующим образом:
c11 = a11 · b11 + a12 · b21 = 2 · 1 + 2 · 1 = 2 + 2 = 4
c12 = a11 · b12 + a12 · b22 = 2 · 6 + 2 · 3 = 12 + 6 = 18
c21 = a21 · b11 + a22 · b21 = 1 · 1 + 4 · 1 = 1 + 4 = 5
c22 = a21 · b12 + a22 · b22 = 1 · 6 + 4 · 3 = 6 + 12 = 18
*/

// 23.10

string[,] table = new string[2, 5];
// String.Empty
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++) // сколько строк
{
    for (int columns = 0; columns < 5; columns++) // сколько столбцов
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}