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

void DeleteTheElement(int [] array, int index)
{
    int[] arrayHelp = new int[array.Length -1];
    int p = 0;
    int j = 0;
    while (p < array.Length-1)
        {
            if(j == index)
            {
                j++;
            }
            arrayHelp[p] = array[j];
            p++;
            j++;
        } 
    array = arrayHelp; 
    PrintArray(arrayHelp);
    Console.WriteLine(" ");
    PrintArray(array);  
}

DeleteTheElement(arrayCopied, 3);
