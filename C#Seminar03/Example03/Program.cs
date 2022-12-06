// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Distance(double xA, double xB, double yA, double yB)
{
    double quadrkat1 = Math.Pow(xB - xA, 2);
    double quadrkat2 = Math.Pow(yB - yA, 2);
    double result = Math.Sqrt(quadrkat1 + quadrkat2);
    return Math.Round(result, 2);
}


Console.WriteLine("Введите координату ха");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату хb");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату yа");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату yb");
double yb = Convert.ToDouble(Console.ReadLine());

double length = Distance(xa, ya, xb, yb);
Console.WriteLine($"Расстояние между точками равно: {length}");