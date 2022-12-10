// Задача 63: Задайте значениe N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// Задача: Задайте значения от М до N. Напишите программу, которая выведет все натуральные числа в промежутке от М до N.

Console.WriteLine(PrintNumbers(1, 10));
string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + " " + PrintNumbers(++start, end));
}
