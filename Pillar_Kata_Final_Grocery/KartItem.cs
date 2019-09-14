using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata_Final_Grocery
{
    public class KartItem
    {
        public string Item { get; set; }
        public int Pound { get; set; }
        public double Cost { get; set; }

        public KartItem(string item, int pound, double cost)
        {
            Item = item;
            Pound = pound;
            Cost = cost;
        }

        public KartItem()
        {

        }
    }
}
