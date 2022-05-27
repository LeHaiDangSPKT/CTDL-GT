using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;


namespace Bai3_Winform
{
    public class Handler
    {
        public Handler() { }
       
        public Word Input1(ref HashTable hashTable, string Input)
        {
            Word word;
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input.ToLower());
            word = hashTable.SearchItem(Input);
            if (word == null)
            {
                MessageBox.Show("Không tìm thấy từ \"{" + Input + "}\" ");
                hashTable.history.Add(new Word(Input, null));
                return null;
            }
            else
            {
                hashTable.history.Add(word);
                return word;
            }
        }

        public void AddNewWord(ref HashTable hashTable, string Input, string loaiBt, string loaiTenRieng, string tbNghiabt, string tbTenRieng)
        {
            Word word;
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input.ToLower());
            word = hashTable.SearchItem(Input);

            if (word != null)
                MessageBox.Show("Từ \"" + Input + "\" đã tồn tại");
            else
            {   
                if (tbNghiabt != null && tbTenRieng != null)
                {
                    hashTable.AddItem(new Word(Input, 0, loaiBt, tbNghiabt));
                    hashTable.SearchItem(Input).meanings.Add(new Meaning(1, loaiTenRieng,tbTenRieng));
                }
                else if (tbNghiabt != null)
                    hashTable.AddItem(new Word(Input, 0, loaiBt, tbNghiabt));
                else
                    hashTable.AddItem(new Word(Input, 1, loaiTenRieng, tbTenRieng));
                MessageBox.Show("Thêm thành công!");

            }
        }
        
        public void AddNewMeaning(ref HashTable hashTable, string Input, string properInput, string loai, string nghia)
        {
            int proper;
            if (properInput == "Tên riêng")
                proper = 1;
            else
                proper = 0;
            Word word;
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input.ToLower());
            word = hashTable.SearchItem(Input);
            if (word == null)
                MessageBox.Show("Không tìm thấy từ \"{" + Input + "}\" ");
            else
                word.meanings.Add(new Meaning(proper, loai, nghia));
        }
        
        public void RemoveWord(ref HashTable hashTable, string Input)
        {
            Word word;
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input.ToLower());
            word = hashTable.SearchItem(Input);
            if (word == null)
                MessageBox.Show("Không tìm thấy từ \"{" + Input + "}\" ");
            else
            {
                LIST list = hashTable.hashtable[hashTable.HashFunction(word.word).Item1, hashTable.HashFunction(word.word).Item2];
                if (list.pHead.key == word)
                    list.RemoveFirst();
                else if (list.pTail.key == word)
                    list.RemoveLast();
                else
                {
                    Node temp = list.pHead;
                    while (temp.pNext.key != word)
                        temp = temp.pNext;
                    list.RemoveAfter(temp);
                }
                MessageBox.Show("Đã xóa từ \"{" + Input + "}\" !");

            }
        }
    }
}
