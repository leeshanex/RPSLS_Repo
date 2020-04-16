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
        public void HumanTurn()
        {
           
        }
        public override void DisplayGesturesOptions()
        {
            Console.WriteLine("Pick your move");
            foreach (string gestures in gestures)
            {
                
                for( int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("[" + i + "]" + gestures);
                }
            }

        }
        //public void HumansChoice(int choices)
        //int gestureChoice = gestures.Count;
        //    if (choices == 0)
        //    {
        //        Console.WriteLine();
        //        for (int i = 0; i < gestureChoice; i++)
        //        {
        //            Console.WriteLine("[" + i + "]" + ); //gestureChoice. or gestures[i]. to complete
        //        }
        //    }
        //    Console.WriteLine();


        public override void ChooseGesture()
        {
            //This method will be setting the "gestureChoice" member variable to an actual choice , ie "rokc" or "spock", etc.
            //How does a human make that choice?

            // There are 5 choices Display the five choices
            //Move these to DisplayGestureOptions()
            
            //Write new write line displaying all 5 choices
            //Move these to DisplayGestureOptions()
            //Console.WriteLine();
            //
            //int userInput = Convert.ToInt32(Console.ReadLine());
        }
    }
}
