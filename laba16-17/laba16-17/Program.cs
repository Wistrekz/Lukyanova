using laba16_17;

Console.WriteLine("Введите кол-во машин: ");
int N = Convert.ToInt32(Console.ReadLine());                         //кол-во объектов
Console.WriteLine("Введите кол-во самолётов: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во поездов: ");
int N2 = Convert.ToInt32(Console.ReadLine());
auto[] autos = new auto[N];
plane[] plein = new plane[N1];
Train[] trein = new Train[N2];
int[] B = new int[N2];
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
    auto auto = new(a, b, c, d);
    autos[q] = auto;
    if (q == N - 1)
    {
        autos[q].transport_default(); // выводим дефолтный метод который ещё и абстрактный
    }
    

}
for (int w = 0; w < N1; w++)
{
    Console.WriteLine($"Самолёт №{w + 1}:");
    string? a = Console.ReadLine();
    Console.WriteLine("номер:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Марка:");
    string? c = Console.ReadLine();
    Console.WriteLine("Пассажиры(кол-во): ");
    int d = Convert.ToInt32(Console.ReadLine());
    plane plain = new(a, b, c, d);
    plein[w] = plain;
    if (w == N1 - 1)
    {
        plein[w].transport_default();
    }
}
for (int e = 0; e < N2; e++)
{
    Console.WriteLine($"Поезд №{e + 1}");
    Console.WriteLine("Имя:");
    string? a = Console.ReadLine();
    Console.WriteLine("номер:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Марка:");
    string? c = Console.ReadLine();
    Console.WriteLine("Вагоны:");
    int d = Convert.ToInt32(Console.ReadLine());
    Train train = new(a, b, c, d);
    trein[e] = train;
    if (e == N2 - 1)
    {
        trein[e].transport_default();
    }   
}
for (int q = 0; q < N; q++)
{
    autos[q].Printdata(autos[q]);          //выводим все объекты
}
for (int w = 0; w < N1; w++)
{
    plein[w].Printdata(plein[w]);
}
for (int e = 0; e < N2; e++)
{
    trein[e].Printdata(trein[e]);
}
Console.ReadKey();
Console.ReadKey();

