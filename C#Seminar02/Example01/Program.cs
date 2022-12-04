int CutNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;

    int rusult = sot * 10 + ed;
    return rusult;
}


int randNum = new Random().Next(100, 1000);
int newNum = CutNumber(randNum);

Console.WriteLine($"New version of a number {randNum} is {newNum}");