using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.ricksGuitars_choices
{
    public class FindGuitarTester
    {
        public static void main(String[] args)
        {
            // Set up Rick's guitar inventory
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Guitar whatErinLikes = new Guitar("", 0, Builder.FENDER, "Stratocastor",
                                              Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            List<Guitar> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars.Any())
            {
                Console.WriteLine("Erin, you might like these guitars:");
                for (int i=0; i< matchingGuitars.Count(); i++)
                {
                    Guitar guitar = matchingGuitars[i];
                    Console.WriteLine("  We have a " +
                      guitar.getBuilder() + " " + guitar.getModel() + " " +
                      guitar.getType() + " guitar:\n     " +
                      guitar.getBackWood() + " back and sides,\n     " +
                      guitar.getTopWood() + " top.\n  You can have it for only $" +
                      guitar.getPrice() + "!\n  ----");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void initializeInventory(Inventory inventory)
        {
            inventory.addGuitar("11277", 3999.95, Builder.COLLINGS,
                                "CJ", Type.ACOUSTIC,
                                Wood.INDIAN_ROSEWOOD, Wood.SITKA);
            inventory.addGuitar("V95693", 1499.95, Builder.FENDER,
                                "Stratocastor", Type.ELECTRIC,
                                Wood.ALDER, Wood.ALDER);
            inventory.addGuitar("V9512", 1549.95, Builder.FENDER,
                                "Stratocastor", Type.ELECTRIC,
                                Wood.ALDER, Wood.ALDER);
            inventory.addGuitar("122784", 5495.95, Builder.MARTIN,
                                "D-18", Type.ACOUSTIC,
                                Wood.MAHOGANY, Wood.ADIRONDACK);
            inventory.addGuitar("76531", 6295.95, Builder.MARTIN,
                                "OM-28", Type.ACOUSTIC,
                                Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
            inventory.addGuitar("70108276", 2295.95, Builder.GIBSON,
                                "Les Paul", Type.ELECTRIC,
                                Wood.MAHOGANY, Wood.MAHOGANY);
            inventory.addGuitar("82765501", 1890.95, Builder.GIBSON,
                                "SG '61 Reissue", Type.ELECTRIC,
                                Wood.MAHOGANY, Wood.MAHOGANY);
            inventory.addGuitar("77023", 6275.95, Builder.MARTIN,
                                "D-28", Type.ACOUSTIC,
                                Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
            inventory.addGuitar("1092", 12995.95, Builder.OLSON,
                                "SJ", Type.ACOUSTIC,
                                Wood.INDIAN_ROSEWOOD, Wood.CEDAR);
            inventory.addGuitar("566-62", 8999.95, Builder.RYAN,
                                "Cathedral", Type.ACOUSTIC,
                                Wood.COCOBOLO, Wood.CEDAR);
            inventory.addGuitar("6 29584", 2100.95, Builder.PRS,
                                "Dave Navarro Signature", Type.ELECTRIC,
                                Wood.MAHOGANY, Wood.MAPLE);
        }


    }
}
