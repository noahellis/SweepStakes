using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SweepStakes
{
    class SystemString : ICustomString
    {
        public string baseString = "ABCDEFGH";
        public void Insert(string stringToInsert, int index)
        {
            string newString = "";
            for (int i = 0; i<(index + baseString.Count()); i++)
            {
                if (i.Equals(index))
                {
                    newString += stringToInsert;
                    newString += baseString[i];
                }
                else
                {
                    newString += baseString[i];
                }
            }
            Console.WriteLine(newString);
            Console.ReadKey();
        }

        public int length()
        {
            int counter = 0;
            foreach(char letter in baseString)
            {
                counter++;
            }
            Console.WriteLine(counter);
            Console.ReadKey();
            return counter;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            string newString = "";
            for (int i = 0; i < baseString.Count(); i++)
            {
                if(i > startIndex && i < (startIndex + numCharsToRemove))
                {

                }
                else
                {
                    newString += baseString[i];
                }
            }
            Console.WriteLine(newString);
            Console.ReadKey();
        }
    }
}
