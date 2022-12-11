using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba16_17
{
    internal class Train : transport
    {
        private int Vagons; // тут без разницы стоит паблик и приват
        public Train(string Name, int Number, string Mark, int vagons) //конструктор
        {
            name = Name;
            number = Number;
            mark = Mark;
            Vagons = vagons;
        }
        public override void transport_default() // этот метод конструктор(по умолчанию как в условии) и абстрактный метод
        {
            Train train = new("Неизвестно", 0, "Чугун", 5);
            Console.Write("\t\t" + train.name + ", " + train.number + ", " + train.mark + ", " + train.Vagons + "\n");
        }
        public void Printdata(Train data) // вывод 
        {
            Console.WriteLine(data.name + ", " + data.number + ", " + data.mark + ", " + data.Vagons);
        }
    }

}
