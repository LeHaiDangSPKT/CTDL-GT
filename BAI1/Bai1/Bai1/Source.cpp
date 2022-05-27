#include <iostream>
#include <conio.h>
using namespace std;

struct NODE {
	int data;
	NODE* pNext;
	NODE* pPrev;
};
struct LIST {
	NODE* pHead;
	NODE* pTail;
};

NODE* CreateNode(int x) {
	NODE* p = new NODE;
	p->data = x;
	p->pNext = NULL;
	p->pPrev = NULL;
	return p;
}
void CreateList(LIST& l) {
	l.pHead = NULL;
	l.pTail = NULL;
}

bool IsEmpty(LIST list) {
	return list.pTail == NULL;
}

void PrintList(LIST l) {
	if (!IsEmpty(l))
	{
		NODE* node1 = l.pHead;
		while (node1 != NULL) {
			cout << "________";
			node1 = node1->pNext;
		} cout << endl;

		NODE* node2 = l.pHead;
		while (node2 != NULL)
		{
			cout << "|   " << node2->data << "   ";
			node2 = node2->pNext;
		}
		cout << "|\n";
	}
}
NODE* GetNode(LIST l, int value) {
	NODE* p = l.pHead;
	while (p != NULL && p->data != value)
		p = p->pNext;
	if (p != NULL)
		return p;
	return NULL;
}

void AddFirst(LIST& list, NODE* p) {
	if (IsEmpty(list)) {
		list.pHead = p;
		list.pTail = p;
	}
	else {
		p->pNext = list.pHead;
		list.pHead->pPrev = p;
		list.pHead = p;
	}
}
void AddLast(LIST& list, NODE* p) {
	if (IsEmpty(list)) {
		list.pHead = p;
		list.pTail = p;
	}
	else {
		p->pPrev = list.pTail;
		list.pTail->pNext = p;
		list.pTail = p;
	}
}
void AddAfterQ(LIST& l, NODE* tam, NODE* q) {
	NODE* p = q->pNext;
	if (q != NULL) 
	{
		tam->pNext = p;
		tam->pPrev = q;
		q->pNext = tam;
		if (p != NULL)
			p->pPrev = tam;
		if (q == l.pTail) 
			l.pTail = tam;
	}
	else
		AddFirst(l, tam);
}
void DelFirst(LIST& list) {
	if (IsEmpty(list))
		cout << "\nDanh sach rong.";
	else {
		if (list.pHead == list.pTail) {
			list.pHead = NULL;
			list.pTail = NULL;
		}
		else {
			NODE* p = list.pHead->pNext;
			NODE* temp = list.pHead;
			p->pPrev = NULL;
			list.pHead = p;
			delete(temp);
		}
	}
}
void DelLast(LIST& list) {
	if (IsEmpty(list))
		cout << "\nDanh sach rong.";
	else {
		if (list.pHead == list.pTail) {
			list.pHead = NULL;
			list.pTail = NULL;
		}
		else {
			NODE* p = list.pTail->pPrev;
			NODE* temp = list.pTail;
			p->pNext = NULL;
			list.pTail = p;
			delete(temp);
		}
	}
}
void DelAfter(LIST& list, NODE* q) {
	if (IsEmpty(list))
		cout << "\nDanh sach rong.";
	else {
		NODE* p = q->pNext;
		if (p != NULL) {
			if (p == list.pTail) {
				DelLast(list);
				list.pTail = q;
			}
			else {
				q->pNext = p->pNext;
				p->pNext->pPrev = q;
				delete p;
			}
		}
	}
}
void Remove(LIST& list, NODE* x) {
	NODE* p = list.pHead;
	if (p == x)
		DelFirst(list);
	else {
		while (p->pNext != x)
			p = p->pNext;
		DelAfter(list, p);
	}
}
void QuickSort(LIST& list) {
	NODE* p, * X;
	LIST list1, list2;
	if (list.pHead == list.pTail)
		return;
	CreateList(list1);
	CreateList(list2);
	X = list.pHead;
	list.pHead = X->pNext;
	while (list.pHead != NULL) {
		p = list.pHead;
		list.pHead = p->pNext;
		if (list.pHead != NULL)
			list.pHead->pPrev = NULL;
		p->pNext = NULL;
		if (X->data >= p->data)
			AddFirst(list1, p);
		else
			AddFirst(list2, p);

	}
	QuickSort(list1);
	QuickSort(list2);
	if (list1.pHead != NULL) {
		list.pHead = list1.pHead;
		X->pPrev = list1.pTail;
		list1.pTail->pNext = X;
	}
	else 
		list.pHead = X;
	X->pNext = list2.pHead;
	if (list2.pHead != NULL)
		list2.pHead->pPrev = X;
	if (list2.pHead != NULL)
		list.pTail = list2.pTail;
	else
		list.pTail = X;
}
void SelectionSort(LIST& list) {

	LIST l1;
	CreateList(l1);
	while (!IsEmpty(list)) {
		NODE* p = list.pHead->pNext;
		NODE* min = list.pHead;
		while (p != NULL)
		{
			if (min->data > p->data)
				min = p;
			p = p->pNext;
		}

		AddFirst(l1, CreateNode(min->data));
		Remove(list, min);
	}

	list = l1;
}
bool ChangeFirst(LIST& list, int k, int x) {
	if (IsEmpty(list)) {
		cout << "\nDanh sach rong.";
		return false;
	}
	else {
		NODE* p = list.pHead;
		while (p != NULL) {
			if (p->data == k) {
				p->data = x;
				return true;
			}
			else
				p = p->pNext;
		}
		return false;
	}
}
void ChangeAll(LIST& list, int k, int x) {
	bool flag = true;
	if (k != x) 
		while (flag) 
			flag = ChangeFirst(list, k, x);
}
void ChangeLast(LIST& list, int k, int x) {
	if (IsEmpty(list)) 
		cout << "\nDanh sach rong.";
	else {
		NODE* p = list.pTail;
		while (p != NULL) {
			if (p->data == k) {
				p->data = x;
				break;
			}
			else 
				p = p->pPrev;
		}
	}
}
void DelAll(LIST& list, int k) {
	if (IsEmpty(list)) 
		cout << "\nDanh sach rong.";
	else {
		NODE* h = list.pHead;
		NODE* temp;
		while (h != NULL) {
			if (h->data == k) {
				temp = h->pNext;
				Remove(list, h);
				h = temp;
			}
			else
				h = h->pNext;
		}
	}
}
bool laNT(int a) {
	if (a < 2)
		return false;
	for (int i = 2; i < a / 2; i++)
		if (a % i == 0)
			return false;
	return true;
}
void AddAfterSNT(LIST& list, int k) {
	if (IsEmpty(list)) 
		cout << "\nDanh sach rong.";
	else {
		NODE* h = list.pHead;
		while (h != NULL) {
			if (laNT(h->data)) {
				AddAfterQ(list, CreateNode(k), h);
				h = h->pNext->pNext;
			}
			else
				h = h->pNext;
		}
	}
}
void MergeLists(LIST& list, LIST lTemp) {
	NODE* p = list.pHead;
	NODE* pTemp = lTemp.pHead;
	NODE* temp;
	while (pTemp != NULL) {
		temp = pTemp->pNext;
		AddAfterQ(list, pTemp, p);
		p = p->pNext->pNext;
		pTemp = temp;
	}
}

void showMenu1(LIST& list) {
	int k = 0, x;
	while (k != 4) {
		system("cls");
		cout << "\t\tDanh sach hien dang co\n";
		PrintList(list);

		cout << "\n\n\t\tBang chon chuc nang\n";
		cout << "**************************************************************";
		cout << "\n\t1. Them vao dau danh sach.";
		cout << "\n\t2. Them vao cuoi danh sach.";
		cout << "\n\t3. Them vao sau mot node da co.";
		cout << "\n\t4. Thoat.";
		cout << "\n\tMoi ban nhap lua chon: "; cin >> k;

		switch (k)
		{
			case 1:
				cout << "\nNhap gia tri muon them vao dau danh sach: "; cin >> k;
				AddFirst(list, CreateNode(k));
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 2:
				cout << "\nNhap gia tri muon them vao cuoi danh sach: "; cin >> k;
				AddLast(list, CreateNode(k));
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 3:
				cout << "\nNhap lan luot gia tri muon them va sau node nao: "; cin >> k; cin >> x;
				AddAfterQ(list, CreateNode(k), GetNode(list, x));
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 4:
			default:
				break;
		}
	}
}
void showMenu2(LIST &list) {
	int k = 0;
	while (k != 4) {
		system("cls");
		cout << "\t\tDanh sach hien dang co\n";
		PrintList(list);

		cout << "\n\n\t\tBang chon chuc nang\n";
		cout << "**************************************************************";
		cout << "\n\t1. Xoa node dau danh sach.";
		cout << "\n\t2. Xoa node danh sach.";
		cout << "\n\t3. Xoa node sau mot node da co.";
		cout << "\n\t4. Thoat.";
		cout << "\n\tMoi ban nhap lua chon: "; cin >> k;

		switch (k)
		{
			case 1:
				cout << "\nDa xoa thanh cong node dau danh sach!!!\n";
				DelFirst(list);
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 2:
				cout << "\nDa xoa thanh cong node cuoi danh sach!!!\n";
				DelLast(list); 
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 3:
				cout << "\nNhap gia tri node truoc node can xoa: "; cin >> k; 
				DelAfter(list, GetNode(list, k));
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 4:
			default:
				break;
		}
	}
}
void showMenu3(LIST &list) {
	int k = 0;
	while (k != 3) {
		system("cls");
		cout << "\t\tDanh sach hien dang co\n";
		PrintList(list);

		cout << "\n\n\t\tBang chon chuc nang\n";
		cout << "**************************************************************";
		cout << "\n\t1. Sap xep giam dan bang Selection Sort.";
		cout << "\n\t2. Sap xep tang dan bang Quick Sort.";
		cout << "\n\t3. Thoat.";
		cout << "\n\tMoi ban nhap lua chon: "; cin >> k;

		switch (k)
		{
			case 1:
				cout << "\nSau khi sap xep:\n";
				SelectionSort(list);
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 2:
				cout << "\nSau khi sap xep:\n";
				QuickSort(list);
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 3:
			default:
				break;
		}
	}
}
void showMenu4(LIST &list) {
	int k = 0, old, current;
	bool flag;
	while (k != 4) {
		system("cls");
		cout << "\t\tDanh sach hien dang co\n";
		PrintList(list);

		cout << "\n\n\t\tBang chon chuc nang\n";
		cout << "**************************************************************";
		cout << "\n\t1. Thay doi tat ca.";
		cout << "\n\t2. Thay doi node dau tien.";
		cout << "\n\t3. Thay doi node cuoi cung.";
		cout << "\n\t4. Thoat.";
		cout << "\n\tMoi ban nhap lua chon: "; cin >> k;
		if (k != 4) {
			cout << "\nMoi ban nhap gia tri muon thay doi: "; cin >> old;
			cout << "\nMoi ban nhap gia tri moi: "; cin >> current;
		}
		
		switch (k)
		{
			case 1:
				cout << "\nThay doi thanh cong!!!\n";
				ChangeAll(list, old, current);
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 2:
				cout << "\nThay doi thanh cong!!!\n";
				flag = ChangeFirst(list, old, current); // De su dung lai cho ChangeALL
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 3:
				cout << "\nThay doi thanh cong!!!\n";
				ChangeLast(list, old, current);
				PrintList(list);
				cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
				break;
			case 4:
			default:
				break;
		}
	}
}
void showMenu5(LIST &list) {
	int k = 0;
	system("cls");
	cout << "\t\tDanh sach hien dang co\n";
	PrintList(list);

	cout << "\n\n\t\tXoa tat ca cac node theo node cho truoc\n";
	cout << "\n\tNhap gia tri node can xoa: "; cin >> k;
	cout << "\nXoa thanh cong!!!\n";
	DelAll(list, k);
	PrintList(list);
	cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
}
void showMenu6(LIST &list) {
	int k = 0;
	system("cls");
	cout << "\t\tDanh sach hien dang co\n";
	PrintList(list);

	cout << "\n\n\t\tThem vao sau cac so nguyen to co trong danh sach mot gia tri nao do.\n";
	cout << "\n\tNhap gia tri muon them vao sau so nguyen to co trong danh sach: "; cin >> k;
	cout << "\nThem thanh cong!!!\n";
	AddAfterSNT(list, k);
	PrintList(list);
	cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
}
void showMenu7(LIST &list) {
	int k = 0;
	LIST lTemp;
	CreateList(lTemp);
	system("cls");
	cout << "\t\tDanh sach hien dang co\n";
	PrintList(list);

	cout << "\n\n\t\tBang chon chuc nang\n";
	cout << "**************************************************************";
	cout << "\n\t1. Su dung data tao san.";
	cout << "\n\t2. Nhap moi data.";
	cout << "\n\t3. Thoat.";
	cout << "\n\tMoi ban nhap lua chon: "; cin >> k;

	switch (k)
	{
		case 1:
			AddLast(lTemp, CreateNode(-8));
			AddLast(lTemp, CreateNode(-20));
			AddLast(lTemp, CreateNode(-13));
			AddLast(lTemp, CreateNode(-7));
			AddLast(lTemp, CreateNode(-5));
			cout << "\nDanh sach cac so am da duoc tao. Nhan phim bat ky de tiep tuc..."; _getch();
			MergeLists(list, lTemp);
			cout << "\nDanh sach da duoc noi lai, cac so am se dang xem voi cac so duong trong danh sach, nhan phim bat ky de in ra man hinh...\n\n";  _getch();
			PrintList(list);
			cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
			break;
		case 2:
			showMenu1(lTemp);
			cout << "\nDanh sach cac so am da duoc tao. Nhan phim bat ky de tiep tuc..."; _getch();
			MergeLists(list, lTemp);
			cout << "\nDanh sach da duoc noi lai, cac so am se dang xem voi cac so duong trong danh sach, nhan phim bat ky de in ra man hinh...\n\n";  _getch();
			PrintList(list);
			cout << "\nNhan phim bat ky de tiep tuc..."; _getch();
			break;
		case 3:
		default:
			break;
	}
}

int main() {
	LIST list;
	CreateList(list);
	int k = 0;

	AddLast(list, CreateNode(1));
	AddLast(list, CreateNode(8));
	AddLast(list, CreateNode(5));
	AddLast(list, CreateNode(6));
	AddLast(list, CreateNode(7));
	AddLast(list, CreateNode(2));
	AddLast(list, CreateNode(0));
	AddLast(list, CreateNode(15));

	while (k != 8) {
		system("cls");
		cout << "\t\tDanh sach hien dang co\n";
		PrintList(list);
		cout << "\n\n\t\tBang chon chuc nang\n"; 
		cout << "**************************************************************";
		cout << "\n\t1. Them node.";
		cout << "\n\t2. Xoa node.";
		cout << "\n\t3. Sap xep.";
		cout << "\n\t4. Thay doi gia tri.";
		cout << "\n\t5. Xoa tat ca cac node theo node cho truoc.";
		cout << "\n\t6. Them vao sau cac so nguyen to co trong danh sach mot gia tri nao do.";
		cout << "\n\t7. Tao mot danh sach lien ket cac so am va dan xen chung vao danh sach lien ket hien tai.";
		cout << "\n\t8. Thoat.";
		cout << "\n\tMoi ban nhap lua chon: "; cin >> k;
		switch (k)
		{
		case 1:
			showMenu1(list);
			break;
		case 2:
			showMenu2(list);
			break;
		case 3: 
			showMenu3(list);
			break;
		case 4:
			showMenu4(list);
			break;
		case 5:
			showMenu5(list);
			break;
		case 6:
			showMenu6(list);
			break;
		case 7:
			showMenu7(list);
			break;
		case 8:
		default:
			break;
		}
	}
	return 0;
}