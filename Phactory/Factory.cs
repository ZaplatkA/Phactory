using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phactory
{
    class Factory
    {
        public static SomeGoods ProduceFreeGoods(string name)
        {
            return new SomeGoods(name, 0);
        }

        public static SomeGoods ProduceGoods(string name, double price)
        {
            return new SomeGoods(name, 0);
        }
    }
}
