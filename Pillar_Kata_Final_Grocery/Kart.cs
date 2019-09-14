using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata_Final_Grocery
{
    public class Kart
    {
        
       private List<KartItem> kart = new List<KartItem>();


        public List<KartItem> PutItemInKart(string input, int inputNumber, double inputPrice)
        {
           // List<KartItem> kart = new List<KartItem>();
            kart.Add(new KartItem() {
                Item = input,
                Pound = inputNumber,
                Cost = inputPrice
            });;

            return kart;
        }

        public List<KartItem> GetKart()
        {
            return kart;
        }
    }
}
