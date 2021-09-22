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

        public virtual string ChooseGesture()
        {
            Random random = new Random();
            int randomInt = random.Next(5);
            return this.gestureList[randomInt];

        }
    }
}
