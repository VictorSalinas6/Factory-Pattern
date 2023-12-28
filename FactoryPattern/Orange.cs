using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Orange : IFruit
    {
        public string Color { get; set; } = "Orange";
        public int Price { get; set; }

        public void Description()
        {
            Console.WriteLine("Constructing an Orange!");
            Console.WriteLine("Did you know? Oranges have a lot of Vitamin C! They even have more than the reccomended daily intake!");
        }

        public Orange ()
        {
            Description();
        }
    }
}
