using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Pillar_Kata_Final_Grocery
{
    class MainProgram
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Andres Grocery Experience. Would you like to shop here ?");
            
           bool proceed = true;

            while (proceed)
            {
                Console.WriteLine("Welcome to Andres Grocery Experience. Please select a number from the menu?");
                string choice = MainMenuView.MainMenu();
                bool go = true;
                while (go)
                {
                    var mainProductlist = AllGroceryProductList.GroceryProduce();
                    if (choice == "1")
                    {
                        Console.WriteLine("Please choose from our selection");
                        for(int i = 0; i < mainProductlist.GetUpperBound(0); i++)
                        {
                            var indexZero = mainProductlist[i, 0] ;
                            var indexOne = mainProductlist[i, 1];
                            Console.WriteLine("{0} {1}" , indexZero, indexOne);
                            Console.ReadKey();
                        }
                    }
                    else if (choice == "2")
                    {

                    }
                    else if (choice == "3")
                    {

                    }
                    else if (choice == "0")
                    {

                    }
                }

            }//ends progrom

            Console.WriteLine("Thanks for shopping with Andre's ! Enjoy your products");
        }
    }
    
}
