using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Vending_Machine.Model;

namespace Vending_Machine.Tests.Model
{
    public class FoodTests
    {
        [Fact]
        public void WeightTest()
        {
            //Arrange
            string name = "Test";
            int price = 23;
            double weight = 33;
            double calories = 100;

            //Act
            Food testFood = new Food(name, price, weight, calories);

            //Assert
            Assert.Equal(weight, testFood.Weight);
        }
        [Fact]
        public void CaloriesTest()
        {
            //Arrange
            string name = "Test";
            int price = 23;
            double weight = 33;
            double calories = 100;

            //Act
            Food testFood = new Food(name, price, weight, calories);

            //Assert
            Assert.Equal(calories, testFood.Calories);
        }
    }
}
