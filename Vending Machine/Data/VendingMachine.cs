using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class VendingMachine : IVending
    {
        public List<Product> products = new List<Product>();
        public int moneyPool = 0;
        readonly int[] moneyDenomination = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public string Purchase(int index)
        {
            if (0 > index || index > products.Count)
            {
                return $"Error: Product does not exist with index: {index}.";
            }
            if (moneyPool < products[index].Price)
            {
                return $"Error: Not enough money. Insert more money.";
            }
            moneyPool -= products[index].Price;
            return products[index].Use();
        }
        public string ShowAll()
        {
            string output = $"\n\nMoney pool: {moneyPool} kr\n";
            foreach (Product product in products)
            {
                output += product.Examine();
            }
            return output;
        }
        public void InsertMoney(int money)
        {
            if (moneyDenomination.Contains(money))
            {
                moneyPool += money;
            }
            else
            {
                Console.WriteLine($"Error: Invalid money insert. Valid money insert only {string.Join(", ", moneyDenomination)}.");
            }
        }
        public Dictionary<int, int> EndTransaction()
        {
            Dictionary<int, int> change = new Dictionary<int, int>();
            for (int i = moneyDenomination.Length-1; i >= 0; i--)
            {
                change.Add(moneyDenomination[i], moneyPool / moneyDenomination[i]);
                moneyPool %= moneyDenomination[i];
            }
            return change;
        }
    }
}
