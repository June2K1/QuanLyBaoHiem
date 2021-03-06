using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.Data;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace QUANLIKH.Controller
{
    public class HopDongControl
    {
        HopDongData data = new HopDongData();
        public void HienThi(DataGridViewX dgv, BindingNavigator bn, TextBox txtSoHopDong, ComboBox cmbMaDaiLy, TextBox txtTenHopDong, DateTimePicker dtNgayKy, DateTimePicker dtNgayHetHan, DateTimePicker dtNgayThanhLy)
        {
            
           
            BindingSource bs = new BindingSource();
            bs.DataSource = data.SelectAll();

            dgv.DataSource = bs;
            bn.BindingSource = bs;

            txtSoHopDong.DataBindings.Clear();
            txtSoHopDong.DataBindings.Add("Text", bs, "SOHOPDONG");

            cmbMaDaiLy.DataBindings.Clear();
            cmbMaDaiLy.DataBindings.Add("SelectedValue", bs, "MADAILY");

            txtTenHopDong.DataBindings.Clear();
            txtTenHopDong.DataBindings.Add("Text", bs, "TENHOPDONG");


            dtNgayKy.DataBindings.Clear();
            dtNgayKy.DataBindings.Add("Text", bs, "NGAYKY");

            dtNgayHetHan.DataBindings.Clear();
            dtNgayHetHan.DataBindings.Add("Text", bs, "NGAYHETHAN");

            dtNgayThanhLy.DataBindings.Clear();
            dtNgayThanhLy.DataBindings.Add("Text", bs, "NGAYTHANHLY");

            //REMOVE VA ADD DAILY
            dgv.Columns.Remove("MADAILY");

            DaiLyControl dlctrl = new DaiLyControl();
            DataGridViewComboBoxColumn dlcol = dlctrl.LoadComboBoxColumn();
            dlcol.DataPropertyName = "MADAILY";
            dgv.Columns.Add(dlcol);


        }
        public void CapNhat()
        {
            data.Update();
        }

     
        internal void TimHopDong(DevComponents.DotNetBar.Controls.DataGridViewX dgv, BindingNavigator bindingNavigatorKhachHang, DevComponents.DotNetBar.Controls.TextBoxX txtSoHopDong, ComboBox cmbChonDaiLy, ComboBox cmbDaiLy)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.Find(txtSoHopDong.Text, cmbChonDaiLy.SelectedItem.ToString(), cmbDaiLy.SelectedItem.ToString());

            dgv.DataSource = bs;
            if (dgv.RowCount == 0)
                MessageBox.Show("Không tìm được hợp đồng theo yêu cầu tìm kiếm của bạn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            bindingNavigatorKhachHang.BindingSource = bs;
            
        }
    }
}