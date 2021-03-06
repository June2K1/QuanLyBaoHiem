using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace QUANLIKH.Controller
{
    
   public  class DaiLyControl
    {
       DaiLyData data= new DaiLyData ();
       NhanVienControl nvctrl = new NhanVienControl();

       public void HienThi(DataGridViewX dgv, BindingNavigator bn, TextBox txtMaDaiLy, TextBox txtHoTen, DateTimePicker dtNgaySinh, TextBox txtCMND, DateTimePicker dtNgayCap, TextBox txtNoiCap, TextBox txtDiaChi, TextBox txtDienThoai, TextBox  txtFax, TextBox txtSoTaiKhoan, TextBox txtNganHang, TextBox txtTrinhDo, ComboBox cmbMaNVQL, TextBox txtGhiChu)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = data.SelectAll();

           dgv.DataSource = bs;
           bn.BindingSource = bs;

           txtMaDaiLy.DataBindings.Clear();
           txtMaDaiLy.DataBindings.Add("Text", bs, "MADAILY");

           txtHoTen.DataBindings.Clear();
           txtHoTen.DataBindings.Add("Text", bs, "HOVATEN");

           dtNgaySinh.DataBindings.Clear();
           dtNgaySinh.DataBindings.Add("Text", bs, "NGAYSINH");

           txtCMND.DataBindings.Clear();
           txtCMND.DataBindings.Add("Text", bs, "CMND");

           dtNgayCap.DataBindings.Clear();
           dtNgayCap.DataBindings.Add("Text", bs, "NGAYCAP");

           txtNoiCap.DataBindings.Clear();
           txtNoiCap.DataBindings.Add("Text", bs, "NOICAP");

           txtDiaChi.DataBindings.Clear();
           txtDiaChi.DataBindings.Add("Text", bs, "DIACHI");

           txtDienThoai.DataBindings.Clear();
           txtDienThoai.DataBindings.Add("Text", bs, "DIENTHOAI");

           txtFax.DataBindings.Clear();
           txtFax.DataBindings.Add("Text", bs, "FAX");

           txtSoTaiKhoan.DataBindings.Clear();
           txtSoTaiKhoan.DataBindings.Add("Text", bs, "SOTAIKHOAN");

           txtNganHang.DataBindings.Clear();
           txtNganHang.DataBindings.Add("Text", bs, "NGANHANG");

           txtTrinhDo.DataBindings.Clear();
           txtTrinhDo.DataBindings.Add("Text", bs, "TRINHDO");

           cmbMaNVQL.DataBindings.Clear();
           cmbMaNVQL.DataBindings.Add("SelectedValue", bs, "MANVQL");
           

           // remove va add col
           dgv.Columns.Remove("MANVQL");

           NhanVienControl nvctrl = new NhanVienControl();
           DataGridViewComboBoxColumn nvcol = nvctrl.LoadComboBoxColumn();
           nvcol.DataPropertyName = "MANVQL";
           dgv.Columns.Add(nvcol);

           txtGhiChu.DataBindings.Clear();
           txtGhiChu.DataBindings.Add("Text", bs, "GHICHU");


       }
       public void CapNhat()
       {
           data.Update();
       }


       public void HienThiLenComboBox(ComboBox cmb,string mnv)
       {
           BindingSource bs = new BindingSource();
           //bs.DataSource = data.SelectAll();
           bs.DataSource = data.SelectAll( mnv);
           cmb.DataSource = bs;
           cmb.DisplayMember = "HOVATEN";
           cmb.ValueMember = "MADAILY";
       }
       public DataGridViewComboBoxColumn LoadComboBoxColumn()
       {
           DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
          col.DataSource = data.SelectAll();

           col.DisplayMember = "HOVATEN";
           col.ValueMember = "MADAILY";

           col.HeaderText = "Mã Đại Lý";
           col.Width = 150;

           col.DataPropertyName = "MADAILY";

           return col;
       }



       internal void Capnhat()
       {
           // throw new Exception("The method or operation is not implemented.");
           data.Update();
       }

       
       internal void HienThiLenComboBox(ComboBoxEx cmb)
       {
           BindingSource bs = new BindingSource();
           //bs.DataSource = data.SelectAll();
           bs.DataSource = data.SelectAll();
           cmb.DataSource = bs;
           cmb.DisplayMember = "HOVATEN";
           cmb.ValueMember = "MADAILY";
       }


       internal void HienThiLenComboBox(ComboBox cmb)
       {
           BindingSource bs = new BindingSource();
           //bs.DataSource = data.SelectAll();
           bs.DataSource = data.SelectAll();
           cmb.DataSource = bs;
           cmb.DisplayMember = "HOVATEN";
           cmb.ValueMember = "MADAILY";
       }

      
       /* internal void TimDVCT(DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewDonViCongTac, BindingNavigator bindingNavigator1, DevComponents.DotNetBar.Controls.TextBoxX textBoxTenDonViCongTac, ComboBox chondiachi, DevComponents.DotNetBar.Controls.TextBoxX textBoxDiaChi)
       {
          // throw new Exception("The method or operation is not implemented.");
           BindingSource bs = new BindingSource();
           bs.DataSource = data.Find(textBoxTenDonViCongTac.Text, chondiachi.SelectedItem.ToString(), textBoxDiaChi.Text);
           dataGridViewDonViCongTac.DataSource = bs;
           if (dataGridViewDonViCongTac.RowCount == 1)
               MessageBox.Show("Không tìm được đơn vị công tác theo yêu cầu tìm kiếm của bạn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           bindingNavigator1.BindingSource = bs;
       }*/
       //internal void TimDaiLy(DevComponents.DotNetBar.Controls.DataGridViewX dgv, BindingNavigator bindingNavigatorTimKiemDaiLy, DevComponents.DotNetBar.Controls.TextBoxX txtHoTenDaiLy, ComboBox cmbChonMaNVQL, ComboBox cmbNVQL, ComboBox cmbChonDiaChi, ComboBox cmbDiaChi)
       //{
       //    BindingSource bs = new BindingSource();
       //    bs.DataSource=data.
       //}

       internal void TimDaiLy(DevComponents.DotNetBar.Controls.DataGridViewX dgv, BindingNavigator bn, DevComponents.DotNetBar.Controls.TextBoxX txtHoTenDaiLy, ComboBox cmbChonMaNVQL, ComboBox cmbNVQL, ComboBox cmbChonDiaChi,  DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi)
       {
           BindingSource bs = new BindingSource();
           /*bs.DataSource = data.Find(textBoxHoTenKhachHang.Text, cmbChonDiaChi.SelectedItem.ToString(), textBoxDiaChi.Text, cmbChonBienSo.SelectedItem.ToString(), textBoxBienSo.Text, cmbChonSoKhung.SelectedItem.ToString(), textBoxSoKhung.Text, cmbSoMay.SelectedItem.ToString(), textBoxSoMay.Text);*/
           bs.DataSource = data.Find(txtHoTenDaiLy.Text, cmbChonMaNVQL.SelectedItem.ToString(), cmbNVQL.SelectedItem.ToString(), cmbChonDiaChi.SelectedItem.ToString(), txtDiaChi.Text);
           dgv.DataSource = bs;
           if(dgv.RowCount == 1)
               MessageBox.Show("Không tìm được đại lý theo yêu cầu tìm kiếm của bạn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            bn.BindingSource = bs;
       }

       internal void HienThi(ComboBoxEx cmbChonDaiLy, string p)
       {
           throw new Exception("The method or operation is not implemented.");
       }
   }
}
