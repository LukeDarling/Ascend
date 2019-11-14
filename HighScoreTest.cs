using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Ascend
{
    [TestFixture]
    class HighScoreTest
    {
        [Test]
        public void ScoreList_HighScoreList_ListCount()
        {
            List<int> scores = new List<int> { 3, 9, 2, 5, 7 };
            HighScore hs = new HighScore(scores);
            Assert.IsTrue(hs.ScoreList.Count == 5);
        }

        [Test]
        public void ArrangeList_ScoreList_HightoLowList()
        {
            List<int> scores = new List<int> { 13, 19, 32, 5, 27 };
            HighScore hs = new HighScore(scores);
            hs.ArrangeList();
            Assert.IsTrue(hs.ScoreList[0] == 32);
            Assert.IsTrue(hs.ScoreList[1] == 27);
            Assert.IsTrue(hs.ScoreList[2] == 19);
            Assert.IsTrue(hs.ScoreList[3] == 13);
            Assert.IsTrue(hs.ScoreList[4] == 5);
        }

        [Test]
        public void HighestScore_ScoreList_HighestScore()
        {
            List<int> scores = new List<int> { 73, 93, 29, 53, 80 };
            HighScore hs = new HighScore(scores);
            Assert.IsTrue(hs.HighestScore == 93);
        }

        [Test]
        public void isHighScore_LowScore_ReturnFalse()
        {
            List<int> scores = new List<int> { 73, 93, 29, 53, 80 };
            HighScore hs = new HighScore(scores);
            Assert.IsTrue(hs.isHighScore(53) == false);
        }

        [Test]
        public void isHighScore_HighScore_ReturnTrue()
        {
            List<int> scores = new List<int> { 73, 93, 29, 53, 80 };
            HighScore hs = new HighScore(scores);
            Assert.IsTrue(hs.isHighScore(93) == true);
        }

        [Test]
        public void MergeList_TwoList_IncreasedListCount()
        {
            List<int> oldScore = new List<int> { 73, 93, 29, 53, 80 };
            List<int> newScore = new List<int> { 88, 27, 55, 63, 33 };
            HighScore hs = new HighScore(oldScore);
            hs.MergeList(oldScore, newScore);
            Assert.IsTrue(hs.ScoreList.Count == 10);
        }
    }
}
