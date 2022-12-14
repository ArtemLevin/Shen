// Определить количество локальных минимумов в заданном числовом
// массиве. (Локальный минимум в числовом массиве – это последовательность трех рядом стоящих чисел, 
// в которой среднее число меньше стоящих слева и справа от него).

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

int index = 0;
int counter = 0;
while(index<array.Length-1)
{
    if(array[index]<array[index+1] && array[index+1]>array[index+2])
    counter++;
    index++;
}
Console.WriteLine("The number of local maxima is equal to " + counter);
