// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.WriteLine(GetSum(45));
int GetSum (int num)
{
    if (num == 0 )
    {
        return 0;
    }
    return (num % 10 + GetSum(num / 10));
}

