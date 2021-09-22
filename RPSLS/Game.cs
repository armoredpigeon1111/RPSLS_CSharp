using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        int playerNum = 0;
        public Game()
        {
            this.playerOne = SetUpPlayerOne();
            this.playerTwo = ChooseGameType();
        }

        public void RunGame(){
            WelcomeMessage();
            DisplayRules();
            PlayGame();

            
        }

        public static Player SetUpPlayerOne() {
            Player playerOne;
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            playerOne = new Human(name, 0, "none");
            return playerOne;

        }

        public Player ChooseGameType()
        {
            Player playerTwo;
            Console.WriteLine("Enter 1 for one player or 2 for two player:");

            int gamePlayers = Convert.ToInt32(Console.ReadLine());
  
            if(gamePlayers == 1)
            {
                playerTwo = new AI();
                playerNum = 1;
            }
            else
            {
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                playerTwo = new Human(name, 0, "none");
                playerNum = 2;         
            }

            return playerTwo;

        }

        public void WelcomeMessage() {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
        }

        public void DisplayRules()
        {
            Console.WriteLine("\nEach player choses one gesture from the list\n" +
                " Rock crushes Scissors\n Scissors cuts Paper\n Paper covers Rock" +
                "\n Rock crushes Lizard\n Lizard poisons Spock\n Spock smashes Scissors\n" +
                " Scissors decapitates Lizard\n Lizard eats Paper\n Paper disproves Spock\n Spock vaporizes Rock");

        }


        public void PlayGame() { 
            while(playerOne.score < 2 && playerTwo.score < 2)
            {

                playerOne.chosenGesture = this.playerOne.ChooseGesture();
                Console.WriteLine(playerOne.name + " chose " + playerOne.chosenGesture);
                playerTwo.chosenGesture = this.playerTwo.ChooseGesture();
                Console.WriteLine(playerTwo.name + " chose " + playerTwo.chosenGesture);
                ChooseRoundWinner(playerOne.chosenGesture, playerTwo.chosenGesture);   
            }
            if(playerOne.score == 2)
            {
                Console.WriteLine(playerOne.name + " won the game!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " won the game!");
            }

        }

        public void ChooseRoundWinner(string p1Gesture, string p2Gesture)
        {
            if(p1Gesture == "rock")
            {
                if (p2Gesture == "rock") {
                    Console.WriteLine("TIE!\n");
                }else if(p2Gesture == "paper" || p2Gesture == "spock")
                {
                    playerTwo.score += 1;
                    Console.WriteLine(playerTwo.name + " wins round.\n");
                }else if(p2Gesture == "scissors" || p2Gesture == "lizard")
                {
                    playerOne.score += 1;
                    Console.WriteLine(playerOne.name + " wins round.\n");
                }
            }
            else if(p1Gesture == "paper")
            {
                if(p2Gesture == "paper")
                {
                    Console.WriteLine("TIE!\n");
                }else if(p2Gesture == "rock" || p2Gesture == "spock")
                {
                    playerOne.score += 1;
                    Console.WriteLine(playerOne.name + " wins round.\n");
                }else if(p2Gesture == "scissors" || p2Gesture == "lizard")
                {
                    playerTwo.score += 1;
                    Console.WriteLine(playerTwo.name + " wins round.\n");
                }
            }
            else if(p1Gesture == "scissors")
            {
                if(p2Gesture == "scissors")
                {
                    Console.WriteLine("TIE!\n");
                }else if(p2Gesture == "paper" || p2Gesture == "lizard")
                {
                    playerOne.score += 1;
                    Console.WriteLine(playerOne.name + " wins round.\n");
                }else if(p2Gesture == "rock" || p2Gesture == "spock")
                {
                    playerTwo.score += 1;
                    Console.WriteLine(playerTwo.name + " wins round.\n");
                }
            }
            else if(p1Gesture == "lizard")
            {
                if(p2Gesture == "lizard")
                {
                    Console.WriteLine("TIE!\n");
                }else if(p2Gesture == "rock" || p2Gesture == "scissors")
                {
                    playerTwo.score += 1;
                    Console.WriteLine(playerTwo.name + " wins round.\n");
                }else if(p2Gesture == "paper" || p2Gesture == "spock")
                {
                    playerOne.score += 1;
                    Console.WriteLine(playerOne.name + " wins round.\n");
                }
            }
            else if(p1Gesture == "spock")
            {
                if (p2Gesture == "spock")
                {
                    Console.WriteLine("TIE!\n");
                }
                else if (p2Gesture == "rock" || p2Gesture == "scissors")
                {
                    playerOne.score += 1;
                    Console.WriteLine(playerOne.name + " wins round.\n");
                }
                else if(p2Gesture == "paper" || p2Gesture == "lizard")
                {
                    playerTwo.score += 1;
                    Console.WriteLine(playerTwo.name + " wins round.\n");
                }
            }
        }


    }
}
