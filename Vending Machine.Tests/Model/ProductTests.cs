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
            Product testProduct = new Drink("Test", 23, 33, 100);

            //Act

            //Assert
            Assert.Equal("\n--- Drink type ---\nName: Test\nPrice: 23 kr\nVolume: 33 cl\nCalories: 100 cal\n", testProduct.Examine());
        }
        [Fact]
        public void UseTest()
        {
            //Arrange
            Product testProduct = new Drink("Test", 23, 33, 100);

            //Assert
            Assert.Equal("Drink it!", testProduct.Use());
        }
    }
}
