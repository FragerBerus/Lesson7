// Собрать строку с числами от a до b, a <= b
Console.Clear();
string NumbersFor(int a, int b) // Без рекурсии
{
    string result = String.Empty;   // Возвращение пустой строки
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";  // += прибавляет к левому операнду
    }                       // правый и присваивает ему значение
    return result;
}
string NumbersRec(int a, int b) // Использование рекурсии
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));