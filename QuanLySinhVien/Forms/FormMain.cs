using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BL;

namespace QuanLySinhVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        List<SinhVien> dsSV = new List<SinhVien>();
        string tool = "";
        /// <summary>
        /// Doc file va dua len Gridview
        /// </summary>
        /// <param name="path"></param>
        public void GetAllStudent()
        {
            StreamReader reader = null;
            reader = File.OpenText("danhsach.txt");
            //  List<SinhVien> list = new List<SinhVien>();
            string str;
            while ((str = reader.ReadLine()) != null)
            {
                string[] st = str.Split('|');
                SinhVien sv = new SinhVien(st[0], st[1], st[2], st[3], st[4], st[5], st[6], st[7], st[8]);
                dsSV.Add(sv);
            }
            reader.Close();
            foreach (SinhVien sv in dsSV)
            {
                dataGridView.Rows.Add(sv.MaSV, sv.HoTen, sv.Lop, sv.NgaySinh, sv.GioiTinh, sv.QueQuan, sv.DiemTB, sv.NguoiYeu, sv.Email);
            }

        }


        public void LoadImage()
        {
            //Load image len listview 
            int i = 0;
            string[] dirs = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"Images");
            foreach (string dir in dirs)
            {
                string[] str = dir.Split('\\');
                ListViewItem item = new ListViewItem(str[str.Length - 1], i);
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                //subItem.Name = maSV.ToString();
                item.SubItems.Add("");
                lstView.Items.Add(item);
                //lstView.Items.Add(sarr[sarr.Length - 1], i);
                //   lstView.Items.Add(dir, i);
                i++;
                if (i == imgList_Large.Images.Count)
                    i = 0;
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            tSB_Luu.Enabled = false;
            tSB_Thoat.Enabled = false;
            btnBrowse.Enabled = false;
            LoadImage();
            //Dua du lieu len grid
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //
            GetAllStudent();
        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id của dòng đang chọn
            //MessageBox.Show(dataGridView.CurrentRow.Index.ToString());
            //Cách 1 truy cập từng cell giá trị và gán lên 
            try
            {
                if (dataGridView.CurrentRow.Cells["maSV"].Value != null)
                {
                    txtMaSV.Text = dataGridView.CurrentRow.Cells["maSV"].Value.ToString();
                    txtTen.Text = dataGridView.CurrentRow.Cells["hoTen"].Value.ToString();
                    txtQue.Text = dataGridView.CurrentRow.Cells["queQuan"].Value.ToString();
                    txtLop.Text = dataGridView.CurrentRow.Cells["lop"].Value.ToString();
                    txtDiem.Text = dataGridView.CurrentRow.Cells["diemTB"].Value.ToString();
                    txtEmail.Text = dataGridView.CurrentRow.Cells["email"].Value.ToString();
                    dateTime.Value = DateTime.Parse(dataGridView.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    //Gioi tinh
                    string GT = dataGridView.CurrentRow.Cells["gioiTinh"].Value.ToString();
                    if (GT == "Nam")
                        rdbNam.Checked = true;
                    if (GT == "Nu")
                        rdbNu.Checked = true;
                    //Nguoi yeu
                    string ny = dataGridView.CurrentRow.Cells["nguoiYeu"].Value.ToString();
                    if (ny == "Co")
                    {
                        chk_Co.Checked = true;
                    }
                    else
                    {
                        chk_Co.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Thiết lập lại trạng thái ban đầu
        /// </summary>
        public void Reset()
        {
            txtMaSV.Clear();
            txtDiem.Clear();
            txtQue.Clear();
            txtTen.Clear();
            txtLop.Clear();
            txtEmail.Clear();
            chk_Co.Checked = false;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
        }

        public void WriteToFile(List<SinhVien> list)
        {
            FileStream fs = new FileStream("danhsach.txt", FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter write = new StreamWriter(fs);
            foreach (SinhVien newSV in list)
            {
                string s = newSV.MaSV + "|" + newSV.HoTen + "|" + newSV.Lop + "|" + newSV.NgaySinh + "|"
                    + newSV.GioiTinh + "|" + newSV.QueQuan + "|" + newSV.DiemTB + "|" + newSV.NguoiYeu + "|" + newSV.Email;
                write.WriteLine(s);
            }
            write.Close();
        }

        public void DeleteAStudent()
        {
            // int index = dsSV.FindIndex(x => x.MaSV == txtMaSV.Text);
            // if (index != -1)
            dsSV.RemoveAt(dsSV.FindIndex(x => x.MaSV == txtMaSV.Text));
            WriteToFile(dsSV);
        }
        // Tool Sửa
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tool = "Sua";
            txtMaSV.Enabled = false;
            tSB_Capnhat.Enabled = false;
            tSB_Sua.Enabled = false;
            tSB_Them.Enabled = false;
            tSB_Xoa.Enabled = false;
            tSB_Luu.Enabled = true;
            tSB_Thoat.Enabled = true;
            btnBrowse.Enabled = true;

        }
        //Tool Them
        private void toolSB_Them_Click(object sender, EventArgs e)
        {
            tool = "Them";
            tSB_Them.Enabled = false;
            tSB_Sua.Enabled = false;
            tSB_Xoa.Enabled = false;
            tSB_Capnhat.Enabled = false;
            tSB_Luu.Enabled = true;
            tSB_Thoat.Enabled = true;
            btnBrowse.Enabled = true;
            Reset();
        }

        private void toolSB_Luu_Click(object sender, EventArgs e)
        {
            if (tool == "Them")
            {
                string id = txtMaSV.Text;
                bool check = true;
                foreach (SinhVien sv in dsSV)
                {
                    if (id == sv.MaSV || id == null)
                        check = false;
                }
                if (check == false)
                {
                    MessageBox.Show("Mã Sinh Viên không hợp lệ. Vui lòng nhập lại");
                    Reset();
                }
                else
                {
                    string name = txtTen.Text;
                    string class_ = txtLop.Text;
                    string date = dateTime.Value.ToString();
                    string count = txtQue.Text;
                    string score = txtDiem.Text;
                    string mail = txtEmail.Text;
                    string love;
                    if (chk_Co.Checked == true)
                        love = "Co";
                    else
                        love = "Khong";
                    string gender;
                    if (rdbNam.Checked == true)
                        gender = "Nam";
                    else
                        gender = "Nu";
                    SinhVien newSV = new SinhVien(id, name, class_, date, gender, count, score, love,mail);
                    StreamWriter write = new StreamWriter("danhsach.txt", true);
                    string s = newSV.MaSV + "|" + newSV.HoTen + "|" + newSV.Lop + "|" + newSV.NgaySinh + "|" + newSV.GioiTinh + "|"
                        + newSV.QueQuan + "|" + newSV.DiemTB + "|" + newSV.NguoiYeu + "|"+newSV.Email;
                    write.WriteLine(s);
                    write.Close();
                    dataGridView.Rows.Clear();
                    dsSV.Clear();
                    GetAllStudent();
                }

            }
            if (tool == "Sua")
            {
                DeleteAStudent();
                string id = txtMaSV.Text;
                string name = txtTen.Text;
                string class_ = txtLop.Text;
                string date = dateTime.Value.ToString();
                string count = txtQue.Text;
                string score = txtDiem.Text;
                string mail = txtEmail.Text;
                string love;
                if (chk_Co.Checked == true)
                    love = "Co";
                else
                    love = "Khong";
                string gender;
                if (rdbNam.Checked == true)
                    gender = "Nam";
                else
                    gender = "Nu";
                SinhVien newSV = new SinhVien(id, name, class_, date, gender, count, score, love,mail);
                StreamWriter write = new StreamWriter("danhsach.txt", true);
                string s = newSV.MaSV + "|" + newSV.HoTen + "|" + newSV.Lop + "|" + newSV.NgaySinh + "|"
                    + newSV.GioiTinh + "|" + newSV.QueQuan + "|" + newSV.DiemTB + "|" + newSV.NguoiYeu + "|"+newSV.Email;
                write.WriteLine(s);
                write.Close();
                dataGridView.Rows.Clear();
                dsSV.Clear();
                GetAllStudent();
                txtMaSV.Enabled = true;
            }
            tSB_Them.Enabled = true;
            tSB_Sua.Enabled = true;
            tSB_Xoa.Enabled = true;
            tSB_Capnhat.Enabled = true;
            tSB_Luu.Enabled = false;
            tSB_Thoat.Enabled = false;
            tool = "";
        }

        private void tSB_Thoat_Click(object sender, EventArgs e)
        {
            tSB_Them.Enabled = true;
            tSB_Sua.Enabled = true;
            tSB_Xoa.Enabled = true;
            tSB_Capnhat.Enabled = true;
            tSB_Luu.Enabled = false;
            tSB_Thoat.Enabled = false;
            txtMaSV.Enabled = true;
            btnBrowse.Enabled = false;
            tool = "";
            Reset();
        }

        private void tSB_Capnhat_Click(object sender, EventArgs e)
        {
            Reset();
            dataGridView.Rows.Clear();
            dsSV.Clear();
            GetAllStudent();
        }

        private void tSB_Xoa_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            string s = txtMaSV.Text;
            if (s == "") return;
            else
            {
                DialogResult h = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên " + s + " không?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    DeleteAStudent();
                    Reset();
                    dataGridView.Rows.Clear();
                    dsSV.Clear();
                    GetAllStudent();
                    MessageBox.Show("Đã xóa sinh viên!", "Thông Báo");
                }
            }
        }

        private void lstView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem theClickedOne = lstView.GetItemAt(e.X, e.Y);
            if (theClickedOne != null)
            {
                string name = theClickedOne.Text;
                dataGridView.ClearSelection();
                for (int i = 0; i < dsSV.Count; i++)
                {
                    if (name.Substring(0, name.Length - 4) == dsSV[i].MaSV)
                    {
                        dataGridView.Rows[i].Selected = true;
                        dataGridView.CurrentCell = dataGridView.Rows[i].Cells[0];
                    }
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView.CurrentRow.Cells["maSV"].Value != null)
                {
                    txtMaSV.Text = dataGridView.CurrentRow.Cells["maSV"].Value.ToString();
                    txtTen.Text = dataGridView.CurrentRow.Cells["hoTen"].Value.ToString();
                    txtQue.Text = dataGridView.CurrentRow.Cells["queQuan"].Value.ToString();
                    txtLop.Text = dataGridView.CurrentRow.Cells["lop"].Value.ToString();
                    txtDiem.Text = dataGridView.CurrentRow.Cells["diemTB"].Value.ToString();
                    txtEmail.Text = dataGridView.CurrentRow.Cells["email"].Value.ToString();
                    dateTime.Value = DateTime.Parse(dataGridView.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    //Gioi tinh
                    string GT = dataGridView.CurrentRow.Cells["gioiTinh"].Value.ToString();
                    if (GT == "Nam")
                        rdbNam.Checked = true;
                    if (GT == "Nu")
                        rdbNu.Checked = true;
                    //Nguoi yeu
                    string ny = dataGridView.CurrentRow.Cells["nguoiYeu"].Value.ToString();
                    if (ny == "Co")
                    {
                        chk_Co.Checked = true;
                    }
                    else
                    {
                        chk_Co.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Open file dialog
            OpenFileDialog open = new OpenFileDialog();
            //Image filters
            open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
                //image file path

            }
            // MessageBox.Show("abc");
        }

        #region SelectedIndexChanged
        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  ListViewItem theClickedOne = lstView.GetItemAt(e.X, e.Y);
            //  if (theClickedOne != null)
            //   {
            //       pictureBox1.Image=theClickedOne.
            //    }
            // pictureBox1.Image=
        }
        #endregion

        private void tSB_Email_Click(object sender, EventArgs e)
        {
            Forms.Email em = new Forms.Email();
          //  this.Hide(); //Kết thúc form cha
            em.ShowDialog();
        }





    }
}
