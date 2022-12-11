// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummaElements(m, n));

int SummaElements(int start, int end)
{
    if (start == end) 
    {
        return start;
    }
    if (start < end) 
    {
        return end + SummaElements(start, end - 1);
    }
    return end + SummaElements(start, end + 1);
}