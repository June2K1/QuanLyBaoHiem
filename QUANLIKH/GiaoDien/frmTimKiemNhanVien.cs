using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLIKH.Controller;
using DevComponents.DotNetBar;

namespace QUANLIKH.GiaoDien
{
    public partial class frmTimKiemNhanVien : Office2007Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }
        NhanVienControl nv = new NhanVienControl();
        private void buttontimkh_Click(object sender, EventArgs e)
        {
            nv.timnhanvien(dgv, bn, txtTenNhanVien, cmbPhai, cmbChonPhai, txtDiaChi, cmbChonDiaChi);
        }

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MaPhai");
            tb.Columns.Add("TenPhai");
            object[] t1 ={ 0, "Nam" };
            object[] t2 ={ 1, "Nữ" };

            if (tb.Rows.Count < 3)
            {

                tb.Rows.Add(t1);
                tb.Rows.Add(t2);
            }

            cmbPhai.DataSource = tb;
            cmbPhai.DisplayMember = "TenPhai";
            cmbPhai.ValueMember = "MaPhai";
           
            cmbChonPhai.SelectedIndex = 1;
            cmbChonDiaChi.SelectedIndex = 0;
            
        }

        private void cmbChonPhai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChonPhai.SelectedIndex != 0)
                cmbPhai.Enabled = true;
            else
                cmbPhai.Enabled = false;
        }

        private void cmbChonDiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChonDiaChi.SelectedIndex != 0)
                txtDiaChi.Enabled = true;
            else
                txtDiaChi.Enabled = false;
        }
    }
}