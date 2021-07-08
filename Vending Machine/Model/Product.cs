using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public abstract string Type();
        public abstract string Info();
        public Product(int id, string name, string price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public string Examine()
        {
            return $"--- {Type()} type ---\nId: {Id}\nName: {Name}\nPrice: {Price}\n{Info()}";
        }
        public abstract string Use();
    }
}
