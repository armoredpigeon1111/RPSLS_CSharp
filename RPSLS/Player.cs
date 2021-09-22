using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public string name;
        public int score;
        public string chosenGesture;
        public List<string> gestureList;


        public Player()
        {
            this.gestureList = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        }

        public string HumanChooseGesture()
        {
            Console.WriteLine("Choose your gesture: Type 1 for Rock, 2 for Paper, 3 for Scissors, 4 for Lizard or 5 for Spock:");
            int chosenGesture = Convert.ToInt32(Console.ReadLine()) - 1;
            return this.gestureList[chosenGesture];
        }

        public virtual string ChooseGesture()
        {
            Random random = new Random();
            int randomInt = random.Next(5);
            return this.gestureList[randomInt];

        }
    }
}
