using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba16_17
{
    internal class auto : transport
    {
        private int speeds; // тут без разницы стоит паблик и приват
        public auto(string Name, int Number, string Mark, int Speeds) //конструктор
        {
            name = Name;
            number = Number;
            mark = Mark;
            speeds = Speeds;
        }
        public override void transport_default()  // этот метод конструктор(по умолчанию как в условии) и абстрактный метод
        {
            auto autof = new("Неизвестно", 0, "Ford", 5);
            Console.Write("\t\t" + autof.name + ", " + autof.number + ", " + autof.mark + ", " + autof.speeds + "\n");
        }
        public void Printdata(auto data) // вывод 
        {
            Console.WriteLine(data.name + ", " + data.number + ", " + data.mark + ", " + data.speeds);
        }
    }
}
