// Возвести число a в степень n
Console.Clear();
int PowerFor(int a, int n)  // Итеративный метод
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
int PowerRec(int a, int n)  // Рекурсивный метод
{
    if (n == 0) return 1;
    else return a * PowerRec(a, n - 1);
    return a;
}
int PowerRec1(int a, int n)  // Рекурсивный метод
{
    return n == 0 ? 1 : PowerRec1(a, n - 1) * a;    // Альтернативная
}                                                   // запись
Console.WriteLine(PowerFor(2, 3));
Console.WriteLine(PowerRec(2, 5));
Console.WriteLine(PowerRec1(2, 10));