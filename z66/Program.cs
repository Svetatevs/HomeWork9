// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
int[] array = new int[n - m + 1];
int i = 0;
int sum = 0;
int[] Recursive(int m, int n)
{
    if (m <= n)
    {
        array[i] = m;
        sum = sum + array[i];
        m++;
        i++;
        Recursive(m, n);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int num in array)
    {
        if (num >= 0)
        {
            Console.Write($"{num}, ");
        }
    }
}
PrintArray(Recursive(m, n));
Console.WriteLine($"Сумма элементов = {sum}");
