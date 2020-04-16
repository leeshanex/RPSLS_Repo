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
            DisplayRules();
            ChooseGameMode();
            player1.DisplayGesturesOptions();
            player1.ChooseGesture();
            player2.ChooseGesture();  
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to The Rock, Paper, Scissors, Lizard, Spock Game!! ");
            Console.WriteLine("Rules: The original Rock, Paper, Scissors game but with two additional hand gestures. ");
            Console.WriteLine("|``````````````````````````````````|");
            Console.WriteLine("|> Rock crushes Scissors & Lizard <|");
            Console.WriteLine("|> Paper beats Rock & Spock       <|");
            Console.WriteLine("|> Scissors cuts Paper & Lizard   <|");
            Console.WriteLine("|> Lizard beats Spock & Paper     <|");
            Console.WriteLine("|> Spock beats Scissors & Rock    <|");
            Console.WriteLine("|__________________________________|");
        }
        public void ChooseGameMode()
        {
            Console.WriteLine(" |Game Modes|");
            Console.WriteLine("````````````````");
            Console.WriteLine(" 1) Vs. Computer");
            Console.WriteLine(" 2) Vs. Player");
            Console.WriteLine("Please enter game mode (1 or 2)");

            bool validChoice = false;
            while (!validChoice)
            {
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    player2 = new Computer();
                    validChoice = true;
                }
                else if (userInput == "2")
                {
                    player2 = new Human();
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input please try again");
                }
            }
        }
        public void CompareGestures()
        {

        }

    }
}
