using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata_Final_Grocery
{
    public class AddToKart
    {
        public static string[,] PutItemInKart()
        {
            Console.WriteLine("::::Enter 3 selections of food name then price ::::");

            string[,] kart = new string[2,3];
            for (int i = 2; i >= 0; i--)
            {
                for(int j = 3; j >= 0; i--)
                {
                    var userInput = Console.ReadLine();
                    kart[i, j] = userInput;
                }
            }
            return kart;
            
            
            
           

        }
        
     


    }
}
