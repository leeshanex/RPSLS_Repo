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
            

        }
        //membermethods
        public void RunGame()
        {

        }
        public void DisplayRules()
        {
            Console.WriteLine(" Rock, Paper, Scissor, Lizard, Spock ");
            ///Console.WriteLine(" Rules: " ); TO DO <<<
        }
        public void ChooseGameMode()
        {
            Console.WriteLine("Please enter 1 for One player mode, or 2 for Two player mode");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                player2 = new Computer();
            }
            else if (userInput == "2")
            {
                player2 = new Human();
            }
            else
            {
                Console.WriteLine("Incorrect input please try again");
            }

        }
    }
}
