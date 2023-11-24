// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

void NaturalNumbers(int m, int n)
{
    if (m == n)
    { Console.Write(m); }
    else
    {
        Console.Write($"{m}, ");
        NaturalNumbers(m + 1, n);
    }

}

int m, n;
string str;
do
{
    do
    {
        Console.Write("Введите натуральное число m: ");
        str = Console.ReadLine();
    }
    while (!int.TryParse(str, out m) || m <= 0);

    do
    {
        Console.Write("Введите натуральное число n: ");
        str = Console.ReadLine();
    }
    while (!int.TryParse(str, out n) || n <= 0);
    if (m > n) { Console.WriteLine("Число m не может первышать число n. Повторите ввод."); }
} while (m > n);
Console.Write($"M = {m}; N = {n}. -> ");
NaturalNumbers(m, n);