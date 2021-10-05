using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.ricksGuitars_encapsulation
{
    public class Guitar
    {
        private string serialNumber;
        private double price;
        GuitarSpec spec;

        public Guitar(string serialNumber, double price,
                      Builder builder, string model, Type type,
                      Wood backWood, Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = new GuitarSpec(builder, model, type, backWood, topWood);
        }

        public string getSerialNumber()
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

        public GuitarSpec getSpec()
        {
            return spec;
        }

    }
}
