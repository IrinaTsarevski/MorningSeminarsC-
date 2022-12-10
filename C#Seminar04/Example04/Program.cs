// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

int Factorial(int number)
{
    int result = 1;
    for(int count = 1; count <= number; count++)
    {
        result *= count;
    }
    return result;
}
Console.WriteLine("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int prod = Factorial(num);
Console.WriteLine($"Product of all numbers uo to {num} is {prod}: ");