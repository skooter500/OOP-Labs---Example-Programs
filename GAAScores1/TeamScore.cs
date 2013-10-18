using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAAScores1
{
    public class TeamScore
    {
        private string teamName;
        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }
        private int goals;

        public int Goals
        {
            get { return goals; }
            set { goals = value; }
        }
        private int points;
        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public int TotalScore
        {
            get
            {
                return (goals * 3) + points;
            }
        }

        public TeamScore()
            : this("", 0, 0)
        {

        }

        public TeamScore(string teamName, int goals, int points)
        {
            this.teamName = teamName;
            this.goals = goals;
            this.points = points;
        }

        public override string ToString()
        {
            return teamName + "\t" + goals + "-" + points + "\t" + TotalScore;
        }
    }
}
