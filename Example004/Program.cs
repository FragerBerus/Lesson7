// Найти факториал числа n
Console.Clear();
int FactorialFor(int n) // Итеративный метод
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n) // Рекурсивный метод
{
    if (n == 1) return 1;
    else return n *= FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(5));
Console.WriteLine(FactorialRec(5));