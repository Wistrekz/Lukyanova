using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba16_17
{
    internal class Train : transport
    {
        private int Vagons;
        public Train(string Name, int Number, string Mark, int vagons)
        {
            name = Name;
            number = Number;
            mark = Mark;
            Vagons = vagons;
        }
        public override void transport_default()
        {
            Train train = new("Неизвестно", 0, "Чугун", 5);
            Console.Write("\t\t" + train.name + ", " + train.number + ", " + train.mark + ", " + train.Vagons + "\n");
        }
        public void Printdata(Train data)
        {
            Console.Write(data.name + ", " + data.number + ", " + data.mark + ", " + data.Vagons);
        }
    }

}
