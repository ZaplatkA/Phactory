using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeGoods freeHat = new SomeGoods("Frank Hat", 0);
            freeHat.PrintInfo();
            
            SomeGoods fedora = new SomeGoods("Fedora", 100);
            fedora.PrintInfo();

            Console.ReadKey();
        }
    }
}
