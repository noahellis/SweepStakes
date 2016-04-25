using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SystemArrayString : ICustomString
    {
        Char[] charArray = new Char[] { 's', 'a', 'u', 'c', 'e' };

        public void Insert(string stringToInsert, int index)
        {
            Char[] newArray = new Char[charArray.Length + stringToInsert.Count()];
            int j = 0;
            int k = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i>= index && i < (stringToInsert.Count()+ index))
                {
                    newArray[i] += stringToInsert[j];
                    j++;
                }
                else
                {
                    newArray[i] = charArray[k];
                    k++;
                }
            }
            foreach (Char letter in newArray)
            {
                Console.Write(letter);

            }
            Console.ReadKey();
        }

        public int length()
        {
            int number = 0;
            foreach(Char letter in charArray)
            {
                number++;
            }
            return number;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            int newLength = (charArray.Length - numCharsToRemove);
            Char[] newArray = new Char[newLength];
            int j = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i >= startIndex && i < (startIndex + numCharsToRemove))
                {

                }
                else
                {
                    newArray[j] += charArray[i];
                    j++;
                }
            }
            foreach(Char letter in newArray)
            {
                Console.Write(letter);

            }
            Console.ReadLine();
        }
    }
}
