using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapvenhabuoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvSinhVien.Columns[0].Width = (int)(lsvSinhVien.Width * 0.25);
            lsvSinhVien.Columns[1].Width = (int)(lsvSinhVien.Width * 0.25);
            lsvSinhVien.Columns[2].Width = (int)(lsvSinhVien.Width * 0.25);
            lsvSinhVien.Columns[3].Width = (int)(lsvSinhVien.Width * 0.25);
            lsvSinhVien.View = View.Details;
            lsvSinhVien.GridLines= true;
            lsvSinhVien.FullRowSelect= true;

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ListViewItem item = lsvSinhVien.Items.Add(tb_Id.Text);
            item.SubItems.Add(tb_ten.Text);
            item.SubItems.Add(tb_mssv.Text);
            item.SubItems.Add(tb_cccd.Text);
        }

        private void lsvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count > 0)
            {
                tb_Id.Text = lsvSinhVien.SelectedItems[0].SubItems[0].Text;
                tb_ten.Text = lsvSinhVien.SelectedItems[0].SubItems[1].Text;
                tb_mssv.Text = lsvSinhVien.SelectedItems[0].SubItems[2].Text;
                tb_cccd.Text = lsvSinhVien.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Id.Text))  
            {

                foreach (ListViewItem item in lsvSinhVien.Items)
                {
                    if (item.SubItems[0].Text == tb_Id.Text)
                    {
                        lsvSinhVien.Items.Remove(item);
                        return;  
                    }
                }
                MessageBox.Show("Không tìm thấy sinh viên với ID: " + tb_Id.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID để xóa.");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Id.Text))  
            {
                
                foreach (ListViewItem item in lsvSinhVien.Items)
                {
                    if (item.SubItems[0].Text == tb_Id.Text)
                    {
                        
                        item.SubItems[1].Text = tb_ten.Text;
                        item.SubItems[2].Text = tb_mssv.Text;
                        item.SubItems[3].Text = tb_cccd.Text;
                        return;  
                    }
                }
                MessageBox.Show("Không tìm thấy sinh viên với ID: " + tb_Id.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID để sửa.");
            }
        }
    }
}
