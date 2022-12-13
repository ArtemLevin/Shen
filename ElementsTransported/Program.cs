int [] CreateArray(int number)
{
    int [] array = new int[number];
    int i = 0;
    while (i < number)
    {
        array[i] = new Random().Next(100,1000);
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

Console.WriteLine("The computer selects the size of the array... ");
Console.WriteLine("The computer selects the elements of the array... ");
int number = new Random().Next(5,11);
int [] array = new int[number];
array = CreateArray(number);
Console.WriteLine("The computer prints the array... ");
Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");
Console.WriteLine(" ");

int [] Transport(int [] array)
{
    int index = 0;
    int temp;
    while(index <= array.Length/2)
    {
        temp = array[index];
        array[index] = array[array.Length - index-1];
        array[array.Length - index-1] = temp;
        index++;
    }
    return array;
}

Console.WriteLine("The computer is transporting the elements... ");
Console.WriteLine(" ");
PrintArray(Transport(array));