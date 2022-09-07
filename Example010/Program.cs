// Пример неоптимального использования рекурсивного метода по
// сравнению с итеральным
Console.Clear();
decimal fRec = 0;
decimal fIte = 0;
decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}
Console.WriteLine("Нажмите клавишу Enter.");
Console.ReadLine();
DateTime dt = DateTime.Now; // Запоминание времени
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // Вычисление времени
Console.WriteLine();
Console.WriteLine("Нажмите клавишу Enter.");
Console.ReadLine();
dt = DateTime.Now; // Запоминание времени
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"Fibonaccirecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // Вычисление времени
Console.WriteLine("Нажмите клавишу Enter.");
Console.ReadLine();