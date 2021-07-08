using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    class Food : Product
    {
        public double Weight { get; set; }
        public double Calories { get; set; }
        public Food(int id, string name, string price, double weight, double calories) : base(id, name, price)
        {
            Weight = weight;
            Calories = calories;
        }

        public override string Info()
        {
            return $"Weight: {Weight}g\nCalories: {Calories}cal\n";
        }
        public override string Type()
        {
            return "Food";
        }
        public override string Use()
        {
            return "Eat it!";
        }
    }
}
