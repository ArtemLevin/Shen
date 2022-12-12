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

Console.Write("Enter masiive length ");
int number = int.Parse(Console.ReadLine()!);

// PrintArray(CreateArray(number));

int NumberOfElements(int [] array, int k)
{
    int i = 0; 
    int j = 0;
    while(i < array.Length)
    {
        if (array[i] == k)
        {
            j++;
        }
        i++;
    }
    return j;
}

Console.Write($"Found {NumberOfElements(CreateArray(number), 0)} elements of massive equal 0");