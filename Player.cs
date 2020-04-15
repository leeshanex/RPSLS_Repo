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
        public int playerScore;
        public List<string> gestures;
       

        //constructor
        public Player()
        {
           
            gestures = new List<string>() { new string("Rock") };
            
        }
        //methods

    }

}
