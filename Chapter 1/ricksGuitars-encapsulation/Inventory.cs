using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.ricksGuitars_encapsulation
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(String serialNumber, double price,
                              Builder builder, string model,
                              Type type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder,
                                       model, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar getGuitar(String serialNumber)
        {
            for (int i =0; i < guitars.Count(); i++)
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
            for (int i =0;i< guitars.Count(); i++)
            {
                Guitar guitar = guitars[i];
                GuitarSpec guitarSpec = guitar.getSpec();
                if (searchSpec.getBuilder() != guitarSpec.getBuilder())
                    continue;
                String model = searchSpec.getModel().ToLower();
                if ((model != null) && (!model.Equals("")) &&
                    (!model.Equals(guitarSpec.getModel().ToLower())))
                    continue;
                if (searchSpec.getType() != guitarSpec.getType())
                    continue;
                if (searchSpec.getBackWood() != guitarSpec.getBackWood())
                    continue;
                if (searchSpec.getTopWood() != guitarSpec.getTopWood())
                    continue;
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }

    }
}
