using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.ricksGuitars_final
{
    public class Guitar
    {
        private string serialNumber;
        private double price;
        GuitarSpec spec;

        public Guitar(String _serialNumber, double _price, GuitarSpec _spec)
        {
            serialNumber = _serialNumber;
            price = _price;
            spec = _spec;
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

