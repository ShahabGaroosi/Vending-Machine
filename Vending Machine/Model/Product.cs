using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public abstract string Type();
        public abstract string Info();
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Examine()
        {
            return $"\n--- {Type()} type ---\nName: {Name}\nPrice: {Price} kr\n{Info()}";
        }
        public abstract string Use();
    }
}
