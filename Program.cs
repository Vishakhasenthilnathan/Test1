using System;

namespace ThoughtWorks
{
    class Cricket
    {
       
        static void Main(string[] args)
        {          
            var Chase = Console.ReadLine();
            int ToBeChased = Convert.ToInt32(Chase);
            int NumberOfOvers = Convert.ToInt32(Console.ReadLine());
            int TypeOfBatsman = Convert.ToInt32(Console.ReadLine());
            if (TypeOfBatsman == 0)
            {
                IBatsman batsman = new Batsman(NumberOfOvers, ToBeChased);
                batsman.Bat(ToBeChased, NumberOfOvers);
                Console.ReadKey();
            }
            else if (TypeOfBatsman == 1)
            {
                IBatsman HitMan = new HitBatsman(NumberOfOvers, ToBeChased);
                HitMan.Bat(ToBeChased, NumberOfOvers);
                Console.ReadKey();
            }
            else
            {
                IBatsman DefensiveBatman = new DefensiveBatman(NumberOfOvers, ToBeChased);
                DefensiveBatman.Bat(ToBeChased, NumberOfOvers);
                Console.ReadKey();
            }
            //int TypeOfBowler = Convert.ToInt32(Console.ReadLine());
            //if (TypeOfBowler == 1)
            //{
            //    Batsman batsman = new Batsman(NumberOfOvers, ToBeChased);
            //    batsman.Bat(ToBeChased, NumberOfOvers);
            //    Console.ReadKey();
            //}
            //else
            //{
            //    HitBatsman batsman = new HitBatsman(NumberOfOvers, ToBeChased);
            //    batsman.Bat(ToBeChased, NumberOfOvers);
            //    Console.ReadKey();
            //}

        }
    }
  
}
