using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.ricksGuitars_choices
{
    public class Guitar
    {
        private String serialNumber, model;
        private double price;
        private Builder builder;
        private Type type;
        private Wood backWood, topWood;

        public Guitar(string _serialNumber, double _price,
                      Builder _builder, string _model, Type _type,
                      Wood _backWood, Wood _topWood)
        {
            serialNumber = _serialNumber;
            price = _price;
            builder = _builder;
            model = _model;
            type = _type;
            backWood = _backWood;
            topWood = _topWood;
        }

        public string getSerialNumber()
        {
            return serialNumber;
        }

        public double getPrice()
        {
            return price;
        }
        public void setPrice(float newPrice)
        {
            this.price = newPrice;
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
        public Wood getBackWood()
        {
            return backWood;
        }
        public Wood getTopWood()
        {
            return topWood;
        }

    }
}
