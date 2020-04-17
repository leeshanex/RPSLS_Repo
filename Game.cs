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
            
            while (player1.playerScore < 3 && player2.playerScore < 3)
            {
                DisplayScore();
                player1.DisplayGesturesOptions();
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
            }
            DetermineWinner();
            Console.ReadLine();
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
            Console.WriteLine("******First to score three points win!******");
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
        public void DisplayScore()
        {
            Console.WriteLine("Player1 " + player1.playerScore + " points");
            Console.WriteLine("Player2 " + player2.playerScore + " points");
        }
        public void CompareGestures()
        {
            bool gestureComparision = false;
            while (!gestureComparision)
            {
                if (player1.gestureChoice == "Rock" && (player2.gestureChoice == "Scissors" || player2.gestureChoice == "Lizard"))
                {
                    Console.WriteLine("Rock Wins");
                    player1.playerScore += 1;
                    gestureComparision = true;
                }
                else if (player1.gestureChoice == "Paper" && (player2.gestureChoice == "Rock" || player2.gestureChoice == "Spock"))
                {
                    Console.WriteLine("Paper Wins");
                    player1.playerScore += 1;
                    gestureComparision = true;
                }
                else if (player1.gestureChoice == "Scissors" && (player2.gestureChoice == "Paper" || player2.gestureChoice == "Lizard"))
                {
                    Console.WriteLine("Scissors Wins");
                    player1.playerScore += 1;
                    gestureComparision = true;
                }
                else if (player1.gestureChoice == "Lizard" && (player2.gestureChoice == "Spock" || player2.gestureChoice == "Paper"))
                {
                    Console.WriteLine("Lizard Wins");
                    player1.playerScore += 1;
                    gestureComparision = true;
                }
                else if (player1.gestureChoice == "Spock" && (player2.gestureChoice == "Scissors" || player2.gestureChoice == "Rock"))
                {
                    Console.WriteLine("Spock Wins");
                    player1.playerScore += 1;
                    gestureComparision = true;
                }
                else if (player2.gestureChoice == "Rock" && (player1.gestureChoice == "Scissors" || player1.gestureChoice == "Lizard"))
                {
                    Console.WriteLine("Rock Wins");
                    player2.playerScore += 1;
                    gestureComparision = true;
                }
                else if (player2.gestureChoice == "Paper" && (player1.gestureChoice == "Rock" || player1.gestureChoice == "Spock"))
                {
                    Console.WriteLine("Paper Wins");
                    player2.playerScore += 1;
                    gestureComparision = true;
                }
                else if (player2.gestureChoice == "Scissors" && (player1.gestureChoice == "Paper" || player1.gestureChoice == "Lizard"))
                {
                    Console.WriteLine("Scissors Wins");
                    player2.playerScore += 1;
                    gestureComparision = true;
                }
                else if (player2.gestureChoice == "Lizard" && (player1.gestureChoice == "Spock" || player1.gestureChoice == "Paper"))
                {
                    Console.WriteLine("Lizard Wins");
                    player2.playerScore += 1;
                    gestureComparision = true;
                }
                else if (player2.gestureChoice == "Spock" && (player1.gestureChoice == "Scissors" || player1.gestureChoice == "Rock"))
                {
                    Console.WriteLine("Spock Wins");
                    player2.playerScore += 1;
                    gestureComparision = true;
                }
                else
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine("____________________");
                    player1.playerScore += 0;
                    player2.playerScore += 0;
                    break;
                }
                Console.WriteLine("____________________");
            }
        }
        public void DetermineWinner()
        {
            if (player1.playerScore == 3)
            {
                Console.WriteLine("Player1 " + player1.playerScore + " points");
                Console.WriteLine("PLAYER 1 WINNER");
            }
            else if (player2.playerScore == 3)
            {
                Console.WriteLine("Player2 " + player2.playerScore + " points");
                Console.WriteLine("PLAYER 2 WINNER");
            }
        }
        

    }
}
