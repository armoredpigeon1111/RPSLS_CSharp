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
        public Game()
        {
            //TODO: set playerOne and playerTwo to child classes based on user input
            //Example: this.playerOne = new Human() or this.playerTwo = new AI()
            this.playerOne = setUpPlayerOne();
            this.playerTwo = ChooseGameType();
        }

        public void RunGame(){
            WelcomeMessage();
            DisplayRules();
        }

        public Player setUpPlayerOne() {
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
            }
            else
            {
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                playerTwo = new Human(name, 0, "none");
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


        public void playGame() { 
            while(playerOne.score < 2 && playerTwo.score < 2)
            {

            }
        }


    }
}
