using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_Winform
{
    public class Handler
    {
        //Dem so luong node
        public int CountNode(LIST list)
        {
            int sl = 0;
            NODE node = list.pHead;
            while (node != null)
            {
                sl++;
                node = node.pNext;
            }
            return sl;
        }
        //Tao node
        public NODE CreateNode(int x)
        {
            NODE p = new NODE();
            p.data = x;
            p.pNext = null;
            p.pPrev = null;
            return p;
        }
        //Kiem tra
        public bool IsEmpty(LIST list)
        {
            return list.pTail == null;
        }
        //Lay node
        public NODE GetNode(LIST list, int value)
        {
            NODE p = list.pHead;
            while (p != null && p.data != value)
                p = p.pNext;
            if (p != null)
                return p;
            return null;
        }
        //Them vao dau list
        public void AddFirst(ref LIST list, NODE p)
        {
            if (IsEmpty(list))
            {
                list.pHead = p;
                list.pTail = p;
            }
            else
            {
                p.pNext = list.pHead;
                list.pHead.pPrev = p;
                list.pHead = p;
            }
        }
        //Them vao cuoi list
        public void AddLast(ref LIST list, NODE p)
        {
            if (IsEmpty(list))
            {
                list.pHead = p;
                list.pTail = p;
            }
            else
            {
                p.pPrev = list.pTail;
                list.pTail.pNext = p;
                list.pTail = p;
            }
        }
        ////Them tai vi tri bat ki
        public void AddAfterQ(ref LIST l, NODE tam, NODE q)
        {
            NODE p = q.pNext;
            if (q != null)
            {
                tam.pNext = p;
                tam.pPrev = q;
                q.pNext = tam;
                if (p != null)
                    p.pPrev = tam;
                if (q == l.pTail)
                    l.pTail = tam;
            }
            else
                AddFirst(ref l, tam);
        }
        //Xoa dau list
        public void DelFirst(ref LIST list)
        {
            if (IsEmpty(list))
                Console.Write("\nDanh sach rong.");
            else
            {
                if (list.pHead == list.pTail)
                {
                    list.pHead = null;
                    list.pTail = null;
                }
                else
                {
                    NODE p = list.pHead.pNext;
                    //NODE temp = list.pHead;
                    p.pPrev = null;
                    list.pHead = p;
                    //delete(temp);
                }
            }
        }
        //Xoa cuoi
        public void DelLast(ref LIST list)
        {
            if (IsEmpty(list))
                Console.Write("\nDanh sach rong.");
            else
            {
                if (list.pHead == list.pTail)
                {
                    list.pHead = null;
                    list.pTail = null;
                }
                else
                {
                    NODE p = list.pTail.pPrev;
                    //NODE temp = list.pTail;
                    p.pNext = null;
                    list.pTail = p;
                    //delete(temp);
                }
            }
        }
        //Xoa sau node
        public void DelAfter(ref LIST list, NODE q)
        {
            if (IsEmpty(list))
                Console.Write("\nDanh sach rong.");
            else
            {
                NODE p = q.pNext;
                if (p != null)
                {
                    if (p == list.pTail)
                    {
                        DelLast(ref list);
                        list.pTail = q;
                    }
                    else
                    {
                        q.pNext = p.pNext;
                        p.pNext.pPrev = q;
                        //delete p;
                    }
                }
            }
        }
        //Remove tai dung node do
        public void Remove(ref LIST list, NODE x)
        {
            NODE p = list.pHead;
            if (p == x)
                DelFirst(ref list);
            else
            {
                while (p.pNext != x)
                    p = p.pNext;
                DelAfter(ref list, p);
            }
        }
        //QuickSort
        public void QuickSort(ref LIST list)
        {
            NODE p, X;
            LIST list1 = new LIST();
            LIST list2 = new LIST();
            if (list.pHead == list.pTail)
                return;
            X = list.pHead;
            list.pHead = X.pNext;
            while (list.pHead != null)
            {
                p = list.pHead;
                list.pHead = p.pNext;
                if (list.pHead != null)
                    list.pHead.pPrev = null;
                p.pNext = null;
                if (X.data >= p.data)
                    AddFirst(ref list1, p);
                else
                    AddFirst(ref list2, p);

            }
            QuickSort(ref list1);
            QuickSort(ref list2);
            if (list1.pHead != null)
            {
                list.pHead = list1.pHead;
                X.pPrev = list1.pTail;
                list1.pTail.pNext = X;
            }
            else
                list.pHead = X;
            X.pNext = list2.pHead;
            if (list2.pHead != null)
                list2.pHead.pPrev = X;
            if (list2.pHead != null)
                list.pTail = list2.pTail;
            else
                list.pTail = X;
        }
        //SelectionSort
        public void SelectionSort(ref LIST list)
        {
            LIST l1 = new LIST();
            while (!IsEmpty(list))
            {
                NODE p = list.pHead.pNext;
                NODE min = list.pHead;
                while (p != null)
                {
                    if (min.data > p.data)
                        min = p;
                    p = p.pNext;
                }

                AddFirst(ref l1, CreateNode(min.data));
                Remove(ref list, min);
            }

            list = l1;
        }
        //Thay doi gia tri node dau
        public bool ChangeFirst(ref LIST list, int k, int x)
        {
            if (IsEmpty(list))
            {
                Console.Write("\nDanh sach rong.");
                return false;
            }
            else
            {
                NODE p = list.pHead;
                while (p != null)
                {
                    if (p.data == k)
                    {
                        p.data = x;
                        return true;
                    }
                    else
                        p = p.pNext;
                }
                return false;
            }
        }
        //Thay doi gia tri node cuoi
        public void ChangeLast(ref LIST list, int k, int x)
        {
            if (IsEmpty(list))
                Console.Write("\nDanh sach rong.");
            else
            {
                NODE p = list.pTail;
                while (p != null)
                {
                    if (p.data == k)
                    {
                        p.data = x;
                        break;
                    }
                    else
                        p = p.pPrev;
                }
            }
        }
        //Thay doi gia tri cua tat ca cac node
        public void ChangeAll(ref LIST list, int k, int x)
        {
            bool flag = true;
            if (k != x)
                while (flag)
                    flag = ChangeFirst(ref list, k, x);
        }
        //Xoa tat ca cac node
        public void DelAll(ref LIST list, int k)
        {
            if (IsEmpty(list))
                Console.Write("\nDanh sach rong.");
            else
            {
                NODE h = list.pHead;
                NODE temp;
                while (h != null)
                {
                    if (h.data == k)
                    {
                        temp = h.pNext;
                        Remove(ref list, h);
                        h = temp;
                    }
                    else
                        h = h.pNext;
                }
            }
        }
        //Kiem tra so nguyen to
        public bool laNT(int a)
        {
            if (a < 2)
                return false;
            for (int i = 2; i < a / 2; i++)
                if (a % i == 0)
                    return false;
            return true;
        }
        //Them node sau so nguyen to
        public void AddAfterSNT(ref LIST list, int k)
        {
            if (IsEmpty(list))
                Console.Write("\nDanh sach rong.");
            else
            {
                NODE h = list.pHead;
                while (h != null)
                {
                    if (laNT(h.data))
                    {
                        AddAfterQ(ref list, CreateNode(k), h);
                        h = h.pNext.pNext;
                    }
                    else
                        h = h.pNext;
                }
            }
        }
        //Dan xen 2 danh sach lien ket
        public void MergeLists(ref LIST list, LIST lTemp)
        {
            NODE p = list.pHead;
            NODE pTemp = lTemp.pHead;
            NODE temp;
            while (pTemp != null)
            {
                temp = pTemp.pNext;
                AddAfterQ(ref list, pTemp, p);
                p = p.pNext.pNext;
                pTemp = temp;
            }
        }
    }
}
