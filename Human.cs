using System;
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
            Console.WriteLine("Your move, please enter 0 - 4");
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
               string userInput = Console.ReadLine();
                if (userInput == "0")
                {
                    gestureChoice = "Rock";
                    Console.WriteLine("Rock");
                    validChoice = true;
                }
                else if (userInput == "1")
                {
                    gestureChoice = "Paper";
                    Console.WriteLine("Paper");
                    validChoice = true;
                }
                else if (userInput == "2")
                {
                    gestureChoice = "Scissors";
                    Console.WriteLine("Scissors");
                    validChoice = true;
                }
                else if (userInput == "3")
                {
                    gestureChoice = "Lizard";
                   Console.WriteLine("Lizard");
                    validChoice = true;
                }
                else if (userInput == "4")
                {
                    gestureChoice = "Spock";
                   Console.WriteLine("Spock");
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again");
                }
            }
        }
        
     
    }
}
