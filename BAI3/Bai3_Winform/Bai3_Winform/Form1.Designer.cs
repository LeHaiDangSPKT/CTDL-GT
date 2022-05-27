
namespace Bai3_Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TrangChu = new System.Windows.Forms.TabPage();
            this.btnInTatCa = new System.Windows.Forms.Button();
            this.btnXoaNghia = new System.Windows.Forms.Button();
            this.btnXoaTu = new System.Windows.Forms.Button();
            this.btnThemNghia = new System.Windows.Forms.Button();
            this.btnThemTu = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.TraCuu = new System.Windows.Forms.TabPage();
            this.panelTraCuu = new System.Windows.Forms.Panel();
            this.btnTra = new System.Windows.Forms.Button();
            this.textBoxTraCuu = new System.Windows.Forms.TextBox();
            this.LichSu = new System.Windows.Forms.TabPage();
            this.btnLichSu_Trai = new System.Windows.Forms.Button();
            this.btnLichSu_Phai = new System.Windows.Forms.Button();
            this.panelLichSu = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.ThemTu = new System.Windows.Forms.TabPage();
            this._btnThemTu = new System.Windows.Forms.Button();
            this.textBoxTenRieng = new System.Windows.Forms.TextBox();
            this.textBoxNghiabt = new System.Windows.Forms.TextBox();
            this.comboBoxTenRieng = new System.Windows.Forms.ComboBox();
            this.comboBoxNghiabt = new System.Windows.Forms.ComboBox();
            this.textBoxThem = new System.Windows.Forms.TextBox();
            this.ThemNghia = new System.Windows.Forms.TabPage();
            this.comboBoxChonNghia = new System.Windows.Forms.ComboBox();
            this.comboBoxTuLoai = new System.Windows.Forms.ComboBox();
            this._btnThemNghia = new System.Windows.Forms.Button();
            this.textBoxNghia_Them = new System.Windows.Forms.TextBox();
            this.textBoxThemNghia = new System.Windows.Forms.TextBox();
            this.XoaTu = new System.Windows.Forms.TabPage();
            this._btnXoaTu = new System.Windows.Forms.Button();
            this.textBoxXoaTu = new System.Windows.Forms.TextBox();
            this.XoaNghia = new System.Windows.Forms.TabPage();
            this.btnXemList = new System.Windows.Forms.Button();
            this._btnXoaNghia = new System.Windows.Forms.Button();
            this.textBoxVitriXoa = new System.Windows.Forms.TextBox();
            this.panelNghiaCuaTu = new System.Windows.Forms.Panel();
            this.textBoxXoaNghia = new System.Windows.Forms.TextBox();
            this.InTatCa = new System.Windows.Forms.TabPage();
            this.panelDanhSach = new System.Windows.Forms.Panel();
            this.btnXemDanhSach = new System.Windows.Forms.Button();
            this.btnDS_Trai = new System.Windows.Forms.Button();
            this.btnDS_Phai = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TrangChu.SuspendLayout();
            this.TraCuu.SuspendLayout();
            this.LichSu.SuspendLayout();
            this.panelLichSu.SuspendLayout();
            this.ThemTu.SuspendLayout();
            this.ThemNghia.SuspendLayout();
            this.XoaTu.SuspendLayout();
            this.XoaNghia.SuspendLayout();
            this.InTatCa.SuspendLayout();
            this.panelDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TrangChu);
            this.tabControl1.Controls.Add(this.TraCuu);
            this.tabControl1.Controls.Add(this.LichSu);
            this.tabControl1.Controls.Add(this.ThemTu);
            this.tabControl1.Controls.Add(this.ThemNghia);
            this.tabControl1.Controls.Add(this.XoaTu);
            this.tabControl1.Controls.Add(this.XoaNghia);
            this.tabControl1.Controls.Add(this.InTatCa);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // TrangChu
            // 
            this.TrangChu.BackgroundImage = global::Bai3_Winform.Properties.Resources.Chương_trình_Hôm_nay;
            this.TrangChu.Controls.Add(this.btnInTatCa);
            this.TrangChu.Controls.Add(this.btnXoaNghia);
            this.TrangChu.Controls.Add(this.btnXoaTu);
            this.TrangChu.Controls.Add(this.btnThemNghia);
            this.TrangChu.Controls.Add(this.btnThemTu);
            this.TrangChu.Controls.Add(this.btnLichSu);
            this.TrangChu.Controls.Add(this.btnTraCuu);
            this.TrangChu.Location = new System.Drawing.Point(4, 29);
            this.TrangChu.Name = "TrangChu";
            this.TrangChu.Padding = new System.Windows.Forms.Padding(3);
            this.TrangChu.Size = new System.Drawing.Size(991, 452);
            this.TrangChu.TabIndex = 0;
            this.TrangChu.Text = "Trang Chủ";
            this.TrangChu.UseVisualStyleBackColor = true;
            // 
            // btnInTatCa
            // 
            this.btnInTatCa.Font = new System.Drawing.Font("Rockstone", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInTatCa.ForeColor = System.Drawing.Color.Green;
            this.btnInTatCa.Location = new System.Drawing.Point(590, 296);
            this.btnInTatCa.Name = "btnInTatCa";
            this.btnInTatCa.Size = new System.Drawing.Size(142, 73);
            this.btnInTatCa.TabIndex = 6;
            this.btnInTatCa.Text = "IN TẤT CẢ";
            this.btnInTatCa.UseVisualStyleBackColor = true;
            this.btnInTatCa.Click += new System.EventHandler(this.btnInTatCa_Click);
            // 
            // btnXoaNghia
            // 
            this.btnXoaNghia.Font = new System.Drawing.Font("Rockstone", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaNghia.ForeColor = System.Drawing.Color.Green;
            this.btnXoaNghia.Location = new System.Drawing.Point(421, 296);
            this.btnXoaNghia.Name = "btnXoaNghia";
            this.btnXoaNghia.Size = new System.Drawing.Size(142, 73);
            this.btnXoaNghia.TabIndex = 5;
            this.btnXoaNghia.Text = "XÓA NGHĨA";
            this.btnXoaNghia.UseVisualStyleBackColor = true;
            this.btnXoaNghia.Click += new System.EventHandler(this.btnXoaNghia_Click);
            // 
            // btnXoaTu
            // 
            this.btnXoaTu.Font = new System.Drawing.Font("Rockstone", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaTu.ForeColor = System.Drawing.Color.Green;
            this.btnXoaTu.Location = new System.Drawing.Point(246, 296);
            this.btnXoaTu.Name = "btnXoaTu";
            this.btnXoaTu.Size = new System.Drawing.Size(142, 73);
            this.btnXoaTu.TabIndex = 4;
            this.btnXoaTu.Text = "XÓA TỪ";
            this.btnXoaTu.UseVisualStyleBackColor = true;
            this.btnXoaTu.Click += new System.EventHandler(this.btnXoaTu_Click);
            // 
            // btnThemNghia
            // 
            this.btnThemNghia.Font = new System.Drawing.Font("Rockstone", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemNghia.ForeColor = System.Drawing.Color.Green;
            this.btnThemNghia.Location = new System.Drawing.Point(670, 195);
            this.btnThemNghia.Name = "btnThemNghia";
            this.btnThemNghia.Size = new System.Drawing.Size(142, 73);
            this.btnThemNghia.TabIndex = 3;
            this.btnThemNghia.Text = "THÊM NGHĨA";
            this.btnThemNghia.UseVisualStyleBackColor = true;
            this.btnThemNghia.Click += new System.EventHandler(this.btnThemNghia_Click);
            // 
            // btnThemTu
            // 
            this.btnThemTu.Font = new System.Drawing.Font("Rockstone", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemTu.ForeColor = System.Drawing.Color.Green;
            this.btnThemTu.Location = new System.Drawing.Point(505, 195);
            this.btnThemTu.Name = "btnThemTu";
            this.btnThemTu.Size = new System.Drawing.Size(142, 73);
            this.btnThemTu.TabIndex = 2;
            this.btnThemTu.Text = "THÊM TỪ";
            this.btnThemTu.UseVisualStyleBackColor = true;
            this.btnThemTu.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.Font = new System.Drawing.Font("Rockstone", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLichSu.ForeColor = System.Drawing.Color.Green;
            this.btnLichSu.Location = new System.Drawing.Point(342, 195);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(142, 73);
            this.btnLichSu.TabIndex = 1;
            this.btnLichSu.Text = "LỊCH SỬ";
            this.btnLichSu.UseVisualStyleBackColor = true;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Rockstone", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTraCuu.ForeColor = System.Drawing.Color.Green;
            this.btnTraCuu.Location = new System.Drawing.Point(170, 195);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(142, 73);
            this.btnTraCuu.TabIndex = 0;
            this.btnTraCuu.Text = "TRA CỨU";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // TraCuu
            // 
            this.TraCuu.BackgroundImage = global::Bai3_Winform.Properties.Resources.TraCuu;
            this.TraCuu.Controls.Add(this.panelTraCuu);
            this.TraCuu.Controls.Add(this.btnTra);
            this.TraCuu.Controls.Add(this.textBoxTraCuu);
            this.TraCuu.Location = new System.Drawing.Point(4, 29);
            this.TraCuu.Name = "TraCuu";
            this.TraCuu.Padding = new System.Windows.Forms.Padding(3);
            this.TraCuu.Size = new System.Drawing.Size(991, 452);
            this.TraCuu.TabIndex = 1;
            this.TraCuu.Text = "Tra Cứu";
            this.TraCuu.UseVisualStyleBackColor = true;
            // 
            // panelTraCuu
            // 
            this.panelTraCuu.Location = new System.Drawing.Point(228, 269);
            this.panelTraCuu.Name = "panelTraCuu";
            this.panelTraCuu.Size = new System.Drawing.Size(576, 155);
            this.panelTraCuu.TabIndex = 2;
            // 
            // btnTra
            // 
            this.btnTra.Font = new System.Drawing.Font("Rockstone", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTra.ForeColor = System.Drawing.Color.Green;
            this.btnTra.Location = new System.Drawing.Point(663, 143);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(142, 58);
            this.btnTra.TabIndex = 1;
            this.btnTra.Text = "Tra Cứu";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // textBoxTraCuu
            // 
            this.textBoxTraCuu.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTraCuu.Location = new System.Drawing.Point(226, 144);
            this.textBoxTraCuu.Name = "textBoxTraCuu";
            this.textBoxTraCuu.Size = new System.Drawing.Size(426, 57);
            this.textBoxTraCuu.TabIndex = 0;
            // 
            // LichSu
            // 
            this.LichSu.BackgroundImage = global::Bai3_Winform.Properties.Resources.LichSu;
            this.LichSu.Controls.Add(this.btnLichSu_Trai);
            this.LichSu.Controls.Add(this.btnLichSu_Phai);
            this.LichSu.Controls.Add(this.panelLichSu);
            this.LichSu.Location = new System.Drawing.Point(4, 29);
            this.LichSu.Name = "LichSu";
            this.LichSu.Padding = new System.Windows.Forms.Padding(3);
            this.LichSu.Size = new System.Drawing.Size(991, 452);
            this.LichSu.TabIndex = 2;
            this.LichSu.Text = "Lịch Sử";
            this.LichSu.UseVisualStyleBackColor = true;
            // 
            // btnLichSu_Trai
            // 
            this.btnLichSu_Trai.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLichSu_Trai.Location = new System.Drawing.Point(157, 247);
            this.btnLichSu_Trai.Name = "btnLichSu_Trai";
            this.btnLichSu_Trai.Size = new System.Drawing.Size(55, 48);
            this.btnLichSu_Trai.TabIndex = 2;
            this.btnLichSu_Trai.Text = "<";
            this.btnLichSu_Trai.UseVisualStyleBackColor = true;
            this.btnLichSu_Trai.Click += new System.EventHandler(this.btnLichSu_Trai_Click);
            // 
            // btnLichSu_Phai
            // 
            this.btnLichSu_Phai.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLichSu_Phai.Location = new System.Drawing.Point(821, 247);
            this.btnLichSu_Phai.Name = "btnLichSu_Phai";
            this.btnLichSu_Phai.Size = new System.Drawing.Size(55, 48);
            this.btnLichSu_Phai.TabIndex = 1;
            this.btnLichSu_Phai.Text = ">";
            this.btnLichSu_Phai.UseVisualStyleBackColor = true;
            this.btnLichSu_Phai.Click += new System.EventHandler(this.btnLichSu_Phai_Click);
            // 
            // panelLichSu
            // 
            this.panelLichSu.Controls.Add(this.btnXem);
            this.panelLichSu.Location = new System.Drawing.Point(228, 132);
            this.panelLichSu.Name = "panelLichSu";
            this.panelLichSu.Size = new System.Drawing.Size(578, 277);
            this.panelLichSu.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXem.Location = new System.Drawing.Point(143, 96);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(290, 80);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "XEM";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // ThemTu
            // 
            this.ThemTu.BackgroundImage = global::Bai3_Winform.Properties.Resources.ThemTu1;
            this.ThemTu.Controls.Add(this._btnThemTu);
            this.ThemTu.Controls.Add(this.textBoxTenRieng);
            this.ThemTu.Controls.Add(this.textBoxNghiabt);
            this.ThemTu.Controls.Add(this.comboBoxTenRieng);
            this.ThemTu.Controls.Add(this.comboBoxNghiabt);
            this.ThemTu.Controls.Add(this.textBoxThem);
            this.ThemTu.Location = new System.Drawing.Point(4, 29);
            this.ThemTu.Name = "ThemTu";
            this.ThemTu.Padding = new System.Windows.Forms.Padding(3);
            this.ThemTu.Size = new System.Drawing.Size(991, 452);
            this.ThemTu.TabIndex = 3;
            this.ThemTu.Text = "Thêm Từ";
            this.ThemTu.UseVisualStyleBackColor = true;
            // 
            // _btnThemTu
            // 
            this._btnThemTu.BackColor = System.Drawing.Color.SeaGreen;
            this._btnThemTu.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnThemTu.Location = new System.Drawing.Point(415, 394);
            this._btnThemTu.Name = "_btnThemTu";
            this._btnThemTu.Size = new System.Drawing.Size(168, 45);
            this._btnThemTu.TabIndex = 5;
            this._btnThemTu.Text = "THÊM";
            this._btnThemTu.UseVisualStyleBackColor = false;
            this._btnThemTu.Click += new System.EventHandler(this._btnThemTu_Click);
            // 
            // textBoxTenRieng
            // 
            this.textBoxTenRieng.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTenRieng.Location = new System.Drawing.Point(635, 332);
            this.textBoxTenRieng.Name = "textBoxTenRieng";
            this.textBoxTenRieng.Size = new System.Drawing.Size(237, 41);
            this.textBoxTenRieng.TabIndex = 4;
            this.textBoxTenRieng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNghiabt
            // 
            this.textBoxNghiabt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNghiabt.Location = new System.Drawing.Point(635, 267);
            this.textBoxNghiabt.Name = "textBoxNghiabt";
            this.textBoxNghiabt.Size = new System.Drawing.Size(237, 41);
            this.textBoxNghiabt.TabIndex = 3;
            this.textBoxNghiabt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxTenRieng
            // 
            this.comboBoxTenRieng.AllowDrop = true;
            this.comboBoxTenRieng.BackColor = System.Drawing.Color.White;
            this.comboBoxTenRieng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenRieng.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTenRieng.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTenRieng.FormattingEnabled = true;
            this.comboBoxTenRieng.Items.AddRange(new object[] {
            "Danh từ",
            "Động từ",
            "Tính từ",
            "Trạng từ",
            "Giới từ",
            "Từ hạn định",
            "Đại từ",
            "Liên từ",
            "Thán từ"});
            this.comboBoxTenRieng.Location = new System.Drawing.Point(381, 334);
            this.comboBoxTenRieng.MaxDropDownItems = 4;
            this.comboBoxTenRieng.Name = "comboBoxTenRieng";
            this.comboBoxTenRieng.Size = new System.Drawing.Size(234, 39);
            this.comboBoxTenRieng.TabIndex = 2;
            // 
            // comboBoxNghiabt
            // 
            this.comboBoxNghiabt.AllowDrop = true;
            this.comboBoxNghiabt.BackColor = System.Drawing.Color.White;
            this.comboBoxNghiabt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNghiabt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxNghiabt.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNghiabt.FormattingEnabled = true;
            this.comboBoxNghiabt.Items.AddRange(new object[] {
            "Danh từ",
            "Động từ",
            "Tính từ",
            "Trạng từ",
            "Giới từ",
            "Từ hạn định",
            "Đại từ",
            "Liên từ",
            "Thán từ"});
            this.comboBoxNghiabt.Location = new System.Drawing.Point(381, 268);
            this.comboBoxNghiabt.MaxDropDownItems = 4;
            this.comboBoxNghiabt.Name = "comboBoxNghiabt";
            this.comboBoxNghiabt.Size = new System.Drawing.Size(234, 39);
            this.comboBoxNghiabt.TabIndex = 1;
            // 
            // textBoxThem
            // 
            this.textBoxThem.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxThem.Location = new System.Drawing.Point(169, 157);
            this.textBoxThem.Name = "textBoxThem";
            this.textBoxThem.Size = new System.Drawing.Size(705, 57);
            this.textBoxThem.TabIndex = 0;
            this.textBoxThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThemNghia
            // 
            this.ThemNghia.BackgroundImage = global::Bai3_Winform.Properties.Resources.ThemNghia1;
            this.ThemNghia.Controls.Add(this.comboBoxChonNghia);
            this.ThemNghia.Controls.Add(this.comboBoxTuLoai);
            this.ThemNghia.Controls.Add(this._btnThemNghia);
            this.ThemNghia.Controls.Add(this.textBoxNghia_Them);
            this.ThemNghia.Controls.Add(this.textBoxThemNghia);
            this.ThemNghia.Location = new System.Drawing.Point(4, 29);
            this.ThemNghia.Name = "ThemNghia";
            this.ThemNghia.Padding = new System.Windows.Forms.Padding(3);
            this.ThemNghia.Size = new System.Drawing.Size(991, 452);
            this.ThemNghia.TabIndex = 4;
            this.ThemNghia.Text = "Thêm Nghĩa";
            this.ThemNghia.UseVisualStyleBackColor = true;
            // 
            // comboBoxChonNghia
            // 
            this.comboBoxChonNghia.AllowDrop = true;
            this.comboBoxChonNghia.BackColor = System.Drawing.Color.White;
            this.comboBoxChonNghia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChonNghia.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChonNghia.ForeColor = System.Drawing.Color.Black;
            this.comboBoxChonNghia.FormattingEnabled = true;
            this.comboBoxChonNghia.Items.AddRange(new object[] {
            "Nghĩa bình thường",
            "Tên riêng"});
            this.comboBoxChonNghia.Location = new System.Drawing.Point(102, 309);
            this.comboBoxChonNghia.MaxDropDownItems = 4;
            this.comboBoxChonNghia.Name = "comboBoxChonNghia";
            this.comboBoxChonNghia.Size = new System.Drawing.Size(270, 39);
            this.comboBoxChonNghia.TabIndex = 8;
            // 
            // comboBoxTuLoai
            // 
            this.comboBoxTuLoai.AllowDrop = true;
            this.comboBoxTuLoai.BackColor = System.Drawing.Color.White;
            this.comboBoxTuLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTuLoai.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTuLoai.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTuLoai.FormattingEnabled = true;
            this.comboBoxTuLoai.Items.AddRange(new object[] {
            "Danh từ",
            "Động từ",
            "Tính từ",
            "Trạng từ",
            "Giới từ",
            "Từ hạn định",
            "Đại từ",
            "Liên từ",
            "Thán từ"});
            this.comboBoxTuLoai.Location = new System.Drawing.Point(380, 309);
            this.comboBoxTuLoai.MaxDropDownItems = 4;
            this.comboBoxTuLoai.Name = "comboBoxTuLoai";
            this.comboBoxTuLoai.Size = new System.Drawing.Size(234, 39);
            this.comboBoxTuLoai.TabIndex = 7;
            // 
            // _btnThemNghia
            // 
            this._btnThemNghia.BackColor = System.Drawing.Color.SeaGreen;
            this._btnThemNghia.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnThemNghia.Location = new System.Drawing.Point(416, 382);
            this._btnThemNghia.Name = "_btnThemNghia";
            this._btnThemNghia.Size = new System.Drawing.Size(168, 45);
            this._btnThemNghia.TabIndex = 6;
            this._btnThemNghia.Text = "THÊM";
            this._btnThemNghia.UseVisualStyleBackColor = false;
            this._btnThemNghia.Click += new System.EventHandler(this._btnThemNghia_Click);
            // 
            // textBoxNghia_Them
            // 
            this.textBoxNghia_Them.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNghia_Them.Location = new System.Drawing.Point(633, 307);
            this.textBoxNghia_Them.Name = "textBoxNghia_Them";
            this.textBoxNghia_Them.Size = new System.Drawing.Size(280, 43);
            this.textBoxNghia_Them.TabIndex = 1;
            // 
            // textBoxThemNghia
            // 
            this.textBoxThemNghia.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxThemNghia.Location = new System.Drawing.Point(169, 156);
            this.textBoxThemNghia.Name = "textBoxThemNghia";
            this.textBoxThemNghia.Size = new System.Drawing.Size(703, 57);
            this.textBoxThemNghia.TabIndex = 0;
            // 
            // XoaTu
            // 
            this.XoaTu.BackgroundImage = global::Bai3_Winform.Properties.Resources.XoaTu;
            this.XoaTu.Controls.Add(this._btnXoaTu);
            this.XoaTu.Controls.Add(this.textBoxXoaTu);
            this.XoaTu.Location = new System.Drawing.Point(4, 29);
            this.XoaTu.Name = "XoaTu";
            this.XoaTu.Padding = new System.Windows.Forms.Padding(3);
            this.XoaTu.Size = new System.Drawing.Size(991, 452);
            this.XoaTu.TabIndex = 5;
            this.XoaTu.Text = "Xóa Từ";
            this.XoaTu.UseVisualStyleBackColor = true;
            // 
            // _btnXoaTu
            // 
            this._btnXoaTu.BackColor = System.Drawing.Color.SeaGreen;
            this._btnXoaTu.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnXoaTu.Location = new System.Drawing.Point(405, 297);
            this._btnXoaTu.Name = "_btnXoaTu";
            this._btnXoaTu.Size = new System.Drawing.Size(198, 73);
            this._btnXoaTu.TabIndex = 7;
            this._btnXoaTu.Text = "XÓA";
            this._btnXoaTu.UseVisualStyleBackColor = false;
            this._btnXoaTu.Click += new System.EventHandler(this._btnXoaTu_Click);
            // 
            // textBoxXoaTu
            // 
            this.textBoxXoaTu.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxXoaTu.Location = new System.Drawing.Point(163, 206);
            this.textBoxXoaTu.Name = "textBoxXoaTu";
            this.textBoxXoaTu.Size = new System.Drawing.Size(703, 65);
            this.textBoxXoaTu.TabIndex = 0;
            this.textBoxXoaTu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // XoaNghia
            // 
            this.XoaNghia.BackgroundImage = global::Bai3_Winform.Properties.Resources.XoaNghia1;
            this.XoaNghia.Controls.Add(this.btnXemList);
            this.XoaNghia.Controls.Add(this._btnXoaNghia);
            this.XoaNghia.Controls.Add(this.textBoxVitriXoa);
            this.XoaNghia.Controls.Add(this.panelNghiaCuaTu);
            this.XoaNghia.Controls.Add(this.textBoxXoaNghia);
            this.XoaNghia.Location = new System.Drawing.Point(4, 29);
            this.XoaNghia.Name = "XoaNghia";
            this.XoaNghia.Padding = new System.Windows.Forms.Padding(3);
            this.XoaNghia.Size = new System.Drawing.Size(991, 452);
            this.XoaNghia.TabIndex = 6;
            this.XoaNghia.Text = "Xóa Nghĩa";
            this.XoaNghia.UseVisualStyleBackColor = true;
            // 
            // btnXemList
            // 
            this.btnXemList.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXemList.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXemList.Location = new System.Drawing.Point(753, 85);
            this.btnXemList.Name = "btnXemList";
            this.btnXemList.Size = new System.Drawing.Size(112, 66);
            this.btnXemList.TabIndex = 8;
            this.btnXemList.Text = "XEM";
            this.btnXemList.UseVisualStyleBackColor = false;
            this.btnXemList.Click += new System.EventHandler(this.btnXemList_Click);
            // 
            // _btnXoaNghia
            // 
            this._btnXoaNghia.BackColor = System.Drawing.Color.SeaGreen;
            this._btnXoaNghia.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnXoaNghia.Location = new System.Drawing.Point(635, 403);
            this._btnXoaNghia.Name = "_btnXoaNghia";
            this._btnXoaNghia.Size = new System.Drawing.Size(108, 46);
            this._btnXoaNghia.TabIndex = 7;
            this._btnXoaNghia.Text = "XÓA";
            this._btnXoaNghia.UseVisualStyleBackColor = false;
            this._btnXoaNghia.Click += new System.EventHandler(this._btnXoaNghia_Click);
            // 
            // textBoxVitriXoa
            // 
            this.textBoxVitriXoa.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVitriXoa.Location = new System.Drawing.Point(463, 405);
            this.textBoxVitriXoa.Name = "textBoxVitriXoa";
            this.textBoxVitriXoa.Size = new System.Drawing.Size(157, 43);
            this.textBoxVitriXoa.TabIndex = 4;
            this.textBoxVitriXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelNghiaCuaTu
            // 
            this.panelNghiaCuaTu.Location = new System.Drawing.Point(157, 187);
            this.panelNghiaCuaTu.Name = "panelNghiaCuaTu";
            this.panelNghiaCuaTu.Size = new System.Drawing.Size(703, 210);
            this.panelNghiaCuaTu.TabIndex = 3;
            // 
            // textBoxXoaNghia
            // 
            this.textBoxXoaNghia.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxXoaNghia.Location = new System.Drawing.Point(157, 85);
            this.textBoxXoaNghia.Name = "textBoxXoaNghia";
            this.textBoxXoaNghia.Size = new System.Drawing.Size(596, 65);
            this.textBoxXoaNghia.TabIndex = 1;
            this.textBoxXoaNghia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InTatCa
            // 
            this.InTatCa.BackgroundImage = global::Bai3_Winform.Properties.Resources.DanhSach;
            this.InTatCa.Controls.Add(this.panelDanhSach);
            this.InTatCa.Controls.Add(this.btnDS_Trai);
            this.InTatCa.Controls.Add(this.btnDS_Phai);
            this.InTatCa.Location = new System.Drawing.Point(4, 29);
            this.InTatCa.Name = "InTatCa";
            this.InTatCa.Padding = new System.Windows.Forms.Padding(3);
            this.InTatCa.Size = new System.Drawing.Size(991, 452);
            this.InTatCa.TabIndex = 7;
            this.InTatCa.Text = "In Tất Cả";
            this.InTatCa.UseVisualStyleBackColor = true;
            // 
            // panelDanhSach
            // 
            this.panelDanhSach.Controls.Add(this.btnXemDanhSach);
            this.panelDanhSach.Location = new System.Drawing.Point(200, 131);
            this.panelDanhSach.Name = "panelDanhSach";
            this.panelDanhSach.Size = new System.Drawing.Size(577, 281);
            this.panelDanhSach.TabIndex = 2;
            // 
            // btnXemDanhSach
            // 
            this.btnXemDanhSach.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemDanhSach.Location = new System.Drawing.Point(143, 100);
            this.btnXemDanhSach.Name = "btnXemDanhSach";
            this.btnXemDanhSach.Size = new System.Drawing.Size(290, 80);
            this.btnXemDanhSach.TabIndex = 1;
            this.btnXemDanhSach.Text = "XEM";
            this.btnXemDanhSach.UseVisualStyleBackColor = true;
            this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_Click);
            // 
            // btnDS_Trai
            // 
            this.btnDS_Trai.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDS_Trai.Location = new System.Drawing.Point(144, 218);
            this.btnDS_Trai.Name = "btnDS_Trai";
            this.btnDS_Trai.Size = new System.Drawing.Size(41, 104);
            this.btnDS_Trai.TabIndex = 1;
            this.btnDS_Trai.Text = "<";
            this.btnDS_Trai.UseVisualStyleBackColor = true;
            this.btnDS_Trai.Click += new System.EventHandler(this.btnDS_Trai_Click);
            // 
            // btnDS_Phai
            // 
            this.btnDS_Phai.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDS_Phai.Location = new System.Drawing.Point(786, 218);
            this.btnDS_Phai.Name = "btnDS_Phai";
            this.btnDS_Phai.Size = new System.Drawing.Size(41, 104);
            this.btnDS_Phai.TabIndex = 0;
            this.btnDS_Phai.Text = ">";
            this.btnDS_Phai.UseVisualStyleBackColor = true;
            this.btnDS_Phai.Click += new System.EventHandler(this.btnDS_Phai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 487);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.tabControl1.ResumeLayout(false);
            this.TrangChu.ResumeLayout(false);
            this.TraCuu.ResumeLayout(false);
            this.TraCuu.PerformLayout();
            this.LichSu.ResumeLayout(false);
            this.panelLichSu.ResumeLayout(false);
            this.ThemTu.ResumeLayout(false);
            this.ThemTu.PerformLayout();
            this.ThemNghia.ResumeLayout(false);
            this.ThemNghia.PerformLayout();
            this.XoaTu.ResumeLayout(false);
            this.XoaTu.PerformLayout();
            this.XoaNghia.ResumeLayout(false);
            this.XoaNghia.PerformLayout();
            this.InTatCa.ResumeLayout(false);
            this.panelDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TrangChu;
        private System.Windows.Forms.TabPage TraCuu;
        private System.Windows.Forms.TabPage LichSu;
        private System.Windows.Forms.TabPage ThemTu;
        private System.Windows.Forms.TabPage ThemNghia;
        private System.Windows.Forms.TabPage XoaTu;
        private System.Windows.Forms.TabPage XoaNghia;
        private System.Windows.Forms.TabPage InTatCa;
        private System.Windows.Forms.Button btnThemTu;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnInTatCa;
        private System.Windows.Forms.Button btnXoaNghia;
        private System.Windows.Forms.Button btnXoaTu;
        private System.Windows.Forms.Button btnThemNghia;
        private System.Windows.Forms.Panel panelTraCuu;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.TextBox textBoxTraCuu;
        private System.Windows.Forms.Button btnLichSu_Phai;
        private System.Windows.Forms.Panel panelLichSu;
        private System.Windows.Forms.Button btnLichSu_Trai;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox textBoxThem;
        private System.Windows.Forms.ComboBox comboBoxNghiabt;
        private System.Windows.Forms.ComboBox comboBoxTenRieng;
        private System.Windows.Forms.TextBox textBoxTenRieng;
        private System.Windows.Forms.TextBox textBoxNghiabt;
        private System.Windows.Forms.Button _btnThemTu;
        private System.Windows.Forms.ComboBox comboBoxTuLoai;
        private System.Windows.Forms.Button _btnThemNghia;
        private System.Windows.Forms.TextBox textBoxNghia_Them;
        private System.Windows.Forms.TextBox textBoxThemNghia;
        private System.Windows.Forms.ComboBox comboBoxChonNghia;
        private System.Windows.Forms.TextBox textBoxXoaTu;
        private System.Windows.Forms.Button _btnXoaTu;
        private System.Windows.Forms.TextBox textBoxVitriXoa;
        private System.Windows.Forms.Panel panelNghiaCuaTu;
        private System.Windows.Forms.TextBox textBoxXoaNghia;
        private System.Windows.Forms.Button _btnXoaNghia;
        private System.Windows.Forms.Button btnXemList;
        private System.Windows.Forms.Button btnDS_Trai;
        private System.Windows.Forms.Button btnDS_Phai;
        private System.Windows.Forms.Panel panelDanhSach;
        private System.Windows.Forms.Button btnXemDanhSach;
    }
}

