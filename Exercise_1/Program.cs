int a = GetNumber("Enter number A ");
int b = GetNumber("Enter number B ");
int numberAtoPowerB = NumberToPower(a, b);
Console.WriteLine(numberAtoPowerB);

int NumberToPower(int a, int b)
{
    int c = a;
    bool isGreaterThenZero = (a > 0 && b > 0);
    if (!isGreaterThenZero)
    {
        Console.WriteLine("Number A or number B are >= 0!");
        return -1;
    }
    else
    {
        for (int i = 2; i <= b; i++)
        {
            c *= a;
        }
    }
    return c;
}


int GetNumber(string message)
{
    Console.Write(message);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);
    if (!isParsed)
    {
        Console.WriteLine("Invalid value entered!");
        return -1;
    }
    else
    {
        return number;
    }
}