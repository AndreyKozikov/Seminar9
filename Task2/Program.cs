// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummNaturalNumbers(int m, int n)
{
    int result=m;
    if (m == n) return result;
    return result + SummNaturalNumbers(m + 1, n);
}

int m, n;
string str;
do{
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
if (m>n) {Console.WriteLine("Число m не может первышать число n. Повторите ввод.");}
} while (m>n);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n}) равна: {SummNaturalNumbers(m, n)}");