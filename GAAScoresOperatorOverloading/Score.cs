using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAAScoresOperatorOverloading
{
    public class GAAScore
    {
        private int goals;

        public int Goals
        {
            get { return goals; }
            set
            {
                goals = value;
                recalculate();
            }
        }
        private int points;

        public int Points
        {
            get { return points; }
            set
            {
                points = value;
                recalculate();
            }
        }
        private int scoreAsPoints;

        private void recalculate()
        {
            scoreAsPoints = (goals * 3) + points;
        }

        public GAAScore(int goals, int points)
        {
            this.goals = goals;
            this.points = points;
            recalculate();
        }

        public GAAScore()
            : this(0, 0)
        {
        }

        public static GAAScore operator +(GAAScore a, GAAScore b)
        {
            GAAScore ret = new GAAScore();
            // Using the property causes recalculate to be called
            ret.Goals = a.Goals + b.Goals;
            ret.Points = a.Points + b.Points;
            return ret;
        }

        public static bool operator ==(GAAScore a, GAAScore b)
        {
            return a.scoreAsPoints == b.scoreAsPoints;
        }

        public override bool Equals(Object o)
        {
            if (o is GAAScore)
            {
                return this == (GAAScore)o;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator !=(GAAScore a, GAAScore b)
        {
            return !(a == b);
        }

        public static bool operator >(GAAScore a, GAAScore b)
        {
            return (a.scoreAsPoints > b.scoreAsPoints);
        }

        public static bool operator <(GAAScore a, GAAScore b)
        {
            return (a.scoreAsPoints < b.scoreAsPoints);
        }

        public static bool operator >=(GAAScore a, GAAScore b)
        {
            return (a == b) || (a > b);
        }

        public static bool operator <=(GAAScore a, GAAScore b)
        {
            return (a == b) || (a < b);
        }

        public override string ToString()
        {
            return "Goals: " + goals + " Points: " + points;
        }
    }
}
