using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAAScores1
{
    public class Match
    {
        private TeamScore home;
        public TeamScore Home
        {
            get { return home; }
            set { home = value; }
        }
        private TeamScore away;

        public TeamScore Away
        {
            get { return away; }
            set { away = value; }
        }

        public Match()
        {
            home = new TeamScore();
            away = new TeamScore();
        }

        public string Winner
        {
            get
            {
                if (home.TotalScore > away.TotalScore)
                {
                    return home.TeamName;
                }
                else if (home.TotalScore == away.TotalScore)
                {
                    return "Draw";
                }
                else
                {
                    return away.TeamName;
                }
            }
        }

        public override string ToString()
        {
            return home + "\t" + away + "\t" + Winner;
        }
    }
}
