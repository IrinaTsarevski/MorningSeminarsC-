// Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.
void Quadrats(double number)
{
    double count = 0;
    double newNumber = 1;
    while(count < number)
    {
        
        double quadratNumber = Math.Pow(newNumber, 2);
        Console.Write($"{quadratNumber}, ");
        newNumber++;
        count++;
    }

}

Console.WriteLine("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

Quadrats(num);