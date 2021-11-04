using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_mandolins
{
    public class MandolinSpec : InstrumentSpec
    {
        private Style style;

        public MandolinSpec(Builder builder, string model, Type type, Style style, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
        {
            this.style = style;
        }
        // Override the superclass matches()
        public bool matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec))
                return false;
            if (!(otherSpec.getType()==this.getType()))
                return false;
            MandolinSpec spec = (MandolinSpec)otherSpec;
            if (!style.Equals(spec.style))
                return false;
            return true;
        }

    }
}
