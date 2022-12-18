/*Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
5 -8 6
-5 8 -6*/

/*int [] CreatRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

int [] Revers (int [] array)
{
    for(int i = 0; i < array.Length; i++)
       array[i] *= -1;
    return array;
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible Value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible Value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);
int [] result =  Revers(myArray);
ShowArray(result);*/


/*Задайте одномерный массив из m случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [a,b]*/

/*int [] CreatRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

int NumberOfElementsAB (int[] array, int A, int B)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= A && array[i] <= B)
            count++;
    return count;
}
Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible Value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible Value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);

Console.WriteLine("Input a fist number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int result = NumberOfElementsAB(myArray, numA, numB);
Console.WriteLine($"The number of elements in the segment from {numA} to {numB} is {result}");
*/


/*Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве.
1 3 2 4
4 6
2 3 1 4 5
10 12 1*/

/*int [] CreatRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

int [] MultPairs (int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 != 0)
        size++;
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = array[i] * array[array.Length -1 -i];
        
    return newArray;
}
Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible Value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible Value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);

int [] result = MultPairs(myArray);
ShowArray(result);
*/