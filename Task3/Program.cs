// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


int AkkermanCalculateFunction(int m, int n)
{
    if (m == 0) { return n + 1; } //A(0,n)=1
    else if (n == 0)
    { return AkkermanCalculateFunction(m - 1, 1); } //A(m,0)=A(m-1,1)
    else
    { return AkkermanCalculateFunction(m - 1, AkkermanCalculateFunction(m, n - 1)); } //A(n,m)=A(m-1,A(m,n-1))
}


int m, n;
string str;
do
{
    Console.Write("Введите неотрицательное число m: ");
    str = Console.ReadLine();
}
while (!int.TryParse(str, out m) || m < 0);

do
{
    Console.Write("Введите неотрицательное число n: ");
    str = Console.ReadLine();
}
while (!int.TryParse(str, out n) || n < 0);

Console.WriteLine($"Функция Аккермана А({m},{n}) равна: {AkkermanCalculateFunction(m, n)}");