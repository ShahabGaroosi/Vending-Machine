using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Vending_Machine.Model;

namespace Vending_Machine.Tests.Model
{
    public class ProductTests
    {
        [Fact]
        public void ExamineTest()
        {
            //Arrange
            string name = "Test";
            int price = 23;
            double volume = 33;
            double calories = 100;

            //Act
            Product testProduct = new Drink(name, price, volume, calories);

            //Act

            //Assert
            Assert.Equal($"\n--- {testProduct.Type()} type ---\nName: {testProduct.Name}\nPrice: {testProduct.Price} kr\n{testProduct.Info()}", testProduct.Examine());
        }
        [Fact]
        public void UseTest()
        {
            //Arrange
            string name = "Test";
            int price = 23;
            double volume = 33;
            double calories = 100;

            //Act
            Product testProduct = new Drink(name, price, volume, calories);

            //Assert
            Assert.Equal("Drink it!", testProduct.Use());
        }
    }
}
