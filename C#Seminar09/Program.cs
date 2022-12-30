//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.

/*void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}
ShowNums(5);
*/


//Напишите программу, 
//которая будет принимать на вход число и возвращать сумму его цифр.

/*int GetSumOfDigits(int num)
{
    if(num != 0) return GetSumOfDigits(num / 10) + num % 10;
    else return 0;
}
Console.Write(GetSumOfDigits(417));
*/


//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

/*void ShowNaturNumbers(int numA, int numB)
{
    if(numA < numB) 
    {
        ShowNaturNumbers(numA, numB - 1);
        Console.Write(numB + " ");
    }
    if(numB < numA) 
    {
        Console.Write(numA + " ");
        ShowNaturNumbers(numA - 1, numB); 
    }
    if(numA == numB)
        Console.Write(numA + " ");
} 

Console.Write("Input a first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

ShowNaturNumbers(numberA, numberB);
*/


//Напишите программу, которая на вход принимает
// два числа A и B, и возводит число А в целую степень B.

/*double Power(int basic, int degree)
{
    if(degree > 0) return Power(basic, degree - 1) * basic;
    else if(degree < 0) return Power(basic, degree + 1) / basic;
    else return 1;
}

Console.Write("Input a first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Power(numberA, numberB));
*/