// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int MaxNum( int num )
{
    des = num / 10;
    ed = num % 10;
    maxnummer = des;
    if (maxnummer < ed)
    {
        maxnummer = ed;
    }
   return maxnummer
}

number = new Random().Next(10,100);
Console.WriteLine(number);

int maxnum = MaxNum(number);
Console.WriteLine($"наибольшая цифра числа {number} : {maxnum}");