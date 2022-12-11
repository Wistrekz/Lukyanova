using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba16_17
{
    internal class auto : transport
    {
        private int speeds;
        public auto(string Name, int Number, string Mark, int Speeds)
        {
            name = Name;
            number = Number;
            mark = Mark;
            speeds = Speeds;
        }
        public override void transport_default()
        {
            auto autof = new("Неизвестно", 0, "Ford", 5);
            Console.Write("\t\t" + autof.name + ", " + autof.number + ", " + autof.mark + ", " + autof.speeds + "\n");
        }
        public void Printdata(auto data)
        {
            Console.Write(data.name + ", " + data.number + ", " + data.mark + ", " + data.speeds);
        }
    }
}
