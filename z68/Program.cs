// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("M = ");
bool isNumbM = int.TryParse(Console.ReadLine(), out int m);
if (isNumbM == false)
{
    Console.WriteLine("Число введено неверно");
    return;
}
Console.Write("N = ");
bool isNumbN = int.TryParse(Console.ReadLine(), out int n);
if (isNumbN == false)
{
    Console.WriteLine("Число введено неверно");
    return;
}
Console.WriteLine($"A({m}, {n}) = {FindAkkerman(m, n)}");

int FindAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return FindAkkerman(m - 1, 1);
    else
        return FindAkkerman(m - 1, FindAkkerman(m, n - 1));
}


