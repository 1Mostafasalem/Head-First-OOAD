using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_cohesive
{
    public class InstrumentSpec
    {
        private Hashtable properties;

        public InstrumentSpec(Hashtable properties)
        {
            if (properties == null)
            {
                this.properties = new Hashtable();
            }
            else
            {
                this.properties = (properties);
            }
        }

        public object getProperty(String propertyName)
        {
            return properties[propertyName];
        }

        public Hashtable getProperties()
        {
            return properties;
        }

        public bool matches(InstrumentSpec otherSpec)
        {
            foreach (DictionaryEntry s in otherSpec.properties)
            {
                var propertyName = s.Key.ToString();
                if (!properties[propertyName].Equals(otherSpec.getProperty(propertyName)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
