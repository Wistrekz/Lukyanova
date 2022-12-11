using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba16_17
{
    internal class plane : transport
    {
        private int passagers;
        public plane(string Name, int Number, string Mark, int Passagers)
        {
            name = Name;
            number = Number;
            mark = Mark;
            passagers = Passagers;
        }
        public override void transport_default()
        {
            plane plain = new("Неизвестно", 0, "airplane", 5);
            Console.Write("\t\t" + plain.name + ", " + plain.number + ", " + plain.mark + ", " + plain.passagers + "\n");
        }
        public void Printdata(plane data)
        {
            Console.Write(data.name + ", " + data.number + ", " + data.mark + "," + data.passagers);
        }
    }
}
