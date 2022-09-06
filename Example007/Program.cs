// Как посмотреть содержимое папки
// Итеративное решение
Console.Clear();
string path = "F:/Документы/Обучение/Обучение IT/5. Знакомство с языками программирования/5.4. Seminar_2";
DirectoryInfo di = new DirectoryInfo(path); // Класс работы с 
                                            // директориями.
                                            // Указываем путь к той
                                            // папке, которую хотим
                                            // просмотреть
System.Console.WriteLine("Время создания папки:");
Console.WriteLine(di.CreationTime); // Получаем дату и время
                                    // создания папки
Console.WriteLine("Имена файлов в папке:");
FileInfo[] fi = di.GetFiles();  // Просмотр имен фйлов, которые
                                // находятся в папке
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
/// Рекурсивный метод
void CatalogInfo(string path1, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path1);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path1 = "F://Документы/Обучение/Обучение IT/5. Знакомство с языками программирования/5.4. Seminar_2";
CatalogInfo(path1);