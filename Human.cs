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
        public override void ChooseGesture()
        {
            //This method will be setting the "gestureChoice" member variable to an actual choice , ie "rokc" or "spock", etc.
            //How does a human make that choice?

            // There are 5 choices Display the five choices
            int gestureChoice = gestures.Count;
           //Write new write line displaying all 5 choices
            Console.WriteLine(gestures.Count);
            //
            int userInput = Convert.ToInt32(Console.ReadLine());
          


        }
    }
}
