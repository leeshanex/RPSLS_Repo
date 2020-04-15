using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    public class Player
    {
        //member variables
        int humanScore;
        int computerScore;
        public List<string> gestures;
       

        //constructor
        public Player()
        {
            humanScore = 0;
            computerScore = 0;
            gestures = new List<string>() { new string("Rock") };
            
        }
        //methods

    }
}
