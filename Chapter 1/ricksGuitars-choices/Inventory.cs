using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.ricksGuitars_choices
{
   public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(string serialNumber, double price,
                        Builder builder, string model,
                        Type type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar getGuitar(string serialNumber)
        {
            for (int i=0; i<guitars.Count; i++)
            {
                Guitar guitar = guitars[i];
                if (guitar.getSerialNumber().Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> search(Guitar searchGuitar)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            for (int i =0; i<guitars.Count(); i++)
            {
                Guitar guitar = guitars[i];
                // Ignore serial number since that's unique
                // Ignore price since that's unique
                if (searchGuitar.getBuilder() != guitar.getBuilder())
                    continue;
                string model = searchGuitar.getModel().ToLower();
                if ((model != null) && (!model.Equals("")) &&
                    (!model.Equals(guitar.getModel().ToLower())))
                    continue;
                if (searchGuitar.getType() != guitar.getType())
                    continue;
                if (searchGuitar.getBackWood() != guitar.getBackWood())
                    continue;
                if (searchGuitar.getTopWood() != guitar.getTopWood())
                    continue;
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }


    }
}
