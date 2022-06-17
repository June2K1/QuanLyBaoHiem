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
    public partial class frmDaiLy : Office2007Form
    {
        DaiLyControl dlctrl = new DaiLyControl();


        public frmDaiLy()
        {
            InitializeComponent();
        }
        NhanVienControl nvctrl = new NhanVienControl();
        private void frmDaiLy_Load(object sender, EventArgs e)
        {
            dlctrl.HienThi(dgv, bn, txtMaDaiLy, txtHoTen, dtNgaySinh, txtCMND, dtNgayCap, txtNoiCap, txtDiaChi, txtDienThoai, txtFax, txtSoTaiKhoan, txtNganHang, txtTrinhDo, cmbMaNVQL, txtGhiChu);
            //dlctrl.HienThiLenDataGridView(dgv, bn);
            nvctrl.HienThiLenComboBox(cmbMaNVQL);
        }

      

        private void Luu_Click_1(object sender, EventArgs e)
        {
            dlctrl.CapNhat();

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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        

        

        

        

       
       
    }
}