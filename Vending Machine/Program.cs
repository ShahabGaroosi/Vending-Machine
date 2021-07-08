using System;
using Vending_Machine.Data;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int userSelection;

            do
            {
                userSelection = Menu();

                switch (userSelection)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
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
