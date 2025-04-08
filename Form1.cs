using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3_01_NguyenHoangKhanhGiang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                label3.Text = DateTime.Now.ToLongTimeString();
                checkBox1.Enabled = false;
                checkBox2.Enabled = true;
                checkBox2.Checked = false;
            }            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label4.Text = DateTime.Now.ToLongTimeString();
                DateTime batdau = Convert.ToDateTime(label3.Text);
                DateTime ketthuc = Convert.ToDateTime(label4.Text);
                TimeSpan thoigian = ketthuc - batdau;
                double dbGio = thoigian.TotalHours;
                double dbTien = dbGio * 3000;
                MessageBox.Show("Số giờ thuê là: " + dbGio + " giờ" + "\n" +
                    "Số tiền phải trả là: " + dbTien + "VND", "Thông báo Máy 1!");
                label3.Text = "";
                label4.Text = "";
                checkBox1.Enabled = true;
                checkBox2.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true)
            {
                MessageBox.Show("Có  1 máy trong hệ thống vẫn chưa tính tiền!", "Warming");
            }
            else
            {
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
