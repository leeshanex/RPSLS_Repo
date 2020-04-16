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
        public void DisplayGesturesOptions(int choices)
        {
            
            int gestureChoice = gestures.Count;

            if (choices == 0)
            {
                Console.WriteLine();
                for (int i = 0; i < gestureChoice; i++)
                {
                    Console.WriteLine("[" + i + "]" + ); //gestureChoice.name or gesures[i].name to complete
                }
            }
            Console.WriteLine()
        }

        public override void ChooseGesture()
        {
            //This method will be setting the "gestureChoice" member variable to an actual choice , ie "rokc" or "spock", etc.
            //How does a human make that choice?

            // There are 5 choices Display the five choices
            //Move these to DisplayGestureOptions()
            
            //Write new write line displaying all 5 choices
            //Move these to DisplayGestureOptions()
            Console.WriteLine(gestures.Count);
            //
            int userInput = Convert.ToInt32(Console.ReadLine());
        }
    }
}
