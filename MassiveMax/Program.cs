int [] CreateArray(int number)
{
    int [] array = new int[number];
    int i = 0;
    while (i < number)
    {
        Console.Write("Enter a number ");
        array[i] = int.Parse(Console.ReadLine()!);
        i ++;
    }
    return array;
}

void PrintArray(int [] array)
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

int [] arrayCopied = new int[number];
arrayCopied = CreateArray(number);

PrintArray(arrayCopied);

int MassiveMax (int [] array)
{
    int i = 0;
    int max = array[0];
    while(i<array.Length)
    {
        if(array[i]>max)
        {
             max = array[i];
        }
        i++;
    }

    return max;
}

Console.Write(" ");
Console.Write("Max element in array is " + MassiveMax (arrayCopied) );


