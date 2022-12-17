Random rnd = new Random();
int size = 10, k;
char[] symbs = new char[size];
for (k = 0; k < symbs.Length; k++)
{
    symbs[k] = (char)('A' + rnd.Next(26));
    Console.Write(symbs[k] + " | ");
}

Console.WriteLine(" ");
int t;
int p;

for (t = 1; t < symbs.Length; t++)
{
    for (p = 0; p < symbs.Length - t; p++)
    {
        if (symbs[p] > symbs[p + 1])
        {
            char temp = symbs[p + 1];
            symbs[p+1] = symbs[p ];
            symbs[p] = temp;
        }
    }
}

int y;

for (y = 0; y < symbs.Length; y++)
{
    Console.Write(symbs[y] + " | ");
}

