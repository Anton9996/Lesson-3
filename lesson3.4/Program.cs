// // Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Напишите число, для которого программа выведет таблицу квадратов чисел");
int a = Convert.ToInt32(Console.ReadLine());

void SquareTable(int number) 
{
    for (int i=1; i<=number; i++)
    {
        Console.WriteLine($"{i} \t {i*i}");
    }
}

if (a<1)
{
    Console.WriteLine($"введите положительное число");
    return;
}
SquareTable (a);