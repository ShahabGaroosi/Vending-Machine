using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    class Drink : Product
    {
        public double Volume { get; set; }
        public double Calories { get; set; }
        public Drink(int id, string name, string price, double volume, double calories) : base(id, name, price)
        {
            Volume = volume;
            Calories = calories;
        }

        public override string Info()
        {
            return $"Volume: {Volume}cl\nCalories: {Calories}cal\n";
        }
        public override string Type()
        {
            return "Drink";
        }
        public override string Use()
        {
            return "Drink it!";
        }
    }
}
