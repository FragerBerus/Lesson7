﻿// Пример переполнения стека при рекурсии из-за ошибки указания
// условия выхода. Для выхода нажмите Ctrl + C. 
Console.Clear();
void Rec()
{
    Rec();
}
Rec();