using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_mandolins
{
    public class Inventory
    {
        private List<Instrument> inventory;

        public Inventory()
        {
            inventory = new List<Instrument>();
        }

        public void addInstrument(String serialNumber, double price,
                            InstrumentSpec spec)
        {
            Instrument instrument = null;
            if (spec.GetType()== typeof(GuitarSpec)) {
                instrument = new Guitar(serialNumber, price, (GuitarSpec)spec);
            } else if (spec.GetType() == typeof(MandolinSpec)) {
                instrument = new Mandolin(serialNumber, price, (MandolinSpec)spec);
            }
            inventory.Add(instrument);
        }
        public Instrument get(string serialNumber)
        {
            for (int i = 0; i< inventory.Count(); i++)
            {
                Instrument instrument = inventory[i];
                if (instrument.getSerialNumber().Equals(serialNumber))
                {
                    return instrument;
                }
            }
            return null;
        }

        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            for (int i = 0; i<inventory.Count(); i++)
            {
                Guitar guitar =  (Guitar)inventory[i];
                if (guitar.getSpec().matches(searchSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }

        public List<Mandolin> search(MandolinSpec searchSpec)
        {
            List<Mandolin> matchingMandolins = new List<Mandolin>();
            for (int i = 0; i < inventory.Count(); i++)
            {
                Mandolin mandolin = (Mandolin)inventory[i];
                if (mandolin.getSpec().matches(searchSpec))
                    matchingMandolins.Add(mandolin);
            }
            return matchingMandolins;
        }

    }
}
