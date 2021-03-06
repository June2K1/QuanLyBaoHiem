using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.Data;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using System.Data;

namespace QUANLIKH.Controller
{
  public   class NhanVienControl
    {
      NhanVienData data = new NhanVienData();
      public void HienThi(DataGridView dgv, BindingNavigator bn, TextBox txtMaNVQL, TextBox txtHovaTen, DateTimePicker dtNgaySinh, ComboBox cmbPhai, TextBox txtCMND, TextBox txtDiaChi, TextBox txtDienThoai, TextBox txtFax, TextBox txtTaiKhoan, TextBox txtNganHang, ComboBox  cmbChucVu)
      {
          
          BindingSource bs = new BindingSource();
          bs.DataSource = data.SelectAll();

          dgv.DataSource = bs;
          bn.BindingSource = bs;


          txtMaNVQL.DataBindings.Clear();
          txtMaNVQL.DataBindings.Add("Text", bs, "MANVQL");

          txtHovaTen.DataBindings.Clear();
          txtHovaTen.DataBindings.Add("Text", bs, "HOVATEN");

          dtNgaySinh.DataBindings.Clear();
          dtNgaySinh.DataBindings.Add("Text", bs, "NGAYSINH");

          //cmbPhai.DataBindings.Clear();
          //cmbPhai.DataBindings.Add("Value", bs, "PHAI");

          //phai
          /*phai.DataBindings.Add("SelectedValue", bs, "PHAI");
*/
          cmbPhai.DataBindings.Add("SelectedValue", bs, "PHAI");

          DataGridViewComboBoxColumn phaicol = new DataGridViewComboBoxColumn();
          phaicol.Name = "stringPhai";
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
          phaicol.DataSource = tb;
          phaicol.DisplayMember = "TenPhai";
          phaicol.ValueMember = "MaPhai";

          phaicol.HeaderText = "Phái";
          phaicol.Width = 70;

          phaicol.DataPropertyName = "PHAI";
          dgv.Columns.Insert(dgv.Columns.IndexOf(dgv.Columns["PHAI"]), phaicol);
          dgv.Columns.Remove("PHAI");

          txtCMND.DataBindings.Clear();
          txtCMND.DataBindings.Add("Text", bs, "CMND");

          txtDiaChi.DataBindings.Clear();
          txtDiaChi.DataBindings.Add("Text", bs, "DIACHI");

          txtDienThoai.DataBindings.Clear();
          txtDienThoai.DataBindings.Add("Text", bs, "DIENTHOAI");

          txtFax.DataBindings.Clear();
          txtFax.DataBindings.Add("Text", bs, "FAX");

          txtTaiKhoan.DataBindings.Clear();
          txtTaiKhoan.DataBindings.Add("Text", bs, "TAIKHOAN");

          txtNganHang.DataBindings.Clear();
          txtNganHang.DataBindings.Add("Text", bs, "NGANHANG");

          cmbChucVu.DataBindings.Clear();
          cmbChucVu.DataBindings.Add("SelectedValue", bs, "MACHUCVU");
          //REMOVE VA ADD CHUC VU
          dgv.Columns.Remove("MACHUCVU");
          ChucVuControl chucvuctrl = new ChucVuControl();
          DataGridViewComboBoxColumn chucvucol = chucvuctrl.LoadComboBoxColumn();
          chucvucol.DataPropertyName ="MACHUCVU";
          dgv.Columns .Add (chucvucol);
          
      }
      /*//---remove va add col moi vao
            dgv.Columns.Remove("MATINH");
            TenTinhControl tinhctrl = new TenTinhControl();
            DataGridViewComboBoxColumn tinhcol = tinhctrl.LoadComboBoxColumn();
            tinhcol.DataPropertyName = "MATINH";
            dgv.Columns.Add(tinhcol);*/
      //remove và add
     

      public void CapNhat()
      {
          data.Update();
      }

      public void HienThiLenComboBox(ComboBox cmb)
      {
          //moc du lieu
          BindingSource bs = new BindingSource();
          bs.DataSource = data.SelectAll();


          cmb.DataSource = bs;
          cmb.DisplayMember = "HOVATEN";
          cmb.ValueMember = "MANVQL";

      }
       public DataGridViewComboBoxColumn LoadComboBoxColumn()
       {
           DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
           col.DataSource = data.SelectAll();

           col.DisplayMember = "HOVATEN";
           col.ValueMember = "MANVQL";

           col.HeaderText = "Mã NVQL";
           col.Width = 100;
           col.DataPropertyName = "MANVQL";

           return col;
       }
      //internal void timnhanvien(DataGridView dataGridViewKhachHang, BindingNavigator BindingNavigatorKhachHang, DevComponents.DotNetBar.Controls.TextBoxX textBoxTenKhachHang, ComboBox comboBoxphai, ComboBox comboBoxchonphai, ComboBox comboBoxdvct, ComboBox comboBoxchondvct, ComboBox comboBoxtinh, ComboBox comboBoxchontinh, ComboBox comboBoxhuyen, ComboBox comboBoxchonhuyen, ComboBox comboBoxxa, ComboBox comboBoxchonxa)
      //{
      //    //throw new Exception("The method or operation is not implemented.");
      //    BindingSource bs = new BindingSource();
      //    bs.DataSource = data.Find(textBoxTenKhachHang.Text, Convert.ToInt16(comboBoxphai.SelectedValue), comboBoxchonphai.SelectedItem.ToString(), comboBoxdvct.SelectedValue.ToString(), comboBoxchondvct.SelectedItem.ToString(), comboBoxtinh.SelectedValue.ToString(), comboBoxchontinh.SelectedItem.ToString(), comboBoxhuyen.SelectedValue.ToString(), comboBoxchonhuyen.SelectedItem.ToString(), comboBoxxa.SelectedValue.ToString(), comboBoxchonxa.SelectedItem.ToString());

      //    dataGridViewKhachHang.DataSource = bs;
      //    if (dataGridViewKhachHang.RowCount == 1)
      //        MessageBox.Show("Không tìm được Khách hàng theo yêu cầu tìm kiếm của bạn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
      //    BindingNavigatorKhachHang.BindingSource = bs;
      //}
      internal void timnhanvien(DataGridView dgv, BindingNavigator bn, DevComponents.DotNetBar.Controls.TextBoxX txtTenNhanVien, ComboBox cmbPhai, ComboBox cmbChonPhai,DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi, ComboBox cmbChonDiaChi )
      {
          BindingSource bs = new BindingSource();
          bs.DataSource = data.Find(txtTenNhanVien.Text, Convert.ToInt16(cmbPhai.SelectedValue), cmbChonPhai.SelectedItem.ToString(), txtDiaChi.Text, cmbChonDiaChi.SelectedItem.ToString());

          dgv.DataSource = bs;
          if (dgv.RowCount == 0)
                  MessageBox.Show("Không tìm được Nhân viên theo yêu cầu tìm kiếm của bạn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
              bn.BindingSource = bs;
      }
    }
}
