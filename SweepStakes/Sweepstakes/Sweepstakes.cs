using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public  class Sweepstakes 
    {
        public string sweepstakesName;
        List<Contestant> contestantList = new List<Contestant>();
        Dictionary<int, Contestant> contestantDictionary = new Dictionary<int, Contestant>();

        public Dictionary<int, Contestant> ContestantDictionary
        {
            get
            {
                return contestantDictionary;
            }

            set
            {
                contestantDictionary = value;
            }
        }

        public Sweepstakes(string sweepstakesName)
        {
            this.sweepstakesName = sweepstakesName;
        }
        public Sweepstakes()
        {
            
        }
        public void RegisterContestant()
        {
            contestantList.Add(new Contestant("Tarra"));
            contestantList.Add(new Contestant("Monique"));
            contestantList.Add(new Contestant("Fran"));
            contestantList.Add(new Contestant("Echo"));
            contestantList.Add(new Contestant("Shawanna"));
            contestantList.Add(new Contestant("Queen"));
            contestantList.Add(new Contestant("Phoebe"));
            contestantList.Add(new Contestant("Jessenia"));
            contestantList.Add(new Contestant("Edgardo"));
            contestantList.Add(new Contestant("Reuben"));
            contestantList.Add(new Contestant("Hector"));
            contestantList.Add(new Contestant("Tayna"));
            contestantList.Add(new Contestant("Raylene"));
            contestantList.Add(new Contestant("Solange"));
            contestantList.Add(new Contestant("Jermaine"));
            contestantList.Add(new Contestant("Jacquiline"));
            contestantList.Add(new Contestant("Madge"));
            contestantList.Add(new Contestant("Ivan"));
            contestantList.Add(new Contestant("Shaun"));
            contestantList.Add(new Contestant("Caleb"));
            contestantList.Add(new Contestant("Isobel"));
            contestantList.Add(new Contestant("Arline"));
            contestantList.Add(new Contestant("Mari"));
            contestantList.Add(new Contestant("Candelaria"));
            contestantList.Add(new Contestant("Clorinda"));
            contestantList.Add(new Contestant("Melany"));
            contestantList.Add(new Contestant("Enoch"));
            contestantList.Add(new Contestant("Kristen"));
            contestantList.Add(new Contestant("Ann"));
            contestantList.Add(new Contestant("Amparo"));
            contestantList.Add(new Contestant("Tosha"));
            contestantList.Add(new Contestant("Nova"));
            contestantList.Add(new Contestant("Jaqueline"));
            contestantList.Add(new Contestant("Nickolas"));
            contestantList.Add(new Contestant("Opal"));
            contestantList.Add(new Contestant("Angelic"));
            contestantList.Add(new Contestant("Lise"));
            contestantList.Add(new Contestant("Ozie"));
            contestantList.Add(new Contestant("Latasha"));
            contestantList.Add(new Contestant("Randolph"));
            contestantList.Add(new Contestant("Terri"));
            contestantList.Add(new Contestant("Sherley"));
            contestantList.Add(new Contestant("Imogene"));
            contestantList.Add(new Contestant("Leon"));
            contestantList.Add(new Contestant("Violet"));
            contestantList.Add(new Contestant("Ahmed"));
            contestantList.Add(new Contestant("Jesse"));
            contestantList.Add(new Contestant("Reed"));
            contestantList.Add(new Contestant("Maisie"));
        }
        public string PickWinner()
        {
            return null;
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
        public void CreateDictionary()

        {
            for(int i = 0; i < contestantList.Count; i++)
            {
                ContestantDictionary.Add(i, contestantList[i]);
            }
        }

    }
}
