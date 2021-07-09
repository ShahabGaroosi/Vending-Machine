using System;
using Vending_Machine.Data;
using Vending_Machine.Model;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int userSelection, option;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.products.Add(new Drink("Cola", 15, 33, 100));
            vendingMachine.products.Add(new Food("Hamburger", 80, 200, 1500));
            vendingMachine.products.Add(new Toy("Ball", 20, "Company", "Throw it!"));

            do
            {
                userSelection = Menu();

                switch (userSelection)
                {
                    case 1:
                        if(Int32.TryParse(Console.ReadLine(), out option))
                        {
                            Console.WriteLine(vendingMachine.Purchase(option));
                        }
                        break;
                    case 2:
                        Console.WriteLine(vendingMachine.ShowAll());
                        break;
                    case 3:
                        if (Int32.TryParse(Console.ReadLine(), out option))
                        {
                            vendingMachine.InsertMoney(option);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Here is your change [denomination, #]:");
                        foreach (var change in vendingMachine.EndTransaction())
                        {
                            Console.WriteLine(change);
                        }
                        break;
                }
            } while (userSelection != 0);
        }

        static int Menu()
        {
            Console.WriteLine("\n----Menu----");
            Console.WriteLine("1: Purchase.");
            Console.WriteLine("2: Show all.");
            Console.WriteLine("3: Insert money.");
            Console.WriteLine("4: End transaction.");
            Console.WriteLine("0: Exit.");

            int userSelection = 0;
            int.TryParse(Console.ReadLine(), out userSelection);

            return userSelection;
        }
    }
}
