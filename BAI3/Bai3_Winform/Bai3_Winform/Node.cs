using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_Winform
{
    public class Node
    {
        public Word key;
        public Node pNext;

        public Node()
        {
            pNext = null;
        }
        public Node(Word key)
        {
            this.key = key;
            this.pNext = null;
        }
        public Node(Node node)
        {
            this.key = node.key;
            this.pNext = node.pNext;
        }
    }
}
