using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.BusinessObject;
using System.Data;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QUANLIKH.Data;

namespace QUANLIKH.Controller
{
    public class TinhTrangGiayChungNhanControl
    {
        TinhTrangGiayChungNhanData data = new TinhTrangGiayChungNhanData();
        public void HienThi(DataGridViewX dgv, BindingNavigator bn, TextBox txtMaTinhTrang, TextBox txtTenTinhTrang)
        {
            /* BindingSource bs = new BindingSource();
           bs.DataSource = data.SelectAll();

           //dâtgridview va bindingNaviagtor
           dgv.DataSource = bs;
           bn.BindingSource = bs;

           txtMaKhachHang.DataBindings.Clear();
           txtMaKhachHang.DataBindings.Add("Text", bs, "MAKH");*/
            BindingSource bs = new BindingSource();
            bs.DataSource = data.SelectAll();

            dgv.DataSource = bs;
            bn.BindingSource = bs;

            txtMaTinhTrang.DataBindings.Clear();
            txtMaTinhTrang.DataBindings.Add("Text", bs, "MATINHTRANG");

            txtTenTinhTrang.DataBindings.Clear();
            txtTenTinhTrang.DataBindings.Add("Text", bs, "TENTINHTRANG");
        }


        public DataGridViewComboBoxColumn LoadComboBoxColumn()
        {
            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
             col.DataSource = data.SelectAll();

            col.DisplayMember = "TENTINHTRANG";
            col.ValueMember = "MATINHTRANG";

            col.HeaderText = "Mã Tình Trạng";
            col.Width = 100;
            col.DataPropertyName = "MATINHTRANG";

            return col;
        }
        internal void HienThiLenComboBox(ComboBoxEx cmb)
        {
            BindingSource bs = new BindingSource();
            //bs.DataSource = data.SelectAll();
            bs.DataSource = data.SelectAll();
            cmb.DataSource = bs;
            cmb.DisplayMember = "TENTINHTRANG";
            cmb.ValueMember = "MATINHTRANG";
        }
        public void CapNhat()
        {
            data.Update();
        }
    }
}
