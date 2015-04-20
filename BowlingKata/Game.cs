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
            int totalScore = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[i] == 10) //if strike
                {
                    totalScore += ScoreStrike(i);
                    i--;
                }
                else if (rolls[i] + rolls[i + 1] == 10) //else if spare
                {
                    totalScore += ScoreSpare(i);
                }
                else //else just a regular frame
                {
                    totalScore += rolls[i];
                    totalScore += rolls[i + 1];
                }
                i += 2;
            }

            return totalScore;
        }

        private int ScoreStrike(int i)
        {
            int tempScore = 0;
            tempScore += 10 + rolls[i + 1] + rolls[i + 2];
            return tempScore;
        }

        private int ScoreSpare(int i)
        {
            int tempScore = 0;
            tempScore += 10 + rolls[i + 2];
            return tempScore;
        }
    }
}
