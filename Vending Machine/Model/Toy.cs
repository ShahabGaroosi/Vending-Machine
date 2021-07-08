using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    class Toy : Product
    {
        public string Manufacturer { get; set; }
        public string Functionality { get; set; }
        public Toy(int id, string name, string price, string manufacturer, string functionality) : base(id, name, price)
        {
            Manufacturer = manufacturer;
            Functionality = functionality;
        }

        public override string Info()
        {
            return $"Manufacturer: {Manufacturer}\nFunctionality: {Functionality}\n";
        }
        public override string Type()
        {
            return "Toy";
        }
        public override string Use()
        {
            return Functionality;
        }
    }
}
