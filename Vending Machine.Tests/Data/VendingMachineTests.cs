using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Vending_Machine.Data;
using Vending_Machine.Model;

namespace Vending_Machine.Tests.Data
{
    public class VendingMachineTests
    {
        [Fact]
        public void ShowAllTest()
        {
            //Arrange
            Drink testDrink = new Drink("Cola", 15, 33, 100);
            Food testFood = new Food("Hamburger", 80, 200, 1500);
            Toy testToy = new Toy("Ball", 20, "Company", "Throw it!");
            VendingMachine vendingMachine = new VendingMachine();
            
            //Act
            vendingMachine.products.Add(testDrink);
            vendingMachine.products.Add(testFood);
            vendingMachine.products.Add(testToy);

            //Assert
            string expected = $"\n\nMoney pool: 0\n";
            expected += testDrink.Examine() + testFood.Examine() + testToy.Examine();
            Assert.Equal(expected, vendingMachine.ShowAll());
        }
        [Fact]
        public void InsertMoneyTest()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();

            //Assert
            Assert.Equal(0, vendingMachine.moneyPool);
            vendingMachine.InsertMoney(100);
            Assert.Equal(100, vendingMachine.moneyPool);
            vendingMachine.InsertMoney(20);
            Assert.Equal(100 + 20, vendingMachine.moneyPool);
            vendingMachine.InsertMoney(22);
            Assert.Equal(100 + 20, vendingMachine.moneyPool);
        }
        [Fact]
        public void PurchaseTests()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.products.Add(new Drink("Cola", 20, 33, 100));
            vendingMachine.products.Add(new Food("Hamburger", 80, 200, 1500));
            vendingMachine.products.Add(new Toy("Ball", 15, "Company", "Throw it!"));
            vendingMachine.moneyPool = 130;

            //Act

            //Assert
            Assert.Equal("Eat it!", vendingMachine.Purchase(1));
            Assert.Equal(130 - 80, vendingMachine.moneyPool);
            Assert.Equal("Drink it!", vendingMachine.Purchase(0));
            Assert.Equal(130 - 80 - 20, vendingMachine.moneyPool);
            Assert.Equal("Error: Product does not exist with index: 4.", vendingMachine.Purchase(4));
            Assert.Equal(130 - 80 - 20, vendingMachine.moneyPool);
            Assert.Equal("Drink it!", vendingMachine.Purchase(0));
            Assert.Equal(130 - 80 - 20 - 20, vendingMachine.moneyPool);
            Assert.Equal($"Error: Not enough money. Insert more money.", vendingMachine.Purchase(2));
            Assert.Equal(130 - 80 - 20 - 20, vendingMachine.moneyPool);
        }
        [Fact]
        public void EndTransactionTest()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.moneyPool = 100 + 20 + 500 + 20 + 50 + 50 + 1 + 1 + 1;

            //Assert
            Dictionary<int, int> expected = new Dictionary<int, int>() { { 1000, 0 }, { 500, 1 }, { 100, 2 }, { 50, 0 }, { 20, 2 }, { 10, 0 }, { 5, 0 }, { 1, 3 } };
            Assert.Equal(expected, vendingMachine.EndTransaction());
        }
    }
}
