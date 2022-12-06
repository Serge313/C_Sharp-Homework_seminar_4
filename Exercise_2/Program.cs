int yourNumber = GetNumber("Enter your number ");
int sumOfDigits = GetSumOfDigits(yourNumber);
Console.WriteLine($"{yourNumber} -> {sumOfDigits}");

int GetSumOfDigits(int a)
{
    int c = 0;
    bool isGreaterThenZero = a > 0;
    if (!isGreaterThenZero)
    {
        Console.WriteLine("Your number should be > 0!");
        return -1;
    }
    else
    {
        while (a > 0)
        {
            int cutDigit = a % 10;
            c += cutDigit;
            a /= 10;
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