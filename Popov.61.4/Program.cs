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

void Ordering (int [] arrayOne)
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

Console.Write("Enter the first array length ");
int numberOne = int.Parse(Console.ReadLine()!);

int[] arrayOne = new int[numberOne];
arrayOne = CreateArray(numberOne);
PrintArray(arrayOne);
Console.WriteLine(" ");


Console.Write("Enter the second array length ");
int numberTwo = int.Parse(Console.ReadLine()!);

int[] arrayTwo = new int[numberTwo];
arrayTwo = CreateArray(numberTwo);
PrintArray(arrayTwo);
Console.WriteLine(" ");


int [] MergeArrays(int [] arrayOne, int [] arrayTwo)
{
    int indexThree = 0;
    int indexOne = 0;
    int indexTwo = 0;
    int [] arrayThree = new int[arrayOne.Length+arrayTwo.Length];
    while(indexThree<(arrayOne.Length+arrayTwo.Length))
    {
        while(indexOne<(arrayOne.Length))
        {
            arrayThree[indexThree] = arrayOne[indexOne];
            indexOne++;
            indexThree++;
        }
            while(indexTwo<(arrayTwo.Length))
        {
            arrayThree[indexThree] = arrayTwo[indexTwo];
            indexTwo++;
            indexThree++;
        }
    }
    return arrayThree;
}

Console.WriteLine(" ");
Ordering (MergeArrays(arrayOne, arrayTwo));
