using laba19;

try
{
    Console.WriteLine("Сколько всего клиентов?");
    int client_number = Convert.ToInt32(Console.ReadLine());
    Dancing[] client = new Dancing[client_number]; //массив объектов

    for (int q = 0; q < client_number; q++)
    {
        Console.WriteLine($"Участник №{q + 1}");
        Console.WriteLine("Имя:");
        client[q].Imya = Console.ReadLine();
        Console.WriteLine("Фамилия:");
        client[q].Familiya = Console.ReadLine();
        Console.WriteLine("Отчество: ");
        client[q].Otchestvo = Console.ReadLine();
        Console.WriteLine("Город: ");
        client[q].gorod = Console.ReadLine();
        Console.WriteLine("Фамилия тренера: ");
        client[q].familiya_trenera = Console.ReadLine();
        Console.WriteLine("Оценка за танец: ");
        client[q].ocenka_za_tanec = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Общий балл:");
        client[q].unite_ball = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Сортировка по баллу:");
    var _allStatInfo = client;
    var sortedList = _allStatInfo.OrderBy(si => si.Familiya).Reverse().ToList(); //сортировка через спец. интерфейс по фамилии
    sortedList = sortedList.OrderBy(si => si.unite_ball).Reverse().ToList(); //сортировка через спец. интерфейс по баллу

    foreach (var o in sortedList)
    {
        Console.WriteLine("Клиент: " + o.Imya + " " + o.Familiya + " " + o.Otchestvo + ";" + Environment.NewLine + "Тренер: " + o.familiya_trenera + ", Балл: " + o.unite_ball);
        Console.WriteLine();
    }

    Console.ReadKey();
}
catch(FormatException) // ошибка формата
{
    Console.WriteLine("Ошибка. Вы ввели не тот формат данных. Здесь могут быть только числа");
}


