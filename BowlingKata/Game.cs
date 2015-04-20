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
                score = ScoreFrame(score, rolls[i], rolls[i+1], rolls[i+2]);
            }
                
            return score;
        }

        private int ScoreFrame(int prevScore, int thisRoll, int nextRoll, int secondNextRoll)
        {
           
            if (thisRoll == 10) //if strike
            {
                prevScore += thisRoll;
                prevScore += nextRoll; //add the next 2 rolls
                prevScore += secondNextRoll;
            }
            else if (thisRoll + nextRoll == 10) //else if spare
            {
                prevScore += thisRoll;
                prevScore += nextRoll;
                prevScore += secondNextRoll; //add the next roll
            }
            else //else just a regular frame
            {
                prevScore += thisRoll;
                prevScore += nextRoll;
            }
            return prevScore;
        }
    }
}
