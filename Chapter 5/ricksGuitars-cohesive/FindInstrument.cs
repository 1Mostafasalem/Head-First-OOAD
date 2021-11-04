using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_cohesive
{
    public class FindInstrument
    {
        public static void main(string[] args) {
            // Set up Rick's inventory
            Inventory inventory = new Inventory();
            initializeInventory(inventory);


            Hashtable properties = new Hashtable();
            properties.Add("builder", Builder.GIBSON);
            properties.Add("backWood", Wood.MAPLE);
            InstrumentSpec whatBryanLikes = new InstrumentSpec(properties);

            List<Instrument> matchingInstruments = inventory.search(whatBryanLikes);

            if (matchingInstruments.Any())
            {
                Console.WriteLine("Bryan, you might like these instruments:");
                for (var i = 0; i < matchingInstruments.Count(); i++)
                {
                    Instrument instrument = matchingInstruments[i];
                    InstrumentSpec spec = instrument.getSpec();
                    Console.WriteLine("We have a " + spec.getProperty("instrumentType") + " with the following properties:");
                    foreach (DictionaryEntry property in spec.getProperties())
                    {
                        var propertyName = property.Key.ToString();
                        if (propertyName.Equals("instrumentType"))
                            continue;
                        Console.WriteLine("    " + propertyName + ": " +spec.getProperty(propertyName));
                    }
                    Console.WriteLine("  You can have this " +spec.getProperty("instrumentType") + " for $" + instrument.getPrice() + "\n---");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Bryan, we have nothing for you.");
            }
        }
        private static void initializeInventory1(Inventory inventory)
        {
            Hashtable properties = new Hashtable();
            properties.Add("instrumentType", InstrumentType.GUITAR);
            properties.Add("model", "D-18");
            properties.Add("topWood", Wood.MAHOGANY);
            properties.Add("type", Type.ACOUSTIC);
            properties.Add("numStrings", 6);
            properties.Add("backWood", Wood.ADIRONDACK);
            inventory.addInstrument("122784", 5495.95, new InstrumentSpec(properties));
        }
            private static void initializeInventory(Inventory inventory)
        {
            Hashtable properties = new Hashtable();
            properties.Add("instrumentType", InstrumentType.GUITAR);
            properties.Add("builder", Builder.COLLINGS);
            properties.Add("model", "CJ");
            properties.Add("type", Type.ACOUSTIC);
            properties.Add("numStrings", 6);
            properties.Add("topWood", Wood.INDIAN_ROSEWOOD);
            properties.Add("backWood", Wood.SITKA);
            inventory.addInstrument("11277", 3999.95, new InstrumentSpec(properties));

            Hashtable ShallowH1 = new Hashtable();
            ShallowH1 = (Hashtable)properties.Clone();
            ShallowH1.Remove("builder"); ShallowH1.Add("builder", Builder.MARTIN);
            ShallowH1.Remove("model"); ShallowH1.Add("model", "D-18");
            //ShallowH1.Add("numStrings", 6);
            ShallowH1.Remove("topWood"); ShallowH1.Add("topWood", Wood.MAHOGANY);
            ShallowH1.Remove("backWood"); ShallowH1.Add("backWood", Wood.ADIRONDACK);
            inventory.addInstrument("122784", 5495.95, new InstrumentSpec(ShallowH1));

            Hashtable ShallowH2 = new Hashtable();
            ShallowH2 = (Hashtable)ShallowH1.Clone();
            ShallowH2.Remove("builder"); ShallowH2.Add("builder", Builder.FENDER);
            ShallowH2.Remove("model"); ShallowH2.Add("model", "Stratocastor");
            ShallowH2.Remove("type"); ShallowH2.Add("type", Type.ELECTRIC);
            ShallowH2.Remove("topWood"); ShallowH2.Add("topWood", Wood.ALDER);
            ShallowH2.Remove("backWood"); ShallowH2.Add("backWood", Wood.ALDER);
            inventory.addInstrument("V95693", 1499.95, new InstrumentSpec(ShallowH2));
            inventory.addInstrument("V9512", 1549.95, new InstrumentSpec(ShallowH2));

            Hashtable ShallowH3 = new Hashtable();
            ShallowH3 = (Hashtable)ShallowH2.Clone();
            ShallowH3.Remove("builder"); ShallowH3.Add("builder", Builder.GIBSON);
            ShallowH3.Remove("model"); ShallowH3.Add("model", "Les Paul");
            ShallowH3.Remove("topWood"); ShallowH3.Add("topWood", Wood.MAPLE);
            ShallowH3.Remove("backWood"); ShallowH3.Add("backWood", Wood.MAPLE);
            inventory.addInstrument("70108276", 2295.95,
              new InstrumentSpec(ShallowH3));

            Hashtable ShallowH4 = new Hashtable();
            ShallowH4 = (Hashtable)ShallowH3.Clone();
            ShallowH4.Remove("model"); ShallowH4.Add("model", "SG '61 Reissue");
            ShallowH4.Remove("topWood"); ShallowH4.Add("topWood", Wood.MAHOGANY);
            ShallowH4.Remove("backWood"); ShallowH4.Add("backWood", Wood.MAHOGANY);
            inventory.addInstrument("82765501", 1890.95,new InstrumentSpec(ShallowH4));

            Hashtable ShallowH5 = new Hashtable();
            ShallowH5 = (Hashtable)ShallowH4.Clone();
            ShallowH5.Remove("instrumentType"); ShallowH5.Add("instrumentType", InstrumentType.MANDOLIN);
            ShallowH5.Remove("type"); ShallowH5.Add("type", Type.ACOUSTIC);
            ShallowH5.Remove("model"); ShallowH5.Add("model", "F-5G");
            ShallowH5.Remove("backWood"); ShallowH5.Add("backWood", Wood.MAPLE);
            ShallowH5.Remove("topWood"); ShallowH5.Add("topWood", Wood.MAPLE);
            ShallowH5.Remove("numStrings"); ShallowH5.Remove("numStrings");
            inventory.addInstrument("9019920", 5495.99, new InstrumentSpec(ShallowH5));

            Hashtable ShallowH6 = new Hashtable();
            ShallowH6 = (Hashtable)ShallowH5.Clone();
            ShallowH6.Remove("instrumentType"); ShallowH6.Add("instrumentType", InstrumentType.BANJO);
            ShallowH6.Remove("model"); ShallowH6.Add("model", "RB-3 Wreath");
            ShallowH6.Remove("topWood"); ShallowH6.Remove("topWood");
            ShallowH6.Remove("numStrings"); ShallowH6.Add("numStrings", 5);
            inventory.addInstrument("8900231", 2945.95, new InstrumentSpec(ShallowH6));
        }
    }
}
