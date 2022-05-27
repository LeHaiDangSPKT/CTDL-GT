using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Winform
{
    
    public partial class Form1 : Form
    {
        //Khoi tao danh sach
        LIST list = new LIST();
        LIST list_temp = new LIST();
        Handler handler = new Handler();
        public void Init()
        {
            handler.AddLast(ref list, handler.CreateNode(1));
            handler.AddLast(ref list, handler.CreateNode(8));
            handler.AddLast(ref list, handler.CreateNode(5));
            handler.AddLast(ref list, handler.CreateNode(6));
            handler.AddLast(ref list, handler.CreateNode(7));
            handler.AddLast(ref list, handler.CreateNode(2));
            handler.AddLast(ref list, handler.CreateNode(0));
            handler.AddLast(ref list, handler.CreateNode(15));
        }
       
        public Form1()
        {
            InitializeComponent();
            Init();
            LoadView();
        }

        private void LoadView()
        {
            LoadViewPanel1(list);
            LoadViewPanel2(list);
            LoadViewPanel3(list);
            LoadViewPanel4(list);
            LoadViewPanel5(list);
            LoadViewPanel6(list);
            LoadViewPanel7(list);
            LoadViewPanel8(list);
            LoadViewPanel9(list_temp);
        }

        #region Exit

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExitAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btnExitDel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btnExitSort_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btnExitChange_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btnExitDel_Condition_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btnExitAdd_SNT_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btnExitDSLK_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
        #endregion


        private void LoadViewPanel1(LIST list)
        {
            panel1.Controls.Clear();
            if (!handler.IsEmpty(list))
            {
                NODE node = list.pTail;
                int i = handler.CountNode(list);
                int pos = 850 / i;
                i--;
                while (node != null)
                {
                    Label lb = new Label();
                    panel1.Controls.Add(lb);
                    lb.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb.Size = new System.Drawing.Size(403, 47);
                    lb.Text = node.data.ToString();
                    lb.Location = new Point(pos*i, 70);
                    i--;
                    node = node.pPrev;
                }
            }
        }
        private void LoadViewPanel2(LIST list)
        {
            panel2.Controls.Clear();
            if (!handler.IsEmpty(list))
            {
                NODE node = list.pTail;
                int i = handler.CountNode(list);
                int pos = 850 / i;
                i--;
                while (node != null)
                {
                    Label lb = new Label();
                    panel2.Controls.Add(lb);
                    lb.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb.Size = new System.Drawing.Size(403, 47);
                    lb.Text = node.data.ToString();
                    lb.Location = new Point(pos * i, 70);
                    i--;
                    node = node.pPrev;
                }
            }
        }
        private void LoadViewPanel3(LIST list)
        {
            panel3.Controls.Clear();
            if (!handler.IsEmpty(list))
            {
                NODE node = list.pTail;
                int i = handler.CountNode(list);
                int pos = 850 / i;
                i--;
                while (node != null)
                {
                    Label lb = new Label();
                    panel3.Controls.Add(lb);
                    lb.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb.Size = new System.Drawing.Size(403, 47);
                    lb.Text = node.data.ToString();
                    lb.Location = new Point(pos * i, 70);
                    i--;
                    node = node.pPrev;
                }
            }
        }
        private void LoadViewPanel4(LIST list)
        {
            panel4.Controls.Clear();
            if (!handler.IsEmpty(list))
            {
                NODE node = list.pTail;
                int i = handler.CountNode(list);
                int pos = 850 / i;
                i--;
                while (node != null)
                {
                    Label lb = new Label();
                    panel4.Controls.Add(lb);
                    lb.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb.Size = new System.Drawing.Size(403, 47);
                    lb.Text = node.data.ToString();
                    lb.Location = new Point(pos * i, 70);
                    i--;
                    node = node.pPrev;
                }
            }
        }
        private void LoadViewPanel5(LIST list)
        {
            panel5.Controls.Clear();
            if (!handler.IsEmpty(list))
            {
                NODE node = list.pTail;
                int i = handler.CountNode(list);
                int pos = 850 / i;
                i--;
                while (node != null)
                {
                    Label lb = new Label();
                    panel5.Controls.Add(lb);
                    lb.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb.Size = new System.Drawing.Size(403, 47);
                    lb.Text = node.data.ToString();
                    lb.Location = new Point(pos * i, 70);
                    i--;
                    node = node.pPrev;
                }
            }
        }
        private void LoadViewPanel6(LIST list)
        {
            panel6.Controls.Clear();
            if (!handler.IsEmpty(list))
            {
                NODE node = list.pTail;
                int i = handler.CountNode(list);
                int pos = 850 / i;
                i--;
                while (node != null)
                {
                    Label lb = new Label();
                    panel6.Controls.Add(lb);
                    lb.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb.Size = new System.Drawing.Size(403, 47);
                    lb.Text = node.data.ToString();
                    lb.Location = new Point(pos * i, 70);
                    i--;
                    node = node.pPrev;
                }
            }
        }
        private void LoadViewPanel7(LIST list)
        {
            panel7.Controls.Clear();
            if (!handler.IsEmpty(list))
            {
                NODE node = list.pTail;
                int i = handler.CountNode(list);
                int pos = 850 / i;
                i--;
                while (node != null)
                {
                    Label lb = new Label();
                    panel7.Controls.Add(lb);
                    lb.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb.Size = new System.Drawing.Size(403, 47);
                    lb.Text = node.data.ToString();
                    lb.Location = new Point(pos * i, 70);
                    i--;
                    node = node.pPrev;
                }
            }
        }
        private void LoadViewPanel8(LIST list)
        {
            panel8.Controls.Clear();
            if (!handler.IsEmpty(list))
            {
                NODE node = list.pTail;
                int i = handler.CountNode(list);
                int pos = 850 / i;
                i--;
                while (node != null)
                {
                    Label lb = new Label();
                    panel8.Controls.Add(lb);
                    lb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb.Size = new System.Drawing.Size(403, 47);
                    lb.Text = node.data.ToString();
                    lb.Location = new Point(pos * i, 20);
                    i--;
                    node = node.pPrev;
                }
            }
        }
        private void LoadViewPanel9(LIST list_temp)
        {
            panel9.Controls.Clear();
            if (!handler.IsEmpty(list_temp))
            {
                NODE node = list_temp.pTail;
                int i = handler.CountNode(list_temp);
                int pos = 850 / i;
                i--;
                while (node != null)
                {
                    Label lb = new Label();
                    panel9.Controls.Add(lb);
                    lb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point); ;
                    lb.Size = new System.Drawing.Size(403, 47);
                    lb.Text = node.data.ToString();
                    lb.Location = new Point(pos * i, 20);
                    i--;
                    node = node.pPrev;
                }
            }
        }


        //ADD
        private void AddFirst_Click(object sender, EventArgs e)
        {
            handler.AddFirst(ref list, handler.CreateNode(int.Parse(textBoxAdd.Text)));
            LoadView();
        }

        private void btnAddAfter_Click(object sender, EventArgs e)
        {
            handler.AddAfterQ(ref list, handler.CreateNode(int.Parse(textBoxAdd.Text)), handler.GetNode(list, int.Parse(textBoxAdd_Node.Text)));
            LoadView();
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            handler.AddLast(ref list, handler.CreateNode(int.Parse(textBoxAdd.Text)));
            LoadView();
        }


        //DEL
        private void btnDelFirst_Click(object sender, EventArgs e)
        {
            handler.DelFirst(ref list);
            LoadView();
        }

        private void btnDelAfter_Click(object sender, EventArgs e)
        {
            handler.DelAfter(ref list, handler.GetNode(list, int.Parse(textBoxDel.Text)));
            LoadView();
        }

        private void btnDelLast_Click(object sender, EventArgs e)
        {
            handler.DelLast(ref list);
            LoadView();
        }

        //SORT
        private void btnSLSort_Click(object sender, EventArgs e)
        {
            handler.SelectionSort(ref list);
            LoadView();
        }

        private void btnQSort_Click(object sender, EventArgs e)
        {
            handler.QuickSort(ref list);
            LoadView();
        }


        //CHANGE VALUE
        private void btnChangeFirst_Click(object sender, EventArgs e)
        {
            bool flag = handler.ChangeFirst(ref list, int.Parse(textBoxChange_old.Text), int.Parse(textBoxChange_new.Text));
            LoadView();
        }

        private void btnChangeLast_Click(object sender, EventArgs e)
        {
            handler.ChangeLast(ref list, int.Parse(textBoxChange_old.Text), int.Parse(textBoxChange_new.Text));
            LoadView();
        }

        private void btnChangeAll_Click(object sender, EventArgs e)
        {
            handler.ChangeAll(ref list, int.Parse(textBoxChange_old.Text), int.Parse(textBoxChange_new.Text));
            LoadView();
        }


        //DEL ALL
        private void btnDelAll_Click(object sender, EventArgs e)
        {
            handler.DelAll(ref list, int.Parse(textBoxDel_Condition.Text));
            LoadView();
        }


        //ADD AFTER SNT
        private void btnAddAfterSNT_Click(object sender, EventArgs e)
        {
            handler.AddAfterSNT(ref list, int.Parse(textBoxAddAfterSNT.Text));
            LoadView();
        }

        private void btnAddDSLK_Click(object sender, EventArgs e)
        {
            handler.AddFirst(ref list_temp, handler.CreateNode(int.Parse(textBoxAddDSLK.Text)));
            LoadView();
        }

        private void btnCreDSLK_Click(object sender, EventArgs e)
        {
            handler.AddLast(ref list_temp, handler.CreateNode(-1));
            handler.AddLast(ref list_temp, handler.CreateNode(-7));
            handler.AddLast(ref list_temp, handler.CreateNode(-5));
            handler.AddLast(ref list_temp, handler.CreateNode(-16));  
            LoadView();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            handler.MergeLists(ref list, list_temp);
            LoadView();
            panel9.Controls.Clear();
        }
    }
}
