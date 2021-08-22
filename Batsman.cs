using System;
using System.Collections.Generic;
using System.Text;

namespace ThoughtWorks
{
    public class Batsman :IBatsman
    {
        public int runScored = 0;

        private int _NumberofOvers { get; set; }
        private int _ToBeChased { get; set; }
        private Bowler bowler;
        private Random random;

        public Batsman(int NumberOfOvers, int ToBeChased)
        {
            _NumberofOvers = NumberOfOvers;
            _ToBeChased = ToBeChased;
            Random random = new Random();

            Bowler bowler = new Bowler();
        }
        public bool Bat(int NumberOfOvers, int ToBechased)
        {
            for (int j = 1; j <= NumberOfOvers; j++)
            {
                for (int i = 1; i <= 6; i++)
                {
                    Console.WriteLine("Ball {0} :", i);
                    int hit = random.Next(0, 6);

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
