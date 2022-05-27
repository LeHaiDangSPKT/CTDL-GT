using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Stack<T>
    {
        public Node<T> pHead;
        public Node<T> pTail;
        public Stack()
        {
            pHead = null;
            pTail = null;
        }
        public void Push(Node<T> node)
        {
            if (pHead == null)
                pHead = pTail = node;
            else
            {
                node.pNext = pHead;
                pHead = node;
            }
        }
        public Node<T> Pop()
        {
            Node<T> temp;
            if (pHead == pTail)
            {
                temp = pHead;
                pHead = pTail = null;
                return temp;
            }
            else
            {
                temp = pHead;
                pHead = pHead.pNext;
                temp.pNext = null;
                return temp;
            }    
        }
    }
}
