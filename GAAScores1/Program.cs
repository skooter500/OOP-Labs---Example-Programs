using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAAScores1
{
    class Program
    {
        static string fileName = "scores.txt";
        static Match[] matches;

        static TeamScore ParseMatchText(string text)
        {
            text = text.Trim();
            TeamScore teamScore = new TeamScore();
            int lastSpace = text.LastIndexOf(' ');
            teamScore.TeamName = text.Substring(0, lastSpace);
            string scoreBit = text.Substring(lastSpace + 1);
            string[] scoreBits = scoreBit.Split('-');
            teamScore.Goals = int.Parse(scoreBits[0]);
            teamScore.Points = int.Parse(scoreBits[1]);
            return teamScore;
        }

        static void LoadScores(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            matches = new Match[lines.Length - 2];
            for (int i = 0 ; i < matches.Length ; i ++)
            {
                if (lines[i].IndexOf('\t') != -1)
                {
                    string[] matchText = lines[i].Split('\t');
                    matches[i] = new Match();
                    matches[i].Home = ParseMatchText(matchText[0]);
                    matches[i].Away = ParseMatchText(matchText[1]);
                  
                }
            }
        }

        static void PrintScores()
        {
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }

        static void Main(string[] args)
        {
            LoadScores(fileName);
            PrintScores();
        }
    }
}
