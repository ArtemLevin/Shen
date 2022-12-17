int [] nums = {1, 2, 3, 4, 5};
char[] symbs = {'A', 'B', 'C', 'D', 'E'};
String[] text = {"White", "Red", "Blue"};

Console.WriteLine("Целочисленный массив");

foreach(int s in nums)
{
    Console.WriteLine("Число {0} - {1}", s, s%2==0?"even":"odd");
}

foreach(char s in symbs)
{
    Console.WriteLine("Код символа {0} - {1}", s, (int)s);
}

foreach(string s in text)
{
    Console.WriteLine("Код символа \"{0}\" {1} букв", s, s.Length);
}
