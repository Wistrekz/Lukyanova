using laba18;

auto p1 = new auto { name = "Лада", number = 34 };
auto p2 = new auto { name = "Рено", number = 23 };
auto p3 = new auto { name = "форд", number = 21 };

auto[] people = new auto[] { p1, p2, p3 };
if(p1.CompareTo(p2) == 1)                 // Б.Е.С.П.О.Л.Е.З.Н.О.
{
    Array.Sort(people);
}


foreach (auto p in people)
{
    Console.WriteLine($"{p.name} - {p.number}");
}
Console.ReadKey();

