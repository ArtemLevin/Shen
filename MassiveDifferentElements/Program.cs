int[] CreateArray(int number)
{
    int[] array = new int[number];
    int i = 0;
    while (i < number)
    {
        Console.Write("Enter a number ");
        array[i] = int.Parse(Console.ReadLine()!);
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

int[] arrayCopied = new int[number];
arrayCopied = CreateArray(number);

PrintArray(arrayCopied);

Console.WriteLine(" ");

int DifferentElements(int[] array)
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
                PrintArray(array);
                Console.Write(" ");
                PrintArray(arrayHelp);
                
            }
            
            j++;
            
        }
        i++;
        
    }

    return arrayHelp.Length;
}

Console.Write(" The number of different elements: " + DifferentElements(arrayCopied));
