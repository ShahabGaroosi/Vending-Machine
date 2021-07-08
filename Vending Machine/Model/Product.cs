﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public abstract string Type();
        public abstract string Info();
        public Product(string name, string price)
        {
            Name = name;
            Price = price;
        }

        public string Examine()
        {
            return $"--- {Type()} type ---\nName: {Name}\nPrice: {Price}\n{Info()}";
        }
        public abstract string Use();
    }
}