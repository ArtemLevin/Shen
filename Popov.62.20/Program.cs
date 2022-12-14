// В заданном числовом массиве определить и вывести индексы последовательностей чисел, 
// которые монотонно убывают (каждое следующее число
// меньше предыдущего).


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

void PrintIndex(int [] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write("[" + i + "]" + " ");
        i++;
    }
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

Console.Write("Enter array length ");
int number = int.Parse(Console.ReadLine()!);
int [] array = new int[number];
array = CreateArray(number);
PrintIndex(array);
Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");

int index = 0;
int k = -1;
while(index<array.Length-1)
{
    if(array[index]>array[index+1])
    {

        Console.Write(" " + index + " ");
    }
    index++;
}
