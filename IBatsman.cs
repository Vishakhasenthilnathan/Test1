using System;
using System.Collections.Generic;
using System.Text;

namespace ThoughtWorks
{
    interface IBatsman
    {
     
        bool Bat(int NumberOfOvers, int ToBechased);
        bool IsBatsmanWon(int runScored, int ToBechased)
    }
}
