using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class LIST
    {
        public Node pHead;
        public Node pTail;

        public LIST()
        {
            pHead = null;
            pTail = null;
        }
        public void AddLast(Word word)
        {
            Node temp = new Node(word);
            if (pHead == null)
                pHead = pTail = temp;
            else
            {
                pTail.pNext = temp;
                pTail = temp;
            }
        }
        public void RemoveFirst()
        {
            if (pHead == pTail)
                pHead = pTail = null;
            else
            {
                Node temp = pHead;
                pHead = pHead.pNext;
                temp = null;
            }
        }
        public void RemoveLast()
        {
            if (pHead == pTail)
                pHead = pTail = null;
            else
            {
                Node temp = pHead;
                while (temp.pNext != pTail)
                    temp = temp.pNext;
                temp.pNext = null;
                pTail = null;
                pTail = temp;
            }
        }
        public void RemoveAfter(Node node)
        {
            Node temp = node.pNext;
            node.pNext = node.pNext.pNext;
            temp = null;
        }
        public Word SeachItem(string word)
        {
            Node temp = pHead;
            while (temp != null)
            {
                if (temp.key.word == word)
                    break;
                temp = temp.pNext;
            }
            if (temp == null)
                return null;
            return temp.key;       
        }
        public void PrintList()
        {
            Node temp = pHead;
            while(temp != null)
            {
                Console.Write("{0} -> ", temp.key.word);
                temp = temp.pNext;
            }
        }
    }
}
