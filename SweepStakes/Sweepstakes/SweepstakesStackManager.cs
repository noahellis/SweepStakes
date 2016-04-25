using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Sweepstakes sweepstakesInfo = new Sweepstakes();
        Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();
        public Contestant GetNextSweepstakesWinner()
        {
            Random random = new Random();
            InsertSweepstakes(sweepstakesInfo);
            sweepstakesInfo.RegisterContestant();
            sweepstakesInfo.CreateDictionary();
            Console.WriteLine("\nStack Example:\n");
            for (int i = 0; i < sweepstakesStack.Count; i++)
            {
                int randomInt = random.Next(0, 49);
                Console.WriteLine("Winner of {0} is {1}", sweepstakesStack.ElementAt(i).sweepstakesName, sweepstakesInfo.ContestantDictionary.ElementAt(randomInt).Value.firstName);
            }
            return null;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(new Sweepstakes("Publisher's Clearinghouse"));
            sweepstakesStack.Push(new Sweepstakes("Noah's Super Sweepstakes"));
            sweepstakesStack.Push(new Sweepstakes("devCodeCamp Sweepstakes"));
        }
    }
}
