﻿namespace QuanLySinhVien
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstView = new System.Windows.Forms.ListView();
            this.imgList_Large = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiYeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.chk_Co = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtQue = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tSB_Them = new System.Windows.Forms.ToolStripButton();
            this.tSB_Sua = new System.Windows.Forms.ToolStripButton();
            this.tSB_Xoa = new System.Windows.Forms.ToolStripButton();
            this.tSB_Luu = new System.Windows.Forms.ToolStripButton();
            this.tSB_Capnhat = new System.Windows.Forms.ToolStripButton();
            this.tSB_Thoat = new System.Windows.Forms.ToolStripButton();
            this.tSB_Email = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip);
            this.splitContainer1.Size = new System.Drawing.Size(999, 626);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 626);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh đại diện";
            // 
            // lstView
            // 
            this.lstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView.LargeImageList = this.imgList_Large;
            this.lstView.Location = new System.Drawing.Point(3, 16);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(205, 607);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.lstView_SelectedIndexChanged);
            this.lstView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstView_MouseClick);
            // 
            // imgList_Large
            // 
            this.imgList_Large.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Large.ImageStream")));
            this.imgList_Large.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Large.Images.SetKeyName(0, "14150401.jpg");
            this.imgList_Large.Images.SetKeyName(1, "14150402.jpg");
            this.imgList_Large.Images.SetKeyName(2, "14150403.jpg");
            this.imgList_Large.Images.SetKeyName(3, "14150404.jpg");
            this.imgList_Large.Images.SetKeyName(4, "14150405.jpg");
            this.imgList_Large.Images.SetKeyName(5, "14150406.jpg");
            this.imgList_Large.Images.SetKeyName(6, "14150407.jpg");
            this.imgList_Large.Images.SetKeyName(7, "14150408.jpg");
            this.imgList_Large.Images.SetKeyName(8, "14150409.jpg");
            this.imgList_Large.Images.SetKeyName(9, "14150410.jpg");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(785, 374);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.hoTen,
            this.lop,
            this.ngaySinh,
            this.gioiTinh,
            this.queQuan,
            this.diemTB,
            this.nguoiYeu,
            this.email});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(779, 355);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // maSV
            // 
            this.maSV.FillWeight = 70F;
            this.maSV.HeaderText = "Mã SV";
            this.maSV.Name = "maSV";
            this.maSV.ReadOnly = true;
            // 
            // hoTen
            // 
            this.hoTen.HeaderText = "Họ và Tên";
            this.hoTen.Name = "hoTen";
            this.hoTen.ReadOnly = true;
            this.hoTen.Width = 200;
            // 
            // lop
            // 
            this.lop.FillWeight = 70F;
            this.lop.HeaderText = "Lớp";
            this.lop.Name = "lop";
            this.lop.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.FillWeight = 80F;
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.FillWeight = 80F;
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // queQuan
            // 
            this.queQuan.HeaderText = "Quê quán";
            this.queQuan.Name = "queQuan";
            this.queQuan.ReadOnly = true;
            this.queQuan.Width = 200;
            // 
            // diemTB
            // 
            this.diemTB.FillWeight = 70F;
            this.diemTB.HeaderText = "Điểm TB";
            this.diemTB.Name = "diemTB";
            this.diemTB.ReadOnly = true;
            this.diemTB.Width = 70;
            // 
            // nguoiYeu
            // 
            this.nguoiYeu.FillWeight = 70F;
            this.nguoiYeu.HeaderText = "Người yêu";
            this.nguoiYeu.Name = "nguoiYeu";
            this.nguoiYeu.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.rdbNu);
            this.groupBox2.Controls.Add(this.rdbNam);
            this.groupBox2.Controls.Add(this.chk_Co);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDiem);
            this.groupBox2.Controls.Add(this.txtQue);
            this.groupBox2.Controls.Add(this.dateTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.txtLop);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 227);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(614, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Email";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(30, 198);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(693, 26);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 5;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(614, 26);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 4;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // chk_Co
            // 
            this.chk_Co.AutoSize = true;
            this.chk_Co.Location = new System.Drawing.Point(614, 193);
            this.chk_Co.Name = "chk_Co";
            this.chk_Co.Size = new System.Drawing.Size(39, 17);
            this.chk_Co.TabIndex = 8;
            this.chk_Co.Text = "Có";
            this.chk_Co.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(541, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Người yêu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(541, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Giới tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(542, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Điểm TB";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(614, 108);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(152, 20);
            this.txtDiem.TabIndex = 7;
            // 
            // txtQue
            // 
            this.txtQue.Location = new System.Drawing.Point(614, 64);
            this.txtQue.Name = "txtQue";
            this.txtQue.Size = new System.Drawing.Size(152, 20);
            this.txtQue.TabIndex = 6;
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(342, 169);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(174, 20);
            this.dateTime.TabIndex = 3;
            this.dateTime.Value = new System.DateTime(2016, 9, 18, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ và tên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(342, 38);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(174, 20);
            this.txtMaSV.TabIndex = 0;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(342, 121);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(174, 20);
            this.txtLop.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(342, 77);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(174, 20);
            this.txtTen.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_Them,
            this.tSB_Sua,
            this.tSB_Xoa,
            this.tSB_Luu,
            this.tSB_Capnhat,
            this.tSB_Thoat,
            this.tSB_Email});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(785, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tSB_Them
            // 
            this.tSB_Them.Image = ((System.Drawing.Image)(resources.GetObject("tSB_Them.Image")));
            this.tSB_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Them.Name = "tSB_Them";
            this.tSB_Them.Size = new System.Drawing.Size(58, 22);
            this.tSB_Them.Text = "Thêm";
            this.tSB_Them.Click += new System.EventHandler(this.toolSB_Them_Click);
            // 
            // tSB_Sua
            // 
            this.tSB_Sua.Image = ((System.Drawing.Image)(resources.GetObject("tSB_Sua.Image")));
            this.tSB_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Sua.Name = "tSB_Sua";
            this.tSB_Sua.Size = new System.Drawing.Size(46, 22);
            this.tSB_Sua.Text = "Sửa";
            this.tSB_Sua.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tSB_Xoa
            // 
            this.tSB_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("tSB_Xoa.Image")));
            this.tSB_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Xoa.Name = "tSB_Xoa";
            this.tSB_Xoa.Size = new System.Drawing.Size(47, 22);
            this.tSB_Xoa.Text = "Xóa";
            this.tSB_Xoa.Click += new System.EventHandler(this.tSB_Xoa_Click);
            // 
            // tSB_Luu
            // 
            this.tSB_Luu.Image = ((System.Drawing.Image)(resources.GetObject("tSB_Luu.Image")));
            this.tSB_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Luu.Name = "tSB_Luu";
            this.tSB_Luu.Size = new System.Drawing.Size(47, 22);
            this.tSB_Luu.Text = "Lưu";
            this.tSB_Luu.Click += new System.EventHandler(this.toolSB_Luu_Click);
            // 
            // tSB_Capnhat
            // 
            this.tSB_Capnhat.Image = ((System.Drawing.Image)(resources.GetObject("tSB_Capnhat.Image")));
            this.tSB_Capnhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Capnhat.Name = "tSB_Capnhat";
            this.tSB_Capnhat.Size = new System.Drawing.Size(75, 22);
            this.tSB_Capnhat.Text = "Cập nhật";
            this.tSB_Capnhat.Click += new System.EventHandler(this.tSB_Capnhat_Click);
            // 
            // tSB_Thoat
            // 
            this.tSB_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("tSB_Thoat.Image")));
            this.tSB_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Thoat.Name = "tSB_Thoat";
            this.tSB_Thoat.Size = new System.Drawing.Size(58, 22);
            this.tSB_Thoat.Text = "Thoát";
            this.tSB_Thoat.Click += new System.EventHandler(this.tSB_Thoat_Click);
            // 
            // tSB_Email
            // 
            this.tSB_Email.Image = ((System.Drawing.Image)(resources.GetObject("tSB_Email.Image")));
            this.tSB_Email.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Email.Name = "tSB_Email";
            this.tSB_Email.Size = new System.Drawing.Size(56, 22);
            this.tSB_Email.Text = "Email";
            this.tSB_Email.Click += new System.EventHandler(this.tSB_Email_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(999, 626);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Phần mềm quản lý sinh viên (v1.0)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripButton tSB_Sua;
        private System.Windows.Forms.ToolStripButton tSB_Xoa;
        private System.Windows.Forms.ToolStripButton tSB_Capnhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ToolStripButton tSB_Them;
        private System.Windows.Forms.ToolStripButton tSB_Luu;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.CheckBox chk_Co;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtQue;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ImageList imgList_Large;
        private System.Windows.Forms.ToolStripButton tSB_Thoat;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton tSB_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiYeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}

