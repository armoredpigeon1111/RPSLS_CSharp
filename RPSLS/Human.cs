using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {


        public Human(string name, int score, string chosenGesture)
          
        {         
            this.name = name;
            this.score = score;
            this.chosenGesture = chosenGesture;      
        }

        public string chooseGesture() {
            Console.WriteLine("Choose your gesture: Type 1 for Rock, 2 for Paper, 3 for Scissors, 4 for Lizard or 5 for Spock:");
            int chosenGesture = Convert.ToInt32(Console.ReadLine());
            return this.gestureList[chosenGesture];
        }

    }
}
