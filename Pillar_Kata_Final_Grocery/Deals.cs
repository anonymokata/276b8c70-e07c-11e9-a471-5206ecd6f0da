using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata_Final_Grocery
{
    class Deals
    {
       
        public static string BuyOneGetOneFree(KartItem product )
        {
            Kart kart = new Kart();

            foreach (var item in kart.GetKart())
            {
                
                if (product == item )
                {
                    double getOnefree = item.Cost +-1;
                    return "Your get one buy one credit applied today ! " + getOnefree.ToString();
                }
            }
            return "There is no discount for your item at this time";
        }



    }
}
