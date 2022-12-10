int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] Array = new int[size];

    for(int i = 0; i < size; i++) // i+=2
        Array[i] = new Random().Next(minValue, maxValue + 1);
    return Array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); //($"array[{i + 1}] is {array[i]}")
    }
}

Console.WriteLine("Input  number of elemebts: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input  min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input  max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);