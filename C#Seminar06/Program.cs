//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
*/
/*
void ReversArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}*/
/*
void ReversArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible Value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);
ReversArray(myArray);
ShowArray(myArray);
*/

//Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
/*
bool Triangle(int a, int b, int c)
{
    if(a + b > c && b + c > a && c + a > b)
        return true;
    else return false;
}

Console.WriteLine("Input a first side: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second side: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a third side: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(a, b, c);
string answer = result == true? "Triangle can be": "Triangle cannot be";
Console.WriteLine(answer);
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа Фибоначчи: a и b.
/*
int[] Fibanacci(int a, int b, int size)
{
    int[] fibArray = new int[size];
    fibArray[0] = a;
    fibArray[1] = b;
    for( int i = 2; i < size; i++)
        fibArray[i] = fibArray[i-1] + fibArray[i-2];
    return fibArray;
}

Console.WriteLine("Input first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int [] myFibArray = Fibanacci(first, second, length);
ShowArray(myFibArray);
*/

//Напишите программу, которая будет создавать копию 
//заданного массива с помощью поэлементного копирования
/*
int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    copyArray[0] = 12;
    return copyArray;
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible Value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size, min, max);
int[] myCopyArray = CopyArray(myArray);

ShowArray(myArray);
ShowArray(myCopyArray);
*/

//Напишите программу, 
//которая будет преобразовывать десятичное число в двоичное.
/*
string DecToBin(int number)
{
    string bin = String.Empty;
    while (number > 0)
    {
        bin = number % 2 + bin;
        number /= 2;
    }
    return bin;
}
Console.WriteLine("Enter  number: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = DecToBin(number);
Console.WriteLine(result);
*/