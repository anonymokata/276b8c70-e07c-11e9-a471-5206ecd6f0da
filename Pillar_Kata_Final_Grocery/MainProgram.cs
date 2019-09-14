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
                Console.WriteLine("Welcome to Andres Grocery Experience. Please select a number from the menu? If");
                string choice = MainMenuView.MainMenu();
                bool go = true;
                Kart kart = new Kart();
                bool exitFlag = false;
                while (go)
                {

                    if (choice == "1")
                    {

                        var print = AllGroceryProductList.TotalList();
                        Console.WriteLine(print);
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine("Pick item to place in kart");
                            foreach (var item in AllGroceryProductList.GroceryProduce())
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("Enter Item");
                            var inputItem = Console.ReadLine();
                            Console.WriteLine("Enter Pounds");
                            int inputPound = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Price");
                            double inputCost = double.Parse(Console.ReadLine());
                            kart.PutItemInKart(inputItem, inputPound, inputCost);
                            break;

                    }
                    else if (choice == "2")
                    {

                    }
                    else if (choice == "3")
                    {

                    }
                    else if (choice == "0")
                    {
                        exitFlag = true;
                        break;
                    }
                }

                if (exitFlag) break;

            }//ends progrom

            Console.WriteLine("Thanks for shopping with Andre's ! Enjoy your products");
        }
}
    
}
