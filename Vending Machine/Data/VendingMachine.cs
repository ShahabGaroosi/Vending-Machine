using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class VendingMachine : IVending
    {
        static List<Product> products = new List<Product>();
        int moneyPool = 0;
        readonly int[] moneyDenomination = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public Product Purchase(int index)
        {
            if (0 < index || index < products.Count)
            {
                throw new ArgumentException($"Error: Product does not exist with index: {index}.");
            }
            Product product = products[index];
            product.Use();
            return product;
        }
        public void ShowAll()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.Examine());
            }
        }
        public void InsertMoney(int money)
        {
            if (!moneyDenomination.Contains(money))
            {
                throw new ArgumentException($"Error: Invalid money insert. Valid money insert only {string.Join(",", moneyDenomination)}.");
            }
            moneyPool += money;
        }
        public Dictionary<int, int> EndTransaction()
        {
            Dictionary<int, int> change = new Dictionary<int, int>();
            for (int i = moneyDenomination.Length-1; i > 0; i--)
            {
                change.Add(moneyDenomination[i], moneyPool / moneyDenomination[i]);
                moneyPool %= moneyDenomination[i];
            }
            return change;
        }
    }
}
