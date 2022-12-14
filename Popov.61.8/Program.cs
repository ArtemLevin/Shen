// В заданном целочисленном массиве R(9) определить индекс наибольшего
// из нечетных по значению положительных элементов.


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
int [] array = new int[number];
array = CreateArray(number);
PrintArray(array);
Console.WriteLine(" ");

int index = 0;
int max = 0;
int k = 0;
while(index < array.Length)
{
    if(array[index]%2 != 0 && array[index] > max)
    {
        max = array[index]; 
        k = index;
    }
    index++;
}
Console.WriteLine("index of the largest odd elemnet is " + k);