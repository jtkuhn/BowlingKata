using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
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

                if (rolls[i] == 10) //if strike
                {
                    score += rolls[i];
                    score += rolls[i + 1]; //add the next 2 rolls
                    score += rolls[i + 2];
                    i++;
                }
                else if (rolls[i] + rolls[i + 1] == 10) //else if spare
                {
                    score += rolls[i];
                    score += rolls[i + 1];
                    score += rolls[i + 2]; //add the next roll
                    i += 2;
                }
               else //else just a regular frame
                {
                    score += rolls[i];
                    score += rolls[i + 1];
                    i += 2;
                }
            }

            return score;
        }
    }
}
