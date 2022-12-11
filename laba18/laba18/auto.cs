using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba18
{
    internal class auto : IComparable
    {
        public string name { get; set; }
        public int number { get; set; }

        public int CompareTo(object? o)
        {
            auto p = o as auto;
            return p.name.CompareTo(p.number.ToString());
        }

    }
}
