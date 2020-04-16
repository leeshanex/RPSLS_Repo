﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    public class Human : Player
    {
        //member variables

       


        //constructor
        public Human()
        { 
            playerScore = 0;
        }
        //methods
        
        public override void DisplayGesturesOptions()
        {
            Console.WriteLine("Please enter your gesture 0 - 4");
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("[" + i + "]" + gestures[i]);
                }
        }
        public override void ChooseGesture()
        {
            bool validChoice = false;
            while (!validChoice)
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 0)
                {
                    gestureChoice = "Rock";
                    Console.WriteLine("Rock");
                    validChoice = true;
                }
                else if (userInput == 1)
                {
                    gestureChoice = "Paper";
                    Console.WriteLine();
                    validChoice = true;
                }
                else if (userInput == 2)
                {
                    gestureChoice = "Scissor";
                    Console.WriteLine();
                    validChoice = true;
                }
                else if (userInput == 3)
                {
                    gestureChoice = "Lizard";
                   Console.WriteLine();
                    validChoice = true;
                }
                else if (userInput == 4)
                {
                    gestureChoice = "Spock";
                   Console.WriteLine();
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again");
                }
                Console.ReadLine();
            }
        }
        
     
    }
}
