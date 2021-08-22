using System;
using System.Collections.Generic;
using System.Text;

namespace ThoughtWorks
{
    class Bowler
    {
        private Random random;

        public Bowler()
        {
            Random random = new Random();

        }
        public int Bowl()
        {
            int Bowledrun = random.Next(1,6);
            return Bowledrun;
        }
    }
}
