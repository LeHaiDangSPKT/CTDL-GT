using System;

namespace Bai1_C_Sharp_
{
    class Program
    {
        public class NODE
        {
            public int data;
            public NODE pNext;
            public NODE pPrev;
            public NODE()
            {

            }
        };

        public class LIST
        {
            public NODE pHead;
            public NODE pTail;
            public LIST()
            {
                pHead = null;
                pTail = null;
            }
        };

        public class Handler
        {
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
            //In danh sach
            public void PrintList(LIST list)
            {
                if (!IsEmpty(list))
                {
                    NODE node1 = list.pHead;
                    while (node1 != null)
                    {
                        Console.Write("________");
                        node1 = node1.pNext;
                    }
                    Console.WriteLine();

                    NODE node2 = list.pHead;
                    while (node2 != null)
                    {
                        Console.Write( "|   {0}   ", node2.data);
                        node2 = node2.pNext;
                    }
                    Console.WriteLine("|");
                }
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
            void SelectionSort(ref LIST list)
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
                PrintList(list);
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
            void MergeLists(ref LIST list, LIST lTemp)
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

            public void showMenu1(ref LIST list)
            {
                int k = 0, x;
                while (k != 4)
                {
                    Console.Clear();
                    Console.Write("\t\tDanh sach hien dang co\n");
                    PrintList(list);

                    Console.Write("\n\n\t\tBang chon chuc nang\n");
                    Console.Write("**************************************************************");
                    Console.Write("\n\t1. Them vao dau danh sach.");
                    Console.Write("\n\t2. Them vao cuoi danh sach.");
                    Console.Write("\n\t3. Them vao sau mot node da co.");
                    Console.Write("\n\t4. Thoat.");
                    Console.Write("\n\tMoi ban nhap lua chon: ");
                    k = int.Parse(Console.ReadLine());

                    switch (k)
                    {
                        case 1:
                            Console.Write("\nNhap gia tri muon them vao dau danh sach: ");
                            k = int.Parse(Console.ReadLine());

                            AddFirst(ref list, CreateNode(k));
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                            break;
                        case 2:
                            Console.Write("\nNhap gia tri muon them vao cuoi danh sach: ");
                            k = int.Parse(Console.ReadLine());

                            AddLast(ref list, CreateNode(k));
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("\nNhap lan luot gia tri muon them va sau node nao: ");
                            k = int.Parse(Console.ReadLine());
                            x = int.Parse(Console.ReadLine());
                            AddAfterQ(ref list, CreateNode(k), GetNode(list, x));
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                            break;
                        case 4:
                        default:
                            break;
                    }
                }
            }
            public void showMenu2(ref LIST list)
            {
                int k = 0;
                while (k != 4)
                {
                    Console.Clear();
                    Console.Write("\t\tDanh sach hien dang co\n");
                    PrintList(list);

                    Console.Write("\n\n\t\tBang chon chuc nang\n");
                    Console.Write("**************************************************************");
                    Console.Write("\n\t1. Xoa node dau danh sach.");
                    Console.Write("\n\t2. Xoa node cuoi danh sach.");
                    Console.Write("\n\t3. Xoa node sau mot node da co.");
                    Console.Write("\n\t4. Thoat.");
                    Console.Write("\n\tMoi ban nhap lua chon: ");
                    k = int.Parse(Console.ReadLine());

                    switch (k)
                    {
                        case 1:
                            Console.Write("\nDa xoa thanh cong node dau danh sach!!!\n");
                            DelFirst(ref list);
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                            break;
                        case 2:
                            Console.Write("\nDa xoa thanh cong node cuoi danh sach!!!\n");
                            DelLast(ref list);
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("\nNhap gia tri node truoc node can xoa: ");
                            k = int.Parse(Console.ReadLine());
                            DelAfter(ref list, GetNode(list, k));
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                            break;
                        case 4:
                        default:
                            break;
                    }
                }
            }
            public void showMenu3(ref LIST list)
            {
                int k = 0;
                while (k != 3)
                {
                    Console.Clear();
                    Console.Write("\t\tDanh sach hien dang co\n");
                    PrintList(list);

                    Console.Write("\n\n\t\tBang chon chuc nang\n");
                    Console.Write("**************************************************************");
                    Console.Write("\n\t1. Sap xep giam dan bang Selection Sort.");
                    Console.Write("\n\t2. Sap xep tang dan bang Quick Sort.");
                    Console.Write("\n\t3. Thoat.");
                    Console.Write("\n\tMoi ban nhap lua chon: ");
                    k = int.Parse(Console.ReadLine());

                    switch (k)
                    {
                        case 1:
                            Console.Write("\nSau khi sap xep:\n");
                            SelectionSort(ref list);
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                            break;
                        case 2:
                            Console.Write("\nSau khi sap xep:\n");
                            QuickSort(ref list);
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey(); 
                            break;
                        case 3:
                        default:
                            break;
                    }
                }
            }
            public void showMenu4(ref LIST list)
            {
                int k = 0, old, current;
                bool flag;
                while (k != 4)
                {
                    Console.Clear();
                    Console.Write("\t\tDanh sach hien dang co\n");
                    PrintList(list);

                    Console.Write("\n\n\t\tBang chon chuc nang\n");
                    Console.Write("**************************************************************");
                    Console.Write("\n\t1. Thay doi tat ca.");
                    Console.Write("\n\t2. Thay doi node dau tien.");
                    Console.Write("\n\t3. Thay doi node cuoi cung.");
                    Console.Write("\n\t4. Thoat.");
                    Console.Write("\n\tMoi ban nhap lua chon: "); 
                    k = int.Parse(Console.ReadLine());
                    if (k == 4)
                        break;
                    Console.Write("\nMoi ban nhap gia tri muon thay doi: ");
                    old = int.Parse(Console.ReadLine());
                    Console.Write("\nMoi ban nhap gia tri moi: "); 
                    current = int.Parse(Console.ReadLine());

                    switch (k)
                    {
                        case 1:
                            Console.Write("\nThay doi thanh cong!!!\n");
                            ChangeAll(ref list, old, current);
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                            break;
                        case 2:
                            Console.Write("\nThay doi thanh cong!!!\n");
                            flag = ChangeFirst(ref list, old, current); // De su dung lai cho ChangeALL
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("\nThay doi thanh cong!!!\n");
                            ChangeLast(ref list, old, current);
                            PrintList(list);
                            Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                            break;
                        case 4:
                        default:
                            break;
                    }
                }
            }
            public void showMenu5(ref LIST list)
            {
                int k = 0;
                Console.Clear();
                Console.Write("\t\tDanh sach hien dang co\n");
                PrintList(list);

                Console.Write("\n\n\t\tXoa tat ca cac node theo node cho truoc\n");
                Console.Write("\n\tNhap gia tri node can xoa: "); 
                k = int.Parse(Console.ReadLine());
                Console.Write("\nXoa thanh cong!!!\n");
                DelAll(ref list, k);
                PrintList(list);
                Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
            }
            public void showMenu6(ref LIST list)
            {
                int k = 0;
                Console.Clear();
                Console.Write("\t\tDanh sach hien dang co\n");
                PrintList(list);

                Console.Write("\n\n\t\tThem vao sau cac so nguyen to co trong danh sach mot gia tri nao do.\n");
                Console.Write("\n\tNhap gia tri muon them vao sau so nguyen to co trong danh sach: ");
                k = int.Parse(Console.ReadLine());
                Console.Write("\nThem thanh cong!!!\n");
                AddAfterSNT(ref list, k);
                PrintList(list);
                Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
            }
            public void showMenu7(ref LIST list)
            {
                int k = 0;
                LIST lTemp = new LIST();
                Console.Clear();
                Console.Write("\t\tDanh sach hien dang co\n");
                PrintList(list);

                Console.Write("\n\n\t\tBang chon chuc nang\n");
                Console.Write("**************************************************************");
                Console.Write("\n\t1. Su dung data tao san.");
                Console.Write("\n\t2. Nhap moi data.");
                Console.Write("\n\t3. Thoat.");
                Console.Write("\n\tMoi ban nhap lua chon: "); 
                k = int.Parse(Console.ReadLine());

                switch (k)
                {
                    case 1:
                        AddLast(ref lTemp, CreateNode(-8));
                        AddLast(ref lTemp, CreateNode(-20));
                        AddLast(ref lTemp, CreateNode(-13));
                        AddLast(ref lTemp, CreateNode(-7));
                        AddLast(ref lTemp, CreateNode(-5));
                        Console.Write("\nDanh sach cac so am da duoc tao. Nhan phim bat ky de tiep tuc..."); Console.ReadKey();
                        MergeLists(ref list, lTemp);
                        Console.Write("\nDanh sach da duoc noi lai, cac so am se dang xem voi cac so duong trong danh sach, nhan phim bat ky de in ra man hinh...\n\n"); Console.ReadKey();
                        PrintList(list);
                        Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                        break;
                    case 2:
                        showMenu1(ref lTemp);
                        Console.Write("\nDanh sach cac so am da duoc tao. Nhan phim bat ky de tiep tuc..."); Console.ReadKey();
                        MergeLists(ref list, lTemp);
                        Console.Write("\nDanh sach da duoc noi lai, cac so am se dang xem voi cac so duong trong danh sach, nhan phim bat ky de in ra man hinh...\n\n"); Console.ReadKey();
                        PrintList(list);
                        Console.Write("\nNhan phim bat ky de tiep tuc..."); Console.ReadKey();
                        break;
                    case 3:
                    default:
                        break;
                }
            }

        }
        public class Test
        {
            public static void Main(string[] args)
            {
                LIST list = new LIST();
                Handler handler = new Handler();
                int k = 0;

                handler.AddLast(ref list, handler.CreateNode(1));  
                handler.AddLast(ref list, handler.CreateNode(8));
                handler.AddLast(ref list, handler.CreateNode(5));
                handler.AddLast(ref list, handler.CreateNode(6));
                handler.AddLast(ref list, handler.CreateNode(7));
                handler.AddLast(ref list, handler.CreateNode(2));
                handler.AddLast(ref list, handler.CreateNode(0));
                handler.AddLast(ref list, handler.CreateNode(15));

                while (k != 8)
                {
                    Console.Clear();
                    Console.Write("\t\tDanh sach hien dang co\n");
                    handler.PrintList(list);
                    Console.Write("\n\n\t\tBang chon chuc nang\n");
                    Console.Write("**************************************************************");
                    Console.Write("\n\t1. Them node.");
                    Console.Write("\n\t2. Xoa node.");
                    Console.Write("\n\t3. Sap xep.");
                    Console.Write("\n\t4. Thay doi gia tri.");
                    Console.Write("\n\t5. Xoa tat ca cac node theo node cho truoc.");
                    Console.Write("\n\t6. Them vao sau cac so nguyen to co trong danh sach mot gia tri nao do.");
                    Console.Write("\n\t7. Tao mot danh sach lien ket cac so am va dan xen chung vao danh sach lien ket hien tai.");
                    Console.Write("\n\t8. Thoat.");
                    Console.Write("\n\tMoi ban nhap lua chon: ");
                    k = int.Parse(Console.ReadLine());

                    switch (k)
                    {
                        case 1:
                            handler.showMenu1(ref list);
                            break;
                        case 2:
                            handler.showMenu2(ref list);
                            break;
                        case 3:
                            handler.showMenu3(ref list);
                            break;
                        case 4:
                            handler.showMenu4(ref list);
                            break;
                        case 5:
                            handler.showMenu5(ref list);
                            break;
                        case 6:
                            handler.showMenu6(ref list);
                            break;
                        case 7:
                            handler.showMenu7(ref list);
                            break;
                        case 8:
                        default:
                            break;
                    }
                }
            }
        }
    }
}
