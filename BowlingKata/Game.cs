using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
    //random comment
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }


        public int Score()
        {
            int i = 0;
            int score = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                score += rolls[i] + rolls[i + 1];
                i += 2;
            }
                
            return score;
        }


}
}
