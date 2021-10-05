using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.ricksGuitars_final
{
    public class GuitarSpec
    {
        private Builder builder;
        private string model;
        private Type type;
        private int numStrings;
        private Wood backWood;
        private Wood topWood;

        public GuitarSpec(Builder _builder, string _model, Type _type,
                    int _numStrings, Wood _backWood, Wood _topWood)
        {
            builder = _builder;
            model = _model;
            type = _type;
            numStrings = _numStrings;
            backWood = _backWood;
            topWood = _topWood;
        }


        public Builder getBuilder()
        {
            return builder;
        }

        public string getModel()
        {
            return model;
        }

        public Type getType()
        {
            return type;
        }

        public int getNumStrings()
        {
            return numStrings;
        }

        public Wood getBackWood()
        {
            return backWood;
        }

        public Wood getTopWood()
        {
            return topWood;
        }


        public bool matches(GuitarSpec otherSpec)
        {
            if (builder != otherSpec.builder)
                return false;
            if ((model != null) && (!model.Equals("")) &&
                (!model.ToLower().Equals(otherSpec.model.ToLower())))
                return false;
            if (type != otherSpec.type)
                return false;
            if (numStrings != otherSpec.numStrings)
                return false;
            if (backWood != otherSpec.backWood)
                return false;
            if (topWood != otherSpec.topWood)
                return false;
            return true;
        }

    }
}
