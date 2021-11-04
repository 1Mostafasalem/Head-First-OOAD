using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_mandolins
{
    public class Mandolin : Instrument
    {
        public Mandolin(string serialNumber, double price, InstrumentSpec spec) : base(serialNumber, price, spec)
        {
        }
    }
}
