using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAAScoresOperatorOverloading
{
    public class Match
    {
        private string teamA;

        public string TeamA
        {
            get { return teamA; }
            set { teamA = value; }
        }
        private string teamB;

        public string TeamB
        {
            get { return teamB; }
            set { teamB = value; }
        }

        private GAAScore scoreA;

        public GAAScore ScoreA
        {
            get { return scoreA; }
            set { scoreA = value; }
        }
        private GAAScore scoreB;

        public GAAScore ScoreB
        {
            get { return scoreB; }
            set { scoreB = value; }
        }

        public override string ToString()
        {
            return teamA + " " + scoreA
                + " " + teamB + " " + scoreB
                + ((scoreA == scoreB) ? "Draw" : (scoreA > scoreB) ? teamA : teamB);
        }


    }
}
