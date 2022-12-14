using laba20;

Console.WriteLine("Введите кол-во машин: ");
int N = Convert.ToInt32(Console.ReadLine());                         //кол-во объектов
List<Auto> Autos = new List<Auto>();
int[] B = new int[N];
for (int q = 0; q < N; q++)
{
    Console.WriteLine($"Автомобиль №{q + 1}:");
    Console.WriteLine("Имя:");
    string? a = Console.ReadLine();
    Console.WriteLine("Номер:");                                // заполняем объекты
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Марка:");
    string? c = Console.ReadLine();
    Console.WriteLine("Скорости:");
    int d = Convert.ToInt32(Console.ReadLine());
    Auto auto = new(a, b, c, d);
    Autos.Add(auto);
}
Console.WriteLine($"Введите номер автомобиля который хотите удалить: " + Environment.NewLine + "(Если вы не хотите удалять то введите -1)");
int num = Convert.ToInt32(Console.ReadLine());
if(num != -1)
{
    Autos.RemoveAt(num - 1);
    Console.WriteLine($"Автомобиль №{num + 1} удалён из списка");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Введите Имя автомобиля который хотите найти и он будет выведен: " + Environment.NewLine + "(Если вы не хотите искать то введите -1)");
string imya = Console.ReadLine();
List<Auto> search_auto = null;
if (imya != "-1")
{
    search_auto = Autos.FindAll(p => p.name == imya);
}
if(search_auto != null)
{
    foreach(Auto avto in search_auto)
    {
        Console.WriteLine("Имя: " + avto.name + "; Номер: " + avto.number + "; Марка: " + avto.mark + "; Скорости: " + avto.speeds + ";");
    }
}

