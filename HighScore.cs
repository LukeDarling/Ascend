using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascend
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    //File Name: HighScore.cs
    //Description: Class that have codes about high score of the game.
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    class HighScore
    {
        List<int> listScore = new List<int>();
        public HighScore(List<int> scores)
        {
            for (int i = 0; i < scores.Count; i++)
            {
                listScore.Add(scores[i]);
            }
        }

        //~~~~~~~~~~~~~~~~~~~~Method to arrange score highest to lowest~~~~~~~~~~~~~~~~~~~~
        //Have not handle when player have the same score yet.
        public List<int> ArrangeList()
        {
            int n = ScoreList.Count;
            List<int> ArrangedList = new List<int>();
            while (n > 0)
            {
                int highNum = 0;
                for (int i = 0; i < ScoreList.Count; i++)
                {
                    if (ScoreList[i] > highNum && !ArrangedList.Contains(ScoreList[i]))
                    {
                        highNum = ScoreList[i];
                    }
                }
                ArrangedList.Add(highNum);
                --n;
            }
            ScoreList = ArrangedList;
            return ArrangedList;
        }

        //~~~~~~~~~~~~~~~~~~~~Method to merged list~~~~~~~~~~~~~~~~~~~~
        public List<int> MergeList(List<int> oldList, List<int> newList)
        {
            for (int i = 0; i < newList.Count; i++)
            {
                oldList.Add(newList[i]);
            }
            ScoreList = oldList;
            return oldList;
        }

        //~~~~~~~~~~~~~~~~~~~~Method to check if player get the high score~~~~~~~~~~~~~~~~~~~~
        public bool isHighScore(int scores)
        {
            bool result;
            for (int i = 0; i < ScoreList.Count; i++)
            {
                if (ScoreList[i] > scores)
                {
                    result = false;
                    return result;
                }
            }
            result = true;
            return result;
        }
        //~~~~~~~~~~~~~~~~~~~~Properties Zone~~~~~~~~~~~~~~~~~~~~
        //~~~~~List of Score~~~~~
        public List<int> ScoreList
        {
            set
            {
                listScore = value;
            }
            get
            {
                return listScore;
            }
        }

        //~~~~~Take highest score~~~~~
        public int HighestScore
        {
            get
            {
                List<int> scores = ArrangeList();
                return scores[0];
            }
        }
        //~~~~~~~~~~~~~~~~~~~~END Properties Zone~~~~~~~~~~~~~~~~~~~~
    }
}
