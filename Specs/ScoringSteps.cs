using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using SuperBowlingScorer;

namespace Specs
{
    [Binding]
    public class ScoringSteps
    {
        SuperScorer _scorer;
        [Given(@"I am on the first frame")]
        public void GivenIAmOnTheFirstFrame()
        {
            _scorer = new SuperScorer();
            Assert.AreEqual(1, _scorer.Frame);
        }

        [When(@"I bowl a strike")]
        public void WhenIBowlAStrike()
        {
            _scorer.ScoreFirstBall(10);
           
        }

        [Then(@"I should see an ""(.*)"" and a message that says ""(.*)""")]
        public void ThenIShouldSeeAnXAndAMessageThatSaysGoodJob(string score, string message)
        {
            Assert.AreEqual(message, _scorer.BowlerMessage);
            Assert.AreEqual(score, _scorer.Score);
        }

        [Then(@"I should hear ""(.*)""")]
        public void ThenIShouldHearGreenDay(string song)
        {
            Assert.AreEqual(song, _scorer.SongToPlay);
        }

        [When(@"I bowl a gutter ball")]
        public void WhenIBowlAGutterBall()
        {
            _scorer.ScoreFirstBall(0);
        }

        [Given(@"I have bowled a gutter ball already")]
        public void GivenIHaveBowledAGutterBallAlready()
        {
            _scorer = new SuperScorer();
            _scorer.ScoreFirstBall(0);
        }

        [When(@"I bowl another gutter ball")]
        public void WhenIBowlAnotherGutterBall()
        {
            _scorer.ScoreSecondBall(0);
        }


    }
}
