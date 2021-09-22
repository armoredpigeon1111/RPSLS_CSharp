using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        


        public AI()
            
        {
            this.name = "Player 2";
        }

        public string chooseGesture() {
            Random random = new Random();
            int randomInt = random.Next(5);
            return this.gestureList[randomInt];

        }

    }
}
