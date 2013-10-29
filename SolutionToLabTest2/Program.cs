using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCFiles2012
{
    class Program
    {
        static List<Tune> tunes = new List<Tune>();

        static void LoadTunes(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            bool hasTitle = false;
            bool hasAltTitle = false;
            int currentTune = 0;
            Tune tune = null;

            for (int i = 0; i < lines.Count; i ++)
            {
                string line = lines[i];
                // Seach for the X: header. If we find one, its a new tune...
                if (line.IndexOf("X:") != -1)
                {
                    tune = new Tune();
                    tunes.Add(tune);
                    hasTitle = false;
                    hasAltTitle = false;
                    tune.x = int.Parse(line.Substring(2));
                }
                if (line.IndexOf("K:") != -1)
                {
                    tune.keySig = line.Substring(2);
                }
                if (line.IndexOf("M:") != -1)
                {
                    tune.timeSig = line.Substring(2);
                }
                if (line.IndexOf("T:") != -1)
                {
                    if (hasTitle)
                    {
                        if (!hasAltTitle)
                        {
                            tune.altTitle = line.Substring(2);
                            hasAltTitle = true;
                        }
                    }
                    else
                    {
                        tune.title = line.Substring(2);
                        hasTitle = true;
                    }
                }
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone");
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("hnr1.abc");
            bool hasTitle = false;
            bool hasAltTitle = false;
            Tune[] tunes = new Tune[500];
            int currentTune = 0;
            Tune tune = null;
            while ((line = file.ReadLine()) != null)
            {                
                // Seach for the X: header. If we find one, its a new tune...
                if (line.IndexOf("X:") != -1)
                {
                    tune = new Tune();
                    tunes[currentTune ++] = tune;
                    hasTitle = false;
                    hasAltTitle = false;
                    tune.x = int.Parse(line.Substring(2));
                }
                if (line.IndexOf("K:") != -1)
                {
                    tune.keySig = line.Substring(2);
                }
                if (line.IndexOf("M:") != -1)
                {
                    tune.timeSig = line.Substring(2);
                }
                if (line.IndexOf("T:") != -1)
                {
                    if (hasTitle)
                    {
                        if (!hasAltTitle)
                        {
                            tune.altTitle = line.Substring(2);
                            hasAltTitle = true;
                        }                        
                    }
                    else
                    {
                        tune.title = line.Substring(2);
                        hasTitle = true;
                    }
                }
            }
            Console.WriteLine("Found " + currentTune + " tunes");
            for (int i = 0; i < currentTune; i++)
            {
                tunes[i].PrintHeaders();
            }
            Console.WriteLine("All done");
            Console.ReadLine();
        }
    }
}
