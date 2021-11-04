using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_mandolins
{
    public class Guitar : Instrument
    {
        public Guitar(string serialNumber, double price, InstrumentSpec spec) : base(serialNumber, price, spec)
        {

        }
    }
}
