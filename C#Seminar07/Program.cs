/*int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }  
    Console.WriteLine();
}



int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

//1. Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: 
//Aij = i+j. Выведите полученный массив на экран.

/*int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }  
    Console.WriteLine();
}



int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

//2. Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы 
//на их квадраты

/*int [,] CreateRandom2dArray()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }  
    Console.WriteLine();
}

void Quadr(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
    {
        for(int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] *= array[i,j];
        }
    }
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Quadr(myArray);
Show2dArray(myArray);
*/


//3. Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.

int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }  
    Console.WriteLine();
}

/*
int SumNum(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            if(i == j)               //в этом варианте мы проверяем КАЖДЫЙ элемент, те в каждой строке проверим каждый столбик
            sum = sum + array[i,j];
        }
    }
    return sum;
}
*/
int SumNum(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(1) && i < array.GetLength(0); i++) // i прыгает не только по строкам, но и сразу по столбцам,
            sum += array[i,i];                                            // те переходит сразу  на следующую строку и элемент
}                                                                         // и половина элементов останется не проверенными
    return sum;

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int sum = SumNum(myArray);
Console.WriteLine(sum);
