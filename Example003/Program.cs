// Найти сумму чисел от 1 до n
Console.Clear();
int SumFor(int n)   // Итеративный метод
{
    int result = 0;
    for (int i = 0; i <= n; i++) result += i;
    return result;
}
int SumRec(int n)   // Рекурсивный метод
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(5));
Console.WriteLine(SumRec(5));