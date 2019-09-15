using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata_Final_Grocery
{
    class Deals
    {
       
        public static string BuyOneGetOneFree()
        {
            Kart kart = new Kart();

            foreach (var item in kart.GetKart())
            {
                if (item.Item == "Lettuce")
                {
                    double getOnefree = item.Cost * 2;
                    return getOnefree.ToString();
                }
            }
            return "There is no discount for your item at this time";
        }



    }
}
