using System;
using Vending_Machine.Data;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int userSelection, option;
            VendingMachine vendingMachine = new VendingMachine();

            do
            {
                userSelection = Menu();

                switch (userSelection)
                {
                    case 1:
                        if(Int32.TryParse(Console.ReadLine(), out option))
                        {
                            vendingMachine.Purchase(option);
                        }
                        break;
                    case 2:
                        vendingMachine.ShowAll();
                        break;
                    case 3:
                        if (Int32.TryParse(Console.ReadLine(), out option))
                        {
                            vendingMachine.InsertMoney(option);
                        }
                        break;
                    case 4:
                        vendingMachine.EndTransaction();
                        break;
                }
            } while (userSelection != 0);
        }

        static int Menu()
        {
            Console.WriteLine("----Menu----");
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
