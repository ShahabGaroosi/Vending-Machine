using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Vending_Machine.Model;

namespace Vending_Machine.Tests.Model
{
    public class DrinkTests
    {
        [Fact]
        public void VolumeTest()
        {
            //Arrange
            string name = "Test";
            int price = 23;
            double volume = 33;
            double calories = 100;

            //Act
            Drink testDrink = new Drink(name, price, volume, calories);

            //Assert
            Assert.Equal(volume, testDrink.Volume);
        }
        [Fact]
        public void CaloriesTest()
        {
            //Arrange
            string name = "Test";
            int price = 23;
            double volume = 33;
            double calories = 100;

            //Act
            Drink testDrink = new Drink(name, price, volume, calories);

            //Assert
            Assert.Equal(calories, testDrink.Calories);
        }

    }
}
