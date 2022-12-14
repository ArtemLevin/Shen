// Ввести массив, состоящий из 14 элементов действительного типа.
// Поменять местами первую половину со второй. Определить количество
// произведенных при этом перестановок.

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

Console.Write("Enter array length ");
int number = int.Parse(Console.ReadLine()!);
int [] array = new int[number];
array = CreateArray(number);
PrintArray(array);
Console.WriteLine(" ");

int [] PermHalf(int [] array)
{
    int index = 0;
    
    while(index<array.Length/2)
    {
        int temp = array[index];
        array[index] = array[(array.Length/2)+index];
        array[(array.Length/2)+index] = temp;
        index++;
    }
    return array;
}

PrintArray(PermHalf(array));
