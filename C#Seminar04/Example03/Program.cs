//Напишите программу которая принимает на вход число А и выдаёт сумму чисел от 1 до А

int SumOfDigits(int number)
{
    int result = 0;
    for(int count = 1; count <= number; count++)
    {
        result = result + count;
    }
    return result;
}
Console.WriteLine("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumOfDigits(num);
Console.WriteLine($"Sum of number is {sum}: ");