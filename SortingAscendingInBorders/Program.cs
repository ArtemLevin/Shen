﻿int[] CreateArray(int number)
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

void SortingDescendingInBorders(int [] arrayOne, int startIndex, int finalIndex)
{
    int index = startIndex;
    int max = arrayOne[startIndex];
    int k = 0;
    int j = 0;
    while (index < finalIndex)
    {
        j = index + 1;
        max = arrayOne[index];
    
        while(j < finalIndex)
        {
            if(arrayOne[j] > max)
            {
                max = arrayOne[j];
                k = j;
            }

            j++;
        }
        if(index != finalIndex-1 && arrayOne[index] < max)
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

void SortingAscendingInBorders(int [] arrayOne, int startIndex, int finalIndex)
{
    int index = startIndex;
    int max = arrayOne[startIndex];
    int k = 0;
    int j = 0;
    while (index < finalIndex)
    {
        j = index + 1;
        max = arrayOne[index];
    
        while(j < finalIndex)
        {
            if(arrayOne[j] < max)
            {
                max = arrayOne[j];
                k = j;
            }

            j++;
        }
        if(index != finalIndex-1 && arrayOne[index] > max)
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

Console.Write("Enter array length ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[number];
array = CreateArray(number);

Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");
