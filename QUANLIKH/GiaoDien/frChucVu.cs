using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLIKH.Controller;
using System.Collections;
using DevComponents.DotNetBar;

namespace QUANLIKH.GiaoDien
{
    public partial class frChucVu : Office2007Form
    {
        public frChucVu()
        {
            InitializeComponent();
        }
        ChucVuControl chucvuCtrl = new ChucVuControl();
        private void frChucVu_Load(object sender, EventArgs e)
        {
            chucvuCtrl.Hienthi(dgv, bn, txtMaChucVu, txtTenChucVu);

        }

        private void Luu_Click(object sender, EventArgs e)
        {
            chucvuCtrl.CapNhat();
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
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng này không ?", "XOA DONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = dgv.SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dgv.Rows.Remove(row);
                }

            }
            else e.Cancel = true;
        }
    }
}