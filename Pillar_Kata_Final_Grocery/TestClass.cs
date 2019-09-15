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
        public void AddToKartMethodItem()
        {
            //Arrange
            string expected = "fdfdfsds";

            //Act
            Kart addKart = new Kart();
            List<KartItem> items = addKart.PutItemInKart(expected, 3, 4.5);
            string actual = items[0].Item;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddKartMethodPound()
        {
            int expected = 3;
            Kart addKart = new Kart();
            List<KartItem> numbers = addKart.PutItemInKart("mingt", expected, 4.45);
            int actual = numbers[0].Pound;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddToKartMethodCost()
        {
            double expected = 34.56;
            Kart addKart = new Kart();
            List<KartItem> cost = addKart.PutItemInKart("fdsf", 5, expected);
            double actual = cost[0].Cost;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void VisibleKartItem()
        {
            Kart oneKart = new Kart();
            var expected = oneKart.GetKart();
            Kart kart = new Kart();
            List<KartItem> all = kart.GetKart();
            var actual = all;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DateTimeMarkDown()
        {
            string expected = "Lettuce";
            string actual = Deals.BuyOneGetOneFree(expected);
            Assert.Equal(expected, actual);

            

        }

    }
}
