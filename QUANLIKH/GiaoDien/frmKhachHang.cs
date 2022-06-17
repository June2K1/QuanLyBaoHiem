using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QUANLIKH.Controller;
using System.Collections;

namespace QUANLIKH.GiaoDien
{
    public partial class frmKhachHang : Office2007Form
    {
        KhachHangControl khctrl = new KhachHangControl();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            khctrl.HienThi(dgv, bn, txtMaKhachHang, txtHoTen, txtBienSo, txtSoKhung, txtSoMay, txtDiaChi);

        }

        

        private void Luu_Click(object sender, EventArgs e)
        {
            khctrl.CapNhat();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng này không ?", "XOA DONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = dgv.SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dgv.Rows.Remove(row);
                }
            }
        }

        private void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "XOA DONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = dgv.SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dgv.Rows.Remove(row);
                }
            }
       }

       


        //private void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "XOA DONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        IEnumerator ie = dgv.SelectedRows.GetEnumerator();
        //        while (ie.MoveNext())
        //        {
        //            DataGridViewRow row = (DataGridViewRow)ie.Current;
        //            dgv.Rows.Remove(row);
        //        }
        //    }
        //}

        //private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show ("Bạn có chắc chắn xóa dòng này không?","XOA DONG",MessageBoxButtons .YesNo ,MessageBoxIcon.Question )== DialogResult .Yes )
        //        IEnumerator ie = dgv.SelectedRows.GetEnumerator();
        //        while (ie.MoveNext())
        //        {
        //            DataGridViewRow row = (DataGridViewRow)ie.Current;
        //            dgv.Rows.Remove(row);
        //        }
        //}
        /* private void dataGridViewTenTinh_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
              if (MessageBox.Show("Bạn có chắc muốn xóa dòng này không ?", "XOA DONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = dataGridViewTenTinh  .SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dataGridViewTenTinh.Rows.Remove(row);
                }

            }
            else e.Cancel = true;
        }
         */

       
       
       

       

      

       

    
    }
}