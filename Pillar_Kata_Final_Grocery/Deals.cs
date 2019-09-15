using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata_Final_Grocery
{
    class Deals
    {
       
        public static string BuyOneGetOneFree(string product)
        {
            Kart kart = new Kart();

            foreach (var item in kart.GetKart())
            {
                if (product == "Lettuce")
                {
                    double getOnefree = item.Cost * 2;
                    return "Your get one buy one credit applied today ! " + getOnefree.ToString();
                }
            }
            return "There is no discount for your item at this time";
        }



    }
}
