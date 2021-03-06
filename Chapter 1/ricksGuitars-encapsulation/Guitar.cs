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

        public Guitar(string _serialNumber, double _price,
                      Builder _builder, string _model, Type _type,
                      Wood _backWood, Wood _topWood)
        {
            serialNumber = _serialNumber;
            price = _price;
            spec = new GuitarSpec(_builder, _model, _type, _backWood, _topWood);
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
