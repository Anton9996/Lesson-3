// Напишите программу, которая по заданному
// номеру четверти, показывает диапазон
// возможных координат точек в этой четверти 


Console.WriteLine("Укажите номер четверти ");
int x = Convert.ToInt32(Console.ReadLine());



string NomerQuarter(int number)
{
    if (number == 1) return "диапазон возможных координат x > 0 y > 0";
    if (number == 2) return "диапазон возможных координат x < 0 y > 0";
    if (number == 3) return "диапазон возможных координат x < 0 y < 0";
    if (number == 4) return "диапазон возможных координат x > 0 y < 0";
    return "Введен некорректный номер четверти";
}

string result = NomerQuarter(x);
Console.WriteLine(result);
