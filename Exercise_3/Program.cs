int sizeOfArray = GetNumber("Enter the size of your array ");
int[] yourArray = new int [sizeOfArray];
FillArray(yourArray);
PrintArray(yourArray);


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
}


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumber($"Enter the {i+1} number: ");
    }
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