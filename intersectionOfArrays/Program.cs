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

int [] DifferentElements(int[] array)
{
    int i = 0;
    int k = 0;
    while (i < array.Length)
    {
        int j = i + 1;
        while (j < array.Length)
        {
            if (array[j] == array[i])
            {
                k++;
            }
            j++;
        }
        i++;
    }

    if (k == 0)
    {
        return array;
    }

    i = 0;
    k = 0;
    
    while (i < array.Length)
    {
        int j = i + 1;
        while (j < array.Length)
        {
            if (array[j] == array[i])
            {
                int[] arrayHelp = new int[array.Length -1];
                int p = 0;
                int y = 0;
                while (p < array.Length-1)
                {
                    if(y == j)
                        {
                            y++;
                        }
                    arrayHelp[p] = array[y];
                    p++;
                    y++;
                } 
                array = arrayHelp;
            }
            
            j++;
            
        }
        i++;
        
    }

    return DifferentElements(array);
}

Console.WriteLine("The computer selects the size of the array... ");
Console.WriteLine("The computer selects the elements of the array... ");
int number = new Random().Next(5, 11);
int[] arrayOne = new int[number];
int[] arrayTwo = new int[number];
arrayOne = CreateArray(number);
arrayTwo = CreateArray(number);
Console.WriteLine("The computer prints the first array ... ");
Console.WriteLine(" ");
PrintArray(arrayOne);
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("The computer prints the second array ... ");
Console.WriteLine(" ");
PrintArray(arrayTwo);
Console.WriteLine(" ");
Console.WriteLine(" ");


int Intersection(int[] arrayOne, int[] arrayTwo)
{
    int indexOne = 0;
    int counter = 0;
    while(indexOne < arrayOne.Length)
    {
        int indexTwo = 0;
        while(indexTwo < arrayTwo.Length)
        {
            if(arrayOne[indexOne]==arrayTwo[indexTwo])
            {
                Console.WriteLine("Intersection detected: " + arrayOne[indexOne] + " ");
                counter++;
            }
            indexTwo++;
        }
        indexOne++;

    }
    
    if(counter == 0)
    {
        Console.WriteLine("No intersection detected");
    }
    return counter;
}

int len = Intersection(DifferentElements(arrayOne), DifferentElements(arrayTwo));

Console.WriteLine(" ");
Console.WriteLine(" ");

int [] IntersectionArray(int[] arrayOne, int[] arrayTwo, int length)
{
    int [] InterArray = new int [length];
    int indexOne = 0;
    int indexIntersection = 0;
    while(indexOne < arrayOne.Length)
    {
        int indexTwo = 0;
        while(indexTwo < arrayTwo.Length)
        {
            if(arrayOne[indexOne]==arrayTwo[indexTwo])
            {
                InterArray[indexIntersection] = arrayTwo[indexTwo];
                indexIntersection++;
            }
            indexTwo++;
        }
        indexOne++;

    }
    
    return InterArray;
}

PrintArray(IntersectionArray(DifferentElements(arrayOne), DifferentElements(arrayTwo), len));
Console.WriteLine(" ");
Console.WriteLine(" ");

