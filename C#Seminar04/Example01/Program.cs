// Напишите программу, которая принимает на вход число N и выдаёт количество цифр в числе N.

int NumOfDigits(int num)
{
    int count = 0;
    if(num == 0) count = 1;
    while(num != 0)
    {
        count++;
        num /= 10;  // num = num / 10;
    }
    return count;
}

Console.WriteLine("Input  number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumOfDigits(number);
Console.WriteLine($"Number of digits in {number} is {result}");