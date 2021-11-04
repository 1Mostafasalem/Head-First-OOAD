using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_cohesive
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
            Instrument instrument = new Instrument(serialNumber, price, spec);
            inventory.Add(instrument);
        }

        public Instrument get(string serialNumber)
        {
            for (int i = 0; i < inventory.Count(); i++)
            {
                Instrument instrument = inventory[i];
                if (instrument.getSerialNumber().Equals(serialNumber))
                {
                    return instrument;
                }
            }
            return null;
        }

        public List<Instrument> search(InstrumentSpec searchSpec)
        {
            List<Instrument> matchingInstruments = new List<Instrument>();
            for (int i = 0; i < inventory.Count(); i++)
            {
                Instrument instrument = inventory[i];
                if (instrument.getSpec().matches(searchSpec))
                    matchingInstruments.Add(instrument);
            }
            return matchingInstruments;
        }
    }
}
