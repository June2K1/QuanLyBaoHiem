using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.Data;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace QUANLIKH.Controller
{
    public   class ChucVuControl
    {
        ChucVuData data = new ChucVuData();
        public void Hienthi(DataGridViewX dgv, BindingNavigator bn, TextBox txtMaChucVu, TextBox txtTenChucVu)
        {
            
            BindingSource bs = new BindingSource();
            bs.DataSource = data.SelectAll();

            dgv.DataSource = bs;
            bn.BindingSource = bs;

            txtMaChucVu.DataBindings.Clear();
            txtMaChucVu.DataBindings.Add("Text", bs, "MACHUCVU");

            txtTenChucVu.DataBindings.Clear();
            txtTenChucVu.DataBindings.Add("Text", bs, "TENCHUCVU");
        }
        public void HienThiLenComboBox(ComboBox cmb)
        {
            //moc du lieu
            BindingSource bs = new BindingSource();
            bs.DataSource = data.SelectAll();


            cmb.DataSource = bs;
            cmb.DisplayMember = "TENCHUCVU";
            cmb.ValueMember = "MACHUCVU";

        }
        public DataGridViewComboBoxColumn LoadComboBoxColumn()
        {
            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.DataSource = data.SelectAll();

            col.DisplayMember = "TENCHUCVU";
            col.ValueMember = "MACHUCVU";

            col.HeaderText = "Chức Vụ";
            col.Width = 100;
            col.DataPropertyName = "MACHUCVU";

            return col;
        }
        public void CapNhat()
        {
            data.Update();
        }
      
    }
}
