using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Node<T>
    {
        public T key;
        public Node<T> pNext;
        public Node()
        {
            pNext = null;
        }
        public Node(T key)
        {
            this.key = key;
            pNext = null;
        }
        public Node(Node<T> node)
        {
            this.key = node.key;
            this.pNext = node.pNext;
        }
    }
}
