// Дана квадратная матрица N×N, состоящая из натуральных чисел. 
// Зеркально отразить ее элементы относительно побочной диагонали. Вывести
// результат на экран.

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
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
Console.Write("Enter the number or rows...");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number or columns..");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");
int[,] array = new int[rows, columns];
array = CreateArray(rows, columns);
Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");


int[,] TransportingElements(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - i; j++)
        {
            temp = array[i, j];
            array[i, j] = array[array.GetLength(0) - j - 1, array.GetLength(1) - i - 1];
            array[array.GetLength(0) - j - 1, array.GetLength(1) - i - 1] = temp;
        }
    }
    return array;
}

PrintArray(TransportingElements(array));
