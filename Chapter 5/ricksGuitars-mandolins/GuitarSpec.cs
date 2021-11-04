using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_mandolins
{
    public class GuitarSpec : InstrumentSpec
    {
        private int numStrings;
        public GuitarSpec(Builder builder, string model, Type type, int numStrings, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
        {
            this.numStrings = numStrings;
        }
        public int getNumStrings()
        {
            return numStrings;
        }

        // Override the superclass matches()
        public bool matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec))
                return false;
            if (!(otherSpec.getType()== this.getType()))
                return false;
            GuitarSpec spec = (GuitarSpec)otherSpec;
            if (numStrings != spec.numStrings)
                return false;
            return true;
        }

    }
}
