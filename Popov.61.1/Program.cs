// sum of all digits in both arrays
int[] CreateArray(int number)
{
    int[] array = new int[number];
    int i = 0;
    while (i < number)
    {
        array[i] = new Random().Next(10, 100);
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

int sum = 0;
int index = 0;
while (index < arrayCopied.Length)
{
    sum = sum + (arrayCopied[index] / 10) + (arrayCopied[index] % 10);
    index++;
}
Console.WriteLine(" ");
Console.Write("the sum of all the digits of the array is equal to " + sum);