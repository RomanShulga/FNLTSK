string[] FillMassive()
{
    Console.WriteLine("Пожалуйста укажите, сколько строк Вы хотите, чтобы программа обработала");
    int m = int.Parse(Console.ReadLine()!);
    string[] massive = new string[m];
    Console.WriteLine("Пожалуйста введите строку, нажмите Enter");
    for (int i = 0; i < m; i++)
    {
        string x = (Console.ReadLine()!);
        massive[i] = x;
    }
    Console.Write("Входящий массив текстовых данных: ");
    Console.WriteLine(string.Join(",", massive));
    return massive;
}
string[] NewMassive(string[] arr)
{
    int n = 0;
    foreach (string el in arr)
    {
        if (el.Length < 4)
            n++;
    }
    string[] nmassive = new string[n];
    int i = 0;
    for (n = 0; n < nmassive.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            nmassive[n] = arr[i];
            n++;
        }
    }
    return nmassive;
}

string[] array = FillMassive();
Console.Write("Новый массив текстовых данных(до 3ех символов включительно): ");
Console.WriteLine($"Начало массива -> {string.Join(",", (NewMassive(array)))} <- Конец массива");