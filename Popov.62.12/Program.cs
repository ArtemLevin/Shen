// Ввести массив, состоящий из 12 элементов действительного типа.
// Расположить элементы в порядке убывания. 
// Определить количество происшедших при этом перестановок.




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

int Sorting(int [] arrayOne)
{
    int counter = 0;
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
            counter++;
        }
        // PrintArray(arrayOne);
        // Console.WriteLine(" ");
        // Console.WriteLine(" ");
        index++;
    }

    PrintArray(arrayOne);
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    return counter;
}

Console.WriteLine("performed permutations during sorting " + Sorting(array) );