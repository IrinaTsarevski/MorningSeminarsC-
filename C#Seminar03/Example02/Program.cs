// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void Diapason(int num)
{
    if(num > 4 || num  > 1) Console.WriteLine ("Четверть не существует");
    if(num == 1) Console.WriteLine("Возможные координаты  x > 0 и y > 0");
    if(num == 2) Console.WriteLine("Возможные координаты  x < 0 и y > 0");
    if(num == 3) Console.WriteLine("Возможные координаты  x < 0 и y < 0");
    if(num == 4) Console.WriteLine("Возможные координаты  x > 0 и y < 0");
}

Console.WriteLine("Введите номер четверти 1, 2, 3 или 4");
int quater = Convert.ToInt32(Console.ReadLine());

Diapason(quater);







