using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public string name;
        public int health;
        public int score;
        public int choice;
        public Player(string nameThatWasPassedIn, int health, int score, int choice)
        {
            name = nameThatWasPassedIn;

        }
    }
}