using System;
using System.Collections.Generic;
using System.Text;

namespace ThoughtWorks
{
    class DefensiveBatman : IBatsman
    {
        public int runScored = 0;

        private int _NumberofOvers { get; set; }
        private int _ToBeChased { get; set; }
        private Bowler bowler;
        private Random random;
        int[] PossibleRuns;
        public DefensiveBatman(int NumberOfOvers, int ToBeChased)
        {
            _NumberofOvers = NumberOfOvers;
            _ToBeChased = ToBeChased;
            Bowler bowler = new Bowler();
            Random random = new Random();
            PossibleRuns = new int[] { 0, 1, 2, 3 };
        }
        public bool Bat(int NumberOfOvers, int ToBechased)
        {
            for (int j = 1; j <= NumberOfOvers; j++)
            {
                for (int i = 1; i <= 6; i++)
                {
                    Console.WriteLine("Ball {0} :", i);
                    int hit = PossibleRuns[random.Next(0, PossibleRuns.Length)];

                    runScored = runScored + hit;
                    Console.WriteLine("Runs so far {0}", runScored);
                    if (IsBatsmanWon(runScored, ToBechased))
                    {
                        Console.WriteLine("Batsman won");
                        return true;
                    }
                    if ((runScored < ToBechased && i == 6 && j == NumberOfOvers) || hit == bowler.Bowl())
                    {
                        Console.WriteLine("Batsman lost");
                        return false;
                    }
                }
            }
            return false;
        }
        public bool IsBatsmanWon(int runScored, int ToBechased)
        {
            return runScored >= ToBechased;
        }
    }
}
