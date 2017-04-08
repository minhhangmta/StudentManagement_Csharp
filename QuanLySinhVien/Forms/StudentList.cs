using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace QuanLySinhVien.Forms
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }
        public static List<string> emailList = new List<string>();

        public void GetAllStudent()
        {
            StreamReader reader = null;
            reader = File.OpenText("danhsach.txt");
            List<SinhVien> list = new List<SinhVien>();
            string str;
            while ((str = reader.ReadLine()) != null)
            {
                string[] st = str.Split('|');
                SinhVien sv = new SinhVien(st[0], st[1], st[2], st[3], st[4], st[5], st[6], st[7], st[8]);
                list.Add(sv);
            }
            reader.Close();
            foreach (SinhVien sv in list)
            {
                dGV.Rows.Add(false, sv.MaSV, sv.HoTen, sv.Lop, sv.NgaySinh, sv.GioiTinh, sv.QueQuan, sv.DiemTB, sv.NguoiYeu, sv.Email);
            }

        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            dGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GetAllStudent();
        }

        private void StudentList_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (DataGridViewRow item in dGV.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    emailList.Add(item.Cells[9].Value.ToString());
                }
            }
        }
    }
}
