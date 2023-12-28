using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Apple : IFruit
    {
        public string Color { get; set; } = "Red";
        public int Price { get; set; }

        public void Description()
        {
            Console.WriteLine("Constructing an Apple!");
            Console.WriteLine("Did you know? Apples float in water because there are 25% made of air!");
        }

        public Apple()
        {
            Description();
        }
    }
}
