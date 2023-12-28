using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IFruit
    {
        public string Color { get; set; }
        public int Price { get; set; }

        public void Description();

    }
}
