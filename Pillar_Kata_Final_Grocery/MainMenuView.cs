using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata_Final_Grocery
{
    class MainMenuView
    {
        public static string MainMenu()
        {
            Console.WriteLine("Produce");
            Console.WriteLine("Meat");
            Console.WriteLine("Beverages");
            return Console.ReadLine();
        }
    }
}
