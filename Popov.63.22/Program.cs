// Ввести массив, состоящий из 10-ти элементов целого типа. 
// Сформировать новый, расположив сначала все отрицательные элементы и нули,
// после чего - положительные, сохраняя порядок их следования.

int[] CreateArray(int number)
{

    int[] array = new int[number];
    int i = 0;
    while (i < number)
    {
        array[i] = new Random().Next(-100, 100);
        i++;
    }
    return array;
}

void PrintArray(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(" " + array[i] + " ");
        i++;
    }
}

int[] DeleteTheElement(int[] array, int index)
{
    int[] arrayHelp = new int[array.Length - 1];
    int p = 0;
    int j = 0;
    while (p < array.Length - 1)
    {
        if (j == index)
        {
            j++;
        }
        arrayHelp[p] = array[j];
        p++;
        j++;
    }
    array = arrayHelp;
    // PrintArray(arrayHelp);
    // Console.WriteLine(" ");
    // PrintArray(array);  
    return array;
}

Console.Write("Enter array length ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[number];
array = CreateArray(number);

Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");


int index = 0;
int i = 0;
int count = 0;
while (index < array.Length)
{
    if (array[index] < 0)
    {
        int[] arrayTwo = new int[array.Length - 1];
        arrayTwo = DeleteTheElement(array, index);
        array[count] = array[index];
        i = count + 1;
        while (i < array.Length)
        {
            array[i] = arrayTwo[i - 1];
            i++;
        }
        count++;
    }
    index++;
}
Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");