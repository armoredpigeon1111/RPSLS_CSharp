using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public void RunGame(){
            WelcomeMessage();
            DisplayRules();
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

    }
}
