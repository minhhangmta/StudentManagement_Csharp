using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.Forms
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentList sl = new StudentList();
            sl.ShowDialog();
            string str = "";
            foreach (string s in StudentList.emailList)
            {
                str += s + "; ";
            }
            if (str != "")
            {
                str = str.Remove(str.Length - 2, 2);
                txtTo.Clear();
                txtTo.Text = str;
            }

        }

        private void Email_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentList.emailList.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi thư đến "+txtTo.Text);
            StudentList.emailList.Clear();
            txtTo.Clear();
            txtBody.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
