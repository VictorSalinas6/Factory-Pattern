using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class FruitFactory
    {
        public static IFruit PickingFruit(string choice)
        {
            switch (choice)
            {
                case "apple":
                    return new Apple();
                case "banana":
                    return new Banana();
                case "orange":
                    return new Orange();
                default:
                    return new Apple();
            }
        }
    }
}
