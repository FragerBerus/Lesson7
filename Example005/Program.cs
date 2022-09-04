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
}
int PowerRec1(int a, int n)  // Рекурсивный метод
{
    return n == 0 ? 1 : PowerRec1(a, n - 1) * a;    // Альтернативная
}                                                   // запись
int PowerRecMath(int a, int n)  // Упрощение рекурсивного метода
{
    if (n == 0) return 1;
    else if(n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 3));
Console.WriteLine(PowerRec(2, 5));
Console.WriteLine(PowerRec1(2, 8));
Console.WriteLine(PowerRecMath(2, 16));