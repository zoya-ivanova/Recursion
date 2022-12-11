// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ackerman(m, n));

int Ackerman(int start, int end)
{
    if (start == 0) 
    {
        return end + 1;
    }
    if (start != 0 && end == 0) 
    {
        return Ackerman(start - 1, 1);
    }
    return Ackerman(start - 1, Ackerman(start, end - 1));
}