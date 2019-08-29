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
            string[,,] expected = { { } };
            string[,,] actual = AllGroceryProductList.GroceryMeat();


        }


    }
}
