using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Robot
    {
        public string name;
        public int health;
        public int score;
        public int choice;

        public Robot(string nameThatWasPassedIn, int health, int score, int choice)
        {
            name = nameThatWasPassedIn;
        }
    }
}
