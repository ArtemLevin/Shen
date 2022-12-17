// Дан двухмерный массив 5×6. 
// Определить среднее арифметическое 
// положительных элементов каждого столбца.

int [,] array = new int[5,5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(-100,101);
        if (i ==0)
        {
            Console.Write(" [{0}]\t", j);
        }
        else if(j==0)
            {
            Console.Write(" [{0}]\t", i);
        }
        else Console.Write(" {0}\t", array[i,j]);
    }
    Console.WriteLine(" ");
}

for (int i = 1; i< array.GetLength(0); i++)
{
    int sum = 0;
    int count = 0;
    int j = 1;
    while (j < array.GetLength(1))
    {
        if(array[i,j]> 0)
        {
            count ++;
            sum += array[i,j]; 
        }
        j++;
        
    }
    if(count != 0)
    {
        Console.WriteLine("The average of positive elements in {0} row is {1}", i, sum/count);
    }

    
}