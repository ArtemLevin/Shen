// // String res = Format.Empty;
// int num = 123;
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
Console.WriteLine(Binary(121));