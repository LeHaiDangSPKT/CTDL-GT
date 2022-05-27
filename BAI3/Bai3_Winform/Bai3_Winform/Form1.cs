using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace Bai3_Winform
{
    public partial class Form1 : Form
    {
        Handler handler = new Handler();
        HashTable hashTable = new HashTable();

        public Form1()
        {
            InitializeComponent();
            hashTable.AddDictionary();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void btnThemNghia_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void btnXoaTu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void btnXoaNghia_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void btnInTatCa_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            panelTraCuu.Controls.Clear();
            string text = textBoxTraCuu.Text;
            Word word = handler.Input1(ref hashTable, text);
            if (word != null)
            {
                Label lb1 = new Label();
                panelTraCuu.Controls.Add(lb1);
                lb1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                lb1.Size = new System.Drawing.Size(400, 25);
                lb1.Text = "Nghĩa thông thường: ";
                lb1.Location = new Point(10, 10);

                int i = 1, h = 5;
                foreach (var meaning in word.meanings)
                {
                    if (meaning.Proper == 0)
                    {
                        Label lb2 = new Label();
                        panelTraCuu.Controls.Add(lb2);
                        lb2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                        lb2.Size = new System.Drawing.Size(400, 20);
                        lb2.Text = meaning.WordType + " - " + meaning.meaning;
                        lb2.Location = new Point(50, 30 * i++ + h);
                        h = 0;
                    }
                }


                Label lb3 = new Label();
                panelTraCuu.Controls.Add(lb3);
                lb3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                lb3.Size = new System.Drawing.Size(400, 25);
                lb3.Text = "Tên riêng: ";
                lb3.Location = new Point(10, 30 * i++);

                foreach (var meaning in word.meanings)
                {
                    if (meaning.Proper == 1)
                    {
                        Label lb4 = new Label();
                        panelTraCuu.Controls.Add(lb4);
                        lb4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                        lb4.Size = new System.Drawing.Size(400, 20);
                        lb4.Text = meaning.WordType + " - " + meaning.meaning;
                        lb4.Location = new Point(50, 30 * i++);
                    }
                }
            }
        }


        //TabLichSu
        public int count = 0;
        private int length(List<Word> l)
        {
            return l.Count();
        }

        private void LoadViewLichSu(int count)
        {
            if (length(hashTable.history) <= 1)
            {
                btnLichSu_Trai.Visible = false;
                btnLichSu_Phai.Visible = false;
            }
            else
            {
                btnLichSu_Trai.Visible = true;
                btnLichSu_Phai.Visible = true;
                if (count == 0)
                    btnLichSu_Trai.Visible = false;
                if (count != 0)
                    btnLichSu_Trai.Visible = true;
                if (count == length(hashTable.history) - 1)
                    btnLichSu_Phai.Visible = false;
                if (count != length(hashTable.history) - 1)
                    btnLichSu_Phai.Visible = true;
            }
            panelLichSu.Controls.Clear();
            if (hashTable.history[count].meanings.Contains(null))
            {
                Label lb = new Label();
                panelLichSu.Controls.Add(lb);
                lb.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                lb.Size = new System.Drawing.Size(400, 35);
                lb.Text = "Từ: " + hashTable.history[count].word + " không tìm thấy!";
                lb.Location = new Point(10, 10);
            }
            else
            {
                Label lb1 = new Label();
                panelLichSu.Controls.Add(lb1);
                lb1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                lb1.Size = new System.Drawing.Size(400, 35);
                lb1.Text = "Nghĩa thông thường: ";
                lb1.Location = new Point(10, 10);

                int i = 1;
                foreach (var meaning in hashTable.history[count].meanings)
                {
                    if (meaning.Proper == 0)
                    {
                        Label lb2 = new Label();
                        panelLichSu.Controls.Add(lb2);
                        lb2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                        lb2.Size = new System.Drawing.Size(400, 47);
                        lb2.Text = meaning.WordType + " - " + meaning.meaning;
                        lb2.Location = new Point(50, 38 * i++);
                    }
                }


                Label lb3 = new Label();
                panelLichSu.Controls.Add(lb3);
                lb3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                lb3.Size = new System.Drawing.Size(400, 35);
                lb3.Text = "Tên riêng (" + hashTable.history[count].word.ToString() + "): ";
                lb3.Location = new Point(10, 40 * i++);

                foreach (var meaning in hashTable.history[count].meanings)
                {
                    if (meaning.Proper == 1)
                    {
                        Label lb4 = new Label();
                        panelLichSu.Controls.Add(lb3);
                        lb4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                        lb4.Size = new System.Drawing.Size(400, 35);
                        lb4.Text = meaning.WordType + " - " + meaning.meaning;
                        lb4.Location = new Point(10, 38 * i++);
                    }
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadViewLichSu(count);
            btnXem.Visible = false;
        }

        private void btnLichSu_Phai_Click(object sender, EventArgs e)
        {
            count++;
            LoadViewLichSu(count);
        }

        private void btnLichSu_Trai_Click(object sender, EventArgs e)
        {
            count--;
            LoadViewLichSu(count);
        }
        //End TabLichSu

        private void _btnThemTu_Click(object sender, EventArgs e)
        {
            handler.AddNewWord(ref hashTable, textBoxThem.Text, comboBoxNghiabt.Text, comboBoxTenRieng.Text, textBoxNghiabt.Text, textBoxTenRieng.Text);
            MessageBox.Show("Thêm thành công !");
        }

        private void _btnThemNghia_Click(object sender, EventArgs e)
        {
            handler.AddNewMeaning(ref hashTable, textBoxThemNghia.Text, comboBoxChonNghia.Text, comboBoxTuLoai.Text, textBoxNghia_Them.Text);
            MessageBox.Show("Thêm thành công !");
        }

        private void _btnXoaTu_Click(object sender, EventArgs e)
        {
            handler.RemoveWord(ref hashTable, textBoxXoaTu.Text);
            MessageBox.Show("Xóa thành công !");

        }


        Word word;
        string Input;
        int index;
        private void _btnXoaNghia_Click(object sender, EventArgs e)
        {
            int posOfMeaning = Convert.ToInt32(textBoxVitriXoa.Text);
            try
            {
                if (posOfMeaning < 1 || posOfMeaning > index)
                    throw new ArgumentOutOfRangeException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Yêu cầu nhập chỉ số!");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Yêu cầu nhập từ 1-9");
            }
            word.meanings.Remove(word.meanings[posOfMeaning - 1]);
            MessageBox.Show("Đã xóa nghĩa của từ \"{" + Input + "}\"!", Input);
        }

        private void btnXemList_Click(object sender, EventArgs e)
        {
            panelNghiaCuaTu.Controls.Clear();
            Input = textBoxXoaNghia.Text;
            Input = Regex.Replace(Input, @"\s+", " ");
            Input = Input.Trim();
            Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input.ToLower());
            word = hashTable.SearchItem(Input);
            if (word == null)
                MessageBox.Show("Không tìm thấy từ \"{" + Input + "}\" ");
            else
            {
                index = 1;
                foreach (var meaning in word.meanings)
                {
                    Label lb2 = new Label();
                    panelNghiaCuaTu.Controls.Add(lb2);
                    lb2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb2.Size = new System.Drawing.Size(400, 47);
                    lb2.Text = index.ToString() + ".  " + meaning.Proper + " _ " + meaning.WordType + ": " + meaning.meaning;
                    lb2.Location = new Point(50, 38 * index);
                    index++;
                }
            }
        }

        int i = 0;
        private void LoadViewTu(int i)
        {
            panelDanhSach.Controls.Clear();
            KiemTraTu(i);
            Label lb1 = new Label();
            panelDanhSach.Controls.Add(lb1);
            lb1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
            lb1.Size = new System.Drawing.Size(400, 35);
            lb1.Text = "Chữ cái: " + Char.ConvertFromUtf32(i + 97).ToUpper();
            lb1.Location = new Point(200, 10);

            Node node;
            int x = 0, h = 0, check = 1;
            for (var j = 0; j < 50; j++)
            {
                node = hashTable.hashtable[i, j].pHead;
                while(node != null)
                {
                    if (check % 8 == 0)
                    {
                        x += 150;
                        h = 0;
                        check = 1;
                    }
                    if (node.key.word.Contains(Char.ConvertFromUtf32(i + 97).ToUpper()))
                        check++;
                    Label lb = new Label();
                    panelDanhSach.Controls.Add(lb);
                    lb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb.Size = new System.Drawing.Size(100, 20);
                    lb.Text = node.key.word;
                    lb.Location = new Point(30 + x, 30*++h + 20);
                    node = node.pNext;
                }
            }
        }
        private void KiemTraTu(int i)
        {
            if (i == 0)
                btnDS_Trai.Visible = false;
            if (i != 0)
                btnDS_Trai.Visible = true;
            if (i == 25)
                btnDS_Phai.Visible = false;
            if (i != 25)
                btnDS_Phai.Visible = true;
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            LoadViewTu(i);
            btnXemDanhSach.Visible = false;
        }

        private void btnDS_Trai_Click(object sender, EventArgs e)
        {
            i--;
            LoadViewTu(i);
        }

        private void btnDS_Phai_Click(object sender, EventArgs e)
        {
            i++;
            LoadViewTu(i);
        }
    }
}
