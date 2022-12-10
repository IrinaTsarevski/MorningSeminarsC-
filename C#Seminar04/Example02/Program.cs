// 
int NumN(int number)
{
    for(int i = -number; i <= number; i++)
    {
        Console.Write(i + " ");

    }
    return number;
}

Console.WriteLine("Input a number: ");
int current = Convert.ToInt32(Console.ReadLine());
int result = NumN(current);