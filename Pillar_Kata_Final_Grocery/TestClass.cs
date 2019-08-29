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


    }
}
