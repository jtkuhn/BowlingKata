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
        int totalScore = 0;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }


        public int Score()
        {
            int i = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                i += ScoreFrame(i);
            }
            return totalScore;
        }

        private int ScoreFrame(int i)
        {
            if (IsStrike(i)) //if strike
            {
                totalScore += ScoreStrike(i);
                return 1;
            }
            else if (IsSpare(i)) //else if spare
            {
                totalScore += ScoreSpare(i);
            }
            else //else just a regular frame
            {
                totalScore += ScoreRegularFrame(i);
            }
            return 2;
        }

        private Boolean IsSpare(int i)
        {
            return rolls[i] + rolls[i + 1] == 10;
        }

        private Boolean IsStrike(int i)
        {
            return rolls[i] == 10;
        }

        private int ScoreRegularFrame(int i)
        {
            return rolls[i] + rolls[i + 1];
        }

        private int ScoreStrike(int i)
        {
            return 10 + rolls[i + 1] + rolls[i + 2];
        }

        private int ScoreSpare(int i)
        {
            return 10 + rolls[i + 2];
        }
    }
}
