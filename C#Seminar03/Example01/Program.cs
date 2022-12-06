// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuadrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координату по оси х: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату по оси y: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuadrant(xA, yA);
Console.WriteLine($"Тoчка с координатами {xA}, {yA} находится в {quadNum} четверти");