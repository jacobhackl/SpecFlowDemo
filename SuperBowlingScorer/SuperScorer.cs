using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SuperBowlingScorer
{
    public class SuperScorer
    {
        public int Frame { get; set; }
        public string BowlerMessage { get; set; }
        public string Score { get; set; }
        public string SongToPlay { get; set; }
        public string PinsTotal { get; set; }
        public string FirstBallScore { get; set; }
        public SuperScorer()
        {
            Frame = 1;
        }

        bool IsStrike(bool isFirstBall, int pinsKnockedDown)
        {
            return isFirstBall && pinsKnockedDown == 10;
        }
        bool isGutterball(int pinsKnockedDown)
        {
            return pinsKnockedDown == 0;
        }
        public void ScoreFirstBall(int pinsKnockedDown)
        {
                if (IsStrike(true, pinsKnockedDown))
                {
                    BowlerMessage = "Good Job";
                    Score = "X";
                    SongToPlay = "Green Day";
                    Frame++;
                }
                //spare
            else
            {
                if (isGutterball(pinsKnockedDown))
                {
                    BowlerMessage = "Bummer";
                }
                FirstBallScore = pinsKnockedDown.ToString();
                    Score = pinsKnockedDown.ToString();
            }

            PinsTotal += pinsKnockedDown;
        }
        public void ScoreSecondBall(int pinsKnockedDown)
        {
            if (isGutterball(pinsKnockedDown) && FirstBallScore == "0")
            {
                            BowlerMessage = "you stink";
            }
            
            Score = pinsKnockedDown.ToString();
            PinsTotal += pinsKnockedDown;
            if (Frame < 10)
                Frame++;
        }

    }
}
