﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    public class Computer : Player
    {
        //member variables

        //constructor
        public Computer()
        {
            playerScore = 0;
             
        }
        //methods
        public override void ChooseGesture()
        {
            
            //This method will be setting the "gestureChoice" member variable to an actual choice , ie "rock" or "spock", etc.
            //How does a computer make that choice?
            //How can a computer choose one of those 5 options by itself?
            Random r = new Random();
            int gestureChoice = r.Next(gestures.Count);
            //gestureChoice = randomGesture.Next(); TODO //find the 
            bool isComputerTurn = true;
            while (gestureChoice > 0)
            {
                if (isComputerTurn == true)
                {

                }
            }

        }
    }
}
