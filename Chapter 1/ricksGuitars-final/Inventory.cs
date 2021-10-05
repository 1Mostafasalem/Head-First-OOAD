using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.ricksGuitars_final
{
    public class Inventory
    {
        private List<Guitar> guitars;
        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(String serialNumber, double price, GuitarSpec spec){
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }
        public Guitar getGuitar(String serialNumber)
        {
            for (int i = 0; i<guitars.Count(); i++)
            {
                Guitar guitar = guitars[i];
                if (guitar.getSerialNumber().Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            for (int i = 0; i< guitars.Count(); i++)
            {
                Guitar guitar = guitars[i];
                if (guitar.getSpec().matches(searchSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }


    }
}
