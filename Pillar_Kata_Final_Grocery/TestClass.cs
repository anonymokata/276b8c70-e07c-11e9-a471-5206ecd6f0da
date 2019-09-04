using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Pillar_Kata_Final_Grocery
{
    public class TestClass
    {
        [Fact]
        public void GetAllGroceryProduce()
        {
            string[,] expected ={ { "Lettuce", "1.29" }, { "Tomato", "1.00" }, { "Potaatos", ".35" } };
            string[,] actual = AllGroceryProductList.GroceryProduce();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetAllGroceryMeat()
        {
            string[,] expected = { { "Ground Chuck", "1", "4.75" }, { "Ribs", "1", "3.75" }, { "T-Bone Steak", "1", "15.00" }, { "Brisket", "1", "10.99" } };
            string[,] actual = AllGroceryProductList.GroceryMeat();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetAllGroceryDrinks()
        {
            string[,] expected = { { "Water", "50.00" }, { "Pepsi", "2.00" }, { "Coke", "1.00" }, { "Fanta", "2.23" } };
            string[,] actual = AllGroceryProductList.GroceryDrink();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetTotalListFromProduce()
        {
            string expected = "Lettuce" + "1.29"  + "Tomato" + "1.00" + "Potaatos" + ".35" ;
            string actual = AllGroceryProductList.TotalList();
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void CanGetAndSetItem()
        {
            var expected = new Random().ToString();
            var target = new KartItem() { Item = expected };
            Assert.Equal(expected, target.Item);
            
        }
        [Fact]
        public void CanGetAndSetPound()
        {
            var expected = new Random().Next();
            var target = new KartItem() { Pound = expected };
            Assert.Equal(expected, target.Pound);
        }
        [Fact]
        public void CanGetAndSetCost()
        {
            var expected = new Random().Next();
            var target = new KartItem() { Cost = expected };
            Assert.Equal(expected, target.Cost);
        }
        [Fact]
        public void AddToKartMethod()
        {
            var expected = ;
            var actual = AddToKart.PutItemInKart;
            Assert.Equal();
        }

    }
}
