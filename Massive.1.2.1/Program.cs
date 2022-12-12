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

int [] ZeroArray(int [] array)
{
    int i = 0;
    while (i < array.Length)
    {
        array[i] = 0;
        i++;
    } 
    return array;
}

PrintArray(ZeroArray(CreateArray(number)));