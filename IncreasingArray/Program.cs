// Ввести массив, состоящий из 12 элементов действительного типа. 
// Расположить элементы в порядке убывания. 
// Вычислить сумму максимального
// и минимального элементов массива.

int[] CreateArray(int number)
{
    int[] array = new int[number];
    int i = 0;
    while (i < number)
    {
        array[i] = new Random().Next(0, 10);
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

Console.WriteLine("The computer selects the size of the array... ");
Console.WriteLine("The computer selects the elements of the array... ");
int numberOne = new Random().Next(5, 11);
int[] arrayOne = new int[numberOne];

arrayOne = CreateArray(numberOne);

Console.WriteLine("The computer prints the first array ... ");
Console.WriteLine(" ");
PrintArray(arrayOne);
Console.WriteLine(" ");
Console.WriteLine(" ");


int [] Ordering (int [] arrayOne)
{
    int index = 0;
    int max = arrayOne[0];
    int k = 0;
    int j = 0;
    while (index < arrayOne.Length)
    {
        j = index + 1;
        max = arrayOne[index];
    
        while(j < arrayOne.Length)
        {
            if(arrayOne[j] > max)
            {
                max = arrayOne[j];
                k = j;
            }

            j++;
        }
        if(index != arrayOne.Length-1 && arrayOne[index] < max)
        {
            int temp = arrayOne[k];
            arrayOne[k] = arrayOne[index];
        arrayOne[index] = temp;
        }
        // PrintArray(arrayOne);
        // Console.WriteLine(" ");
        // Console.WriteLine(" ");
        index++;
    }

    PrintArray(arrayOne);
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}