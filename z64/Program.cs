// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

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
int[] Recursive(int m, int n)
{
    if (m <= n)
    {

        array[i] = m;
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


