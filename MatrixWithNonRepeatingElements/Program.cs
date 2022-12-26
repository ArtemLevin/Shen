
int[] CreateOneDimArray(int sizeOfArray)
{
    int count = 0;
    int[] oneDimArray = new int[sizeOfArray];
    for (int i = 0; i < oneDimArray.Length; i++)
    {
        int newElement = new Random().Next(0, sizeOfArray+1);

        if (i == 0) oneDimArray[i] = new Random().Next(0, sizeOfArray+1);
        else
        {
            for (int j = 0; j < i; j++)
            {
                if (newElement == oneDimArray[j]) count++;
            }
            if (count == 0) oneDimArray[i] = newElement;
            else i = i - 1;
            count = 0;
        }
    }
    return oneDimArray;
}

void PrintOneDimArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0}	", array[i]);
    }
    Console.WriteLine(" ");
}

int[,] ConvertOneDimToTwoDimArray(int[] array)
{
    Console.Write("Enter the number of rows...");
    int newRows = int.Parse(Console.ReadLine()!);
    int p = 0;
    int[,] TwoDimArray = new int[newRows, (array.Length) / newRows];
    for (int i = 0; i < TwoDimArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoDimArray.GetLength(1); j++)
        {
            TwoDimArray[i, j] = array[p];
            p++;
        }
    }
    return TwoDimArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}	", array[i, j]);
        }
        Console.WriteLine(" ");
    }
}


PrintArray(ConvertOneDimToTwoDimArray(CreateOneDimArray(26)));