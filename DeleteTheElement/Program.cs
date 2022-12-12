int[] CreateArray(int number)
{
    int[] array = new int[number];
    int i = 0;
    while (i < number)
    {
        Console.Write("Enter a number ");
        array[i] = int.Parse(Console.ReadLine()!);
        i++;
    }
    return array;
}

void PrintArray(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i] + " ");
        i++;
    }
}

Console.Write("Enter massive length ");
int number = int.Parse(Console.ReadLine()!);

int[] arrayCopied = new int[number];
arrayCopied = CreateArray(number);

PrintArray(arrayCopied);

Console.WriteLine(" ");

int[] arrayHelp = new int[arrayCopied.Length -1];
int p = 0;
int j = 0;
while (p < arrayCopied.Length-1)
    {
        if(j == 3)
        {
            j++;
        }
        arrayHelp[p] = arrayCopied[j];
        p++;
        j++;
    } 
arrayCopied = arrayHelp; 
PrintArray(arrayHelp);
Console.WriteLine(" ");
PrintArray(arrayCopied);  
