using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Node
    {
        public char chars;
        public Node next;
        public Node(char chars)
        {
            this.chars = chars;
            this.next = null;
        }
    }
}
