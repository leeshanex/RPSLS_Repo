using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    public class Game
    {
        //member variables
        public Player player1;
        public Player player2;

        //constructor
        public Game()
        {
            player1 = new Human();
            player2 = new Computer();

        }
        //membermethods
        public void RunGame()
        {

        }
        public void DisplayRules()
        {
            Console.WriteLine(" Rock, Paper, Scissor, Lizard, Spock " "dsdsada" );
        }
    }
}
