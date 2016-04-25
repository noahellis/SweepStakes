using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Sweepstakes sweepstakesInfo = new Sweepstakes();
        Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();
        public Contestant GetNextSweepstakesWinner()
        {
            Random random = new Random();
            InsertSweepstakes(sweepstakesInfo);
            sweepstakesInfo.RegisterContestant();
            sweepstakesInfo.CreateDictionary();
            Console.WriteLine("\nQueue Example:\n");         
            for (int i = 0; i < sweepstakesQueue.Count; i++)
            {
                int randomInt = random.Next(0, 49);
                Console.WriteLine("Winner of {0} is {1}", sweepstakesQueue.ElementAt(i).sweepstakesName, sweepstakesInfo.ContestantDictionary.ElementAt(randomInt).Value.firstName);
            }
            return null;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(new Sweepstakes("Publisher's Clearinghouse"));
            sweepstakesQueue.Enqueue(new Sweepstakes("Noah's Super Sweepstakes"));
            sweepstakesQueue.Enqueue(new Sweepstakes("devCodeCamp Sweepstakes"));
        }

    }
}
