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
            Console.WriteLine("Welcome to Andres Grocery Experience. WOuld you like to shop here ?");
            
           bool proceed = true;

            while (proceed)
            {
                Console.WriteLine("Welcome to Andres Grocery Experience. Please select a number from the menu?");
                string choice = MainMenuView.MainMenu();

                if (choice == "1")
                {
                    
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

            }//ends progrom

            Console.WriteLine("Thanks for shopping with Andre's ! Enjoy your products");
        }
    }
    
}
