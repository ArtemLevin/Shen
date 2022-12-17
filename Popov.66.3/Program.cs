int [,] array = new int[5,5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,101);
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
