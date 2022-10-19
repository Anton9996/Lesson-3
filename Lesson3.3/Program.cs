// Напишите программу, которая принимает
// на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве 
// A(3,6); B(2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("укажите координаты первой точки, по оси X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("укажите координаты первой точки, по оси Y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("укажите координаты второй точки, по оси X");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("укажите координаты второй точки, по оси Y");
int y2 = Convert.ToInt32(Console.ReadLine());
double Hypotenuse(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
    return result;
}

double result = Hypotenuse(x1, y1, x2, y2);
Console.WriteLine(Math.Round(result,2));