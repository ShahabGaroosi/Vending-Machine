using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Vending_Machine.Model;

namespace Vending_Machine.Tests.Model
{
    public class ToyTests
    {
        [Fact]
        public void ManufacturerTest()
        {
            //Arrange
            string name = "Test";
            int price = 23;
            string manufacturer = "Company";
            string functionality = "Test it!";

            //Act
            Toy testToy = new Toy(name, price, manufacturer, functionality);

            //Assert
            Assert.Equal(manufacturer, testToy.Manufacturer);
        }
        [Fact]
        public void FunctionalityTest()
        {
            //Arrange
            string name = "Test";
            int price = 23;
            string manufacturer = "Company";
            string functionality = "Test it!";

            //Act
            Toy testToy = new Toy(name, price, manufacturer, functionality);

            //Assert
            Assert.Equal(functionality, testToy.Functionality);
        }
        [Fact]
        public void ExamineTest()
        {
            //Arrange
            Toy testToy = new Toy("TestToy", 23, "Company", "Test it!");

            //Assert
            Assert.Equal("\n--- Toy type ---\nName: TestToy\nPrice: 23 kr\nManufacturer: Company\nFunctionality: Test it!\n", testToy.Examine());
        }
        [Fact]
        public void UseTest()
        {
            //Arrange
            Toy testToy = new Toy("TestToy", 23, "Company", "Test it!");

            //Assert
            Assert.Equal("Test it!", testToy.Use());
        }
    }
}
