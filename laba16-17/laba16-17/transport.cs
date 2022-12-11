using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba16_17
{
    abstract class transport
    {
        public string? name { get; set; }
        public int number { get; set; }
        public string? mark { get; set; }

        public abstract void transport_default();
    }
}
