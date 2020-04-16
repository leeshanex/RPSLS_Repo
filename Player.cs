using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    public abstract class Player
    {
        //member variables
        public int playerScore;
        public List<string> gestures;
        public string gestureChoice;
       

        //constructor
        public Player()
        {  
            gestures = new List<string>() { "Rock", "Paper", "Scissor", "Lizard", "Spock" };
        }
        //methods
        public abstract void ChooseGesture();
        public abstract void DisplayGesturesOptions();
        






    }

}
