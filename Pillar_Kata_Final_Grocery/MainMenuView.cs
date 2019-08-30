using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata_Final_Grocery
{
    class MainMenuView
    {
        public static string MainMenu()
        {

            Console.WriteLine("1.......Produce");
            Console.WriteLine("2.......Meat");
            Console.WriteLine("3.......Drink");
            return Console.ReadLine();
        }
    }
}
