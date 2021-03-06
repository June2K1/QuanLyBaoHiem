using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.Data;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace QUANLIKH.Controller
{
    public class ChiTietGiayChungNhanControl
    {
        
        ChiTietGiayChungNhanData data = new ChiTietGiayChungNhanData();
        public void HienThi(CheckBox checkbox1,DataGridViewX dgv, BindingNavigator bn, TextBox txtSoSeri, ComboBox cmbMaKhachHang, DateTimePicker dtNgayCap, ComboBox cmbMaQuyen, DateTimePicker dtNgayBatDau, DateTimePicker dtNgayHetHan, ComboBox cmbMaTinhTrang, TextBox txtLyDoHuy, DateTimePicker dtNgayHuy, TextBox txtThueVat,TextBox txtChuaThue,TextBox txtThanhToan)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.SelectAll();

            dgv.DataSource = bs;
            bn.BindingSource = bs;

            txtSoSeri.DataBindings.Clear();
            txtSoSeri.DataBindings.Add("Text", bs, "SOSERI");
            try
            {
                checkbox1.DataBindings.Clear();
                checkbox1.DataBindings.Add("Checked", bs, "MUCTNNN");
            }
            catch 
            {
                Exception();
            }
            


            cmbMaKhachHang.DataBindings.Clear();
            cmbMaKhachHang.DataBindings.Add("SelectedValue", bs, "MAKH");

            dtNgayCap.DataBindings.Clear();
            dtNgayCap.DataBindings.Add("Text", bs, "NGAYCAP");

            cmbMaQuyen.DataBindings.Clear();
            cmbMaQuyen.DataBindings.Add("SelectedValue", bs, "MAQUYEN");

            dtNgayBatDau.DataBindings.Clear();
            dtNgayBatDau.DataBindings.Add("Text", bs, "NGAYBATDAU");

            dtNgayHetHan.DataBindings.Clear();
            dtNgayHetHan.DataBindings.Add("Text", bs, "NGAYHETHAN");

            cmbMaTinhTrang.DataBindings.Clear();
            cmbMaTinhTrang.DataBindings.Add("SelectedValue", bs, "MATINHTRANG");

            txtLyDoHuy.DataBindings.Clear();
            txtLyDoHuy.DataBindings.Add("Text", bs, "LYDOHUY");

            dtNgayHuy.DataBindings.Clear();
            dtNgayHuy.DataBindings.Add("Text", bs, "NGAYHUY");

            txtThueVat.DataBindings.Clear();
            txtThueVat.DataBindings.Add("Text", bs, "THUEVAT");

            txtChuaThue.DataBindings.Clear();
            txtChuaThue.DataBindings.Add("Text", bs, "CHUATHUE");

            txtThanhToan.DataBindings.Clear();
            txtThanhToan.DataBindings.Add("Text", bs, "THANHTOAN");

            //remove va add tinh trang giay chung nhan
             dgv.Columns.Remove("MATINHTRANG");

             TinhTrangGiayChungNhanControl ttctrl = new TinhTrangGiayChungNhanControl();
             DataGridViewComboBoxColumn ttcol = ttctrl.LoadComboBoxColumn();
             ttcol.DataPropertyName = "MATINHTRANG";
           dgv.Columns.Add(ttcol);

           //remove va add phi bao hiem
           dgv.Columns.Remove("MALOAITNDS");

           MucBaoHiemControl TNDSCTRL = new MucBaoHiemControl();
           DataGridViewComboBoxColumn TNDScol = TNDSCTRL.LoadComboBoxColumn();
           TNDScol.DataPropertyName = "MALOAI";
           dgv.Columns.Add(TNDScol);

           //remove va add phi bao hiem
           dgv.Columns.Remove("MALOAITNNN");

           MucBaoHiemControl TNNNCTRL = new MucBaoHiemControl();
           DataGridViewComboBoxColumn TNNNcol = TNNNCTRL.LoadComboBoxColumn();
           TNNNcol.DataPropertyName = "MALOAI";
           dgv.Columns.Add(TNNNcol);


           //remove va add khach hang
           dgv.Columns.Remove("MAKH");

           KhachHangControl khctrl = new KhachHangControl();
           DataGridViewComboBoxColumn khcol = khctrl.LoadComboBoxColumn();
           khcol.DataPropertyName = "MAKH";
           dgv.Columns.Add(khcol);

        }

        private void Exception()
        {
           // throw new Exception("The method or operation is not implemented.");
        }
        

        public void HienThiTheoQuyen(DataGridViewX dgv, BindingNavigator bn, ComboBox cmbMaQuyen)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.SelectAnChiXuat(cmbMaQuyen.SelectedValue.ToString());

            dgv.DataSource = bs;
            bn.BindingSource = bs;
            dgv.Columns.Remove("MATINHTRANG");
            
            TinhTrangGiayChungNhanControl tinhtrangctrl = new TinhTrangGiayChungNhanControl();
            DataGridViewComboBoxColumn tinhtrangcol = tinhtrangctrl.LoadComboBoxColumn();
            tinhtrangcol.DataPropertyName = "MATINHTRANG";
            tinhtrangcol.Name = "MATINHTRANG";
            dgv.Columns.Add(tinhtrangcol);
        }

            //txtSoSeri.DataBindings.Clear();
            //txtSoSeri.DataBindings.Add("Text", bs, "SOSERI");

                   
        // public void HienThiTheoQuyen(DataGridViewX dgv, BindingNavigator bn, ComboBox cmbMaQuyen)
        //{
        //    BindingSource bs = new BindingSource();
        //    bs.DataSource = data.SelectThuAnChi(cmbMaQuyen.SelectedValue.ToString());

        //    dgv.DataSource = bs;
        //    bn.BindingSource = bs;               

        public void HienThiChonTheoQuyen(DataGridViewX dgv, BindingNavigator bn, ComboBox cmbChonMaQuyen)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.SelectThuAnChi(cmbChonMaQuyen.SelectedValue.ToString());

            dgv.DataSource = bs;
            bn.BindingSource = bs;              
                     

        }
        
        
        public void CapNhat()
        {
            data.Update();
        }

        /* internal void HienThiLenDGVTheoThang(System.Windows.Forms.DataGridView dgvLuong,BindingNavigator bnLuong ,System.Windows.Forms.ComboBox cbChonThang)
            {
                //throw new Exception("The method or operation is not implemented.");
                LuongData ldata = new LuongData();
                BindingSource bs = new BindingSource();
                bs.DataSource = ldata.LayDsLuongTheoThang(Convert.ToInt16(cbChonThang.Text));
                dgvLuong.DataSource = bs;
                bnLuong.BindingSource = bs;
            }*/
        /*  internal void HienTongThuNhapTheoThangLenDGV(DataGridView dgvChiTietThuNhap, BindingNavigator bnChiTietThuNhap, ComboBox cbChonThang)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = giaodichdata.LayDsGiaoDichTheoThang(cbChonThang.Text);
            bnChiTietThuNhap.BindingSource = bs;
            dgvChiTietThuNhap.DataSource = bs;

        }*/
        internal void HienThiChuaThueLendgv(DataGridView dgv, BindingNavigator bn, TextBox txtChuaThue)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayChuaThue(txtChuaThue.Text);
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
    }
}
