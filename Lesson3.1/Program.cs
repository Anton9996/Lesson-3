// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причем Xне=0 и Yне=0
// и выдает номер четверти плоскости, в которой 
//находиться эта точка

Console.WriteLine("укажите координаты X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("укажите координаты Y");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Введены некорректные координаты");

string GetQuarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Введены некорректные координаты";
}

string result = GetQuarter(x, y);
Console.WriteLine(result);
