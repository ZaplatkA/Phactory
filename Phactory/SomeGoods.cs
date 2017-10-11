using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phactory
{
    class SomeGoods
    {
        private string name;
        private double price;

        SomeGoods(string nameVal, double priceVal)
        {
            name = nameVal;
            price = priceVal;
        }

        public string Name()
        {
            return name;
        }

        public double Price()
        {
            return price;
        }
    }
}
