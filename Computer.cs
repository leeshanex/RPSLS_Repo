using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    public class Computer : Player
    {
        //member variables

        //constructor
        public Computer()
        {
            playerScore = 0;
             
        }
        //methods

        public override void ChooseGesture()
        {
            Random r = new Random();
            int computerGesture = r.Next(gestures.Count);
            bool computerChoice = false;
            while (!computerChoice)
            {
                if (computerGesture == 0)
                {
                    gestureChoice = "Rock";
                    Console.WriteLine("Computer chose Rock");
                    computerChoice = true;
                }
                else if (computerGesture == 1)
                {
                    gestureChoice = "Paper";
                    Console.WriteLine("Computer chose Paper");
                    computerChoice = true;
                }
                else if (computerGesture == 2)
                {
                    gestureChoice = "Scissors";
                    Console.WriteLine("Computer chose Scissors");
                    computerChoice = true;
                }
                else if (computerGesture == 3)
                {
                    gestureChoice = "Lizard";
                    Console.WriteLine("Computer chose Lizard");
                    computerChoice = true;
                }
                else if (computerGesture == 4)
                {
                    gestureChoice = "Spock";
                    Console.WriteLine("Computer chose Spock");
                    computerChoice = true;
                }
                else
                {
                    Console.WriteLine("Computer Error");
                }
                Console.WriteLine("-------------------");
            }
        }
        public override void DisplayGesturesOptions()
        {
            throw new NotImplementedException();
        }


    }
}
