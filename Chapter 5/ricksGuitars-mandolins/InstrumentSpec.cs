using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_mandolins
{
    public abstract class InstrumentSpec
    {
        private Builder builder;
        private string model;
        private Type type;
        private Wood backWood;
        private Wood topWood;
 
    public InstrumentSpec(Builder builder, string model, Type type,
                      Wood backWood, Wood topWood)
    {
        this.builder = builder;
        this.model = model;
        this.type = type;
        this.backWood = backWood;
        this.topWood = topWood;
    }
        public Builder getBuilder()
        {
            return builder;
        }

        public String getModel()
        {
            return model;
        }

        public Type getType()
        {
            return type;
        }

        public Wood getBackWood()
        {
            return backWood;
        }

        public Wood getTopWood()
        {
            return topWood;
        }

        public bool matches(InstrumentSpec otherSpec)
        {
            if (builder != otherSpec.builder)
                return false;
            if ((model != null) && (!model.Equals("")) &&
                (!model.Equals(otherSpec.model)))
                return false;
            if (type != otherSpec.type)
                return false;
            if (backWood != otherSpec.backWood)
                return false;
            if (topWood != otherSpec.topWood)
                return false;
            return true;
        }


    }
}
