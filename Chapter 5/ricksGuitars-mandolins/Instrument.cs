using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_mandolins
{
    public abstract class Instrument
    {
        private string serialNumber;
        private double price;
        private InstrumentSpec spec;

        public Instrument(string serialNumber, double price, InstrumentSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;

        }
        public String getSerialNumber()
        {
            return serialNumber;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(float newPrice)
        {
            this.price = newPrice;
        }

        public InstrumentSpec getSpec() {
            return spec;
        }
    }
}
