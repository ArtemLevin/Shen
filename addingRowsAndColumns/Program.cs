char[,] symb = {{'a', 'b', 'c', 'd', 'e'},{'f','g','h','k','l'}};
Console.WriteLine("Initial array: ");
for (int i =0; i < symb.GetLength(0); i++)
{
    for (int j =0; j < symb.GetLength(1); j++)
    {
        Console.Write(symb[i,j] + " ");
    }
    Console.WriteLine(" ");
}


Random rnd = new Random();
int row = rnd.Next(symb.GetLength(0)+1);
int col = rnd.Next(symb.GetLength(1)+1);

Console.WriteLine("Adding {0} row and {1} column", row, col);

char[,] tmp = new char[symb.GetLength(0)+1, symb.GetLength(1)+1];
int a, b;
char s = 'q';
for (int i = 0; i<symb.GetLength(0); i++)

{
    if(i<row) a = i;
    else a = i + 1;
    for (int j = 0; j < symb.GetLength(1); j++)
    {
        if (j<col) b = j;
        else b = j + 1;
        tmp[a,b] = symb[i,j];
    }
}

for (int j = 0; j <tmp.GetLength(1); j++)
{
    tmp[row,j] = s;
    s++;
}
for (int i = 0; i < tmp.GetLength(0); i++)
{
    if(i!=row)
    {
        tmp[i,col] = s;
        s++;
    }
}

symb = tmp;
Console.WriteLine("New array");
for (int i =0; i < symb.GetLength(0); i++)
{
    for (int j =0; j < symb.GetLength(1); j++)
    {
        Console.Write(symb[i,j] + " ");
    }
    Console.WriteLine(" ");
}

