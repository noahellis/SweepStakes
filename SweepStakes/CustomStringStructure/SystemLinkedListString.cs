using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SystemLinkedListString : ICustomString
    {

        List<char> stringToChars = new List<char>() { 'r', 'a', 'p', 't', 'u', 'r', 'e' };
        int stringChars;

        public void Insert(string stringToInsert, int index)
        {
            Node head = new Node(stringToChars[0]);
            Node current = head;
            stringToInsert.ToCharArray();

            if (index > 0)
            { 
                for(int i = 1; i < stringToChars.Count; i++)
                {
                    if (i == index)
                    {
                        
                    }
                    current.next = new Node(stringToChars[i]);
                    current = current.next;
                }
                for (int j = 0; j < index + stringToInsert.Length; j++)
                {
                    current.next = new Node(stringToInsert[j]);
                    current = current.next;
                }

                for (int k = index + stringToInsert.Length; k < stringToInsert.Length + stringToChars.Count; k++)
                {
                    current.next = new Node(stringToInsert[k]);
                    current = current.next;
                }
                
            }
        }

        public int length()
        {
            foreach(char chars in stringToChars)
            {
                stringChars++;
            }
            return stringChars;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
