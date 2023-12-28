using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Banana : IFruit
    {
        public string Color { get; set; } = "Yellow";
        public int Price { get ; set ; }

        public void Description()
        {
            Console.WriteLine("Constructing a Banana!");
            Console.WriteLine("Did you know? Bananas botanically speaking are classified as berries not fruits!");
        }

        public Banana()
        {
            Description();
        }
    }
}
