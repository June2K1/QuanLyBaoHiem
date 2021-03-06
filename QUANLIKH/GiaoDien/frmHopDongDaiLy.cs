using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLIKH.Controller;
using DevComponents.DotNetBar;
using System.Collections;

namespace QUANLIKH.GiaoDien
{
    public partial class frmHopDongDaiLy : Office2007Form
    {
        public frmHopDongDaiLy()
        {
            InitializeComponent();
        }
        HopDongControl hdctrl = new HopDongControl();
        DaiLyControl dlctrl = new DaiLyControl();
        private void frmHopDongDaiLy_Load(object sender, EventArgs e)
        {
            hdctrl.HienThi(dgv, bn, txtSoHopDong, cmbMaDaiLy, txtTenHopDong, dtNgayKy, dtNgayHetHan, dtNgayThanhLy);
            dlctrl.HienThiLenComboBox(cmbMaDaiLy);
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            hdctrl.CapNhat();
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel=true ;
        }
        frmDaiLy dl = null;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (dl == null || dl.IsDisposed)
            {
                dl = new frmDaiLy();
                dl.Show();
                dl.MdiParent = (frmMain)this.ParentForm;
                dl.WindowState = FormWindowState.Maximized;
            }
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }



       
    }
}