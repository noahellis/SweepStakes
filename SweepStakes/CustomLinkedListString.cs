using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SweepStakes
{
    class CustomLinkedListString : ICustomString
    {
        void ICustomString.Insert(string stringToInsert)
        {
            throw new NotImplementedException();
        }

        int ICustomString.length()
        {
            throw new NotImplementedException();
        }

        void ICustomString.Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }

        string ICustomString.ToString()
        {
            throw new NotImplementedException();
        }
    }
}
