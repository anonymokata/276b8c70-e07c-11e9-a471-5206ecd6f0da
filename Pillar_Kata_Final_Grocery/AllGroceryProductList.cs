using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata_Final_Grocery
{
    class AllGroceryProductList
    {
        public static string[,] GroceryProduce()
        {
            string[,] produce = new string[,] { { "Lettuce", "1.29" }, { "Tomato", "1.00" }, { "Potaatos", ".35" } };
            return produce;
        }
        public static string[,] GroceryMeat()
        {
            string[,] meat = new string[,] { { "Ground Chuck", "1", "4.75" }, { "Ribs", "1", "3.75"}, { "T-Bone Steak", "1", "15.00" }, {"Brisket", "1", "10.99" } };
            return meat;
        }

        public static string[,] GroceryDrink()
        {
            string[,] drink = new string[,] { {"Water","50.00"}, {"Pepsi", "2.00"}, {"Coke", "1.00"}, {"Fanta", "2.23" } };
            return drink;
        }

        public static string TotalList()
        {
            var mainProductlist = AllGroceryProductList.GroceryProduce();
            var one = mainProductlist[0, 0];
            var two = mainProductlist[0, 1];
            var three = mainProductlist[1, 0];
            var four = mainProductlist[1, 1];
            var five = mainProductlist[2, 0];
            var six = mainProductlist[2, 1];
            string totalAll = one + "" + two + "" + three + "" + four + "" + five + "" + six;
            return totalAll;
        }


    }


}
