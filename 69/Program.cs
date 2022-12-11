// Задача 69 Напишите программу, которая на вход принимает два числа А и В и 
// возводит число А в целую степерь В с помощью рекурсии.

// System.Console.WriteLine(Pow(2, 10));
// int Pow(int num, int rang)
// {
//     if (rang == 0)
//     {
//         return 1;
//     }
//     if (rang == 1)
//     {
//         return num;
//     }
//     return (num * Pow(num, --rang));
// }


Console.WriteLine(Sum(1, 10));
int Sum(int start, int end)
{
    if (end == 0)
    {
        return start;
    }
    return (end + Sum(start + 1, end));
}