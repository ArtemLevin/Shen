Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine()!);
string Binary(int num)
{
    if (num == 0)
    {
        return "0";
    }
    if (num == 1)
    {
        return "1";
    }
    else
    {
        
        return  Binary(num/2) + num%2;
    }
} 
Console.WriteLine("Number {0} in decimal converted to binary is {1}", num, Binary(num));