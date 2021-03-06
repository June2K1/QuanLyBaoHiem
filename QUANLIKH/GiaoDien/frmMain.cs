using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLIKH.Controller;
using QUANLIKH.Resources;
using QUANLIKH.CrystalReport;

namespace QUANLIKH.GiaoDien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmKhachHang kh = null;
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (kh == null || kh.IsDisposed)
            {
                kh = new frmKhachHang();
                kh.Show();
                kh.MdiParent = this;
                kh.WindowState = FormWindowState.Maximized;
            }
        }
        frmDangNhap DangNhap = new frmDangNhap();
       
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            if (DangNhap.ShowDialog() == DialogResult.OK)
                {


                    String username = DangNhap.txtUserName.Text;
                    String password = DangNhap.txtPassWord.Text;


                    NguoiDungControl Ctrl = new NguoiDungControl();
                    int ketqua = Ctrl.DangNhap(username, password);
                    switch (ketqua)
                    {
                        case 0:
                            MessageBox.Show("Nguoi dung nay ko co trong He thong!");
                            Disable();
                            break;
                        case 1:
                            MessageBox.Show("Sai mat khau!");
                            Disable();
                            break;
                        case 2:

                            PhanQuyen(staticClass.nguoidungStatic.Authorizator);
                            break;
                    }
                }
                else
                {
                    Disable();
                    this.Close();
                }
            staticClass.reLogin = true;
        }

        private void PhanQuyen(int authority)
        {
            switch (authority)
            {
                case 0:// admin authorization
                    EnableAdmin();
                    break;
                case 1:
                    EnableUser();
                    break;
                
                default:
                    break;
            }
        }

        private void EnableAdmin()
        {
            //throw new Exception("The method or operation is not implemented.");
            toolStrip1.Enabled = true;
           // thanhCToolStripMenuItem.Enabled = true;
            thanhCôngCụToolStripMenuItem.Enabled = true;
            
            foreach (ToolStripMenuItem menu in menuStrip1.Items)
            {
                menu.Enabled = true;
            }
            menuStrip1.Items[0].Enabled = true;
            foreach (ToolStripItem toolstrip in toolStrip1.Items)
            {
                toolstrip.Enabled = true;
            }
            foreach(ToolStripMenuItem mnuitem in hệThốngToolStripMenuItem.DropDownItems)
            //foreach (ToolStripMenuItem mnuitem in mnuHeThongToolStripMenuItem.DropDownItems)
            {
                mnuitem.Enabled = true;
            }
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
            thoátToolStripMenuItem.Enabled = true;
            
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.IsDisposed || frm == null) ;
                else frm.Dispose();
            }
            expandoBaoCao.Enabled = true;
            expandoNghiepVu.Enabled = true;
            expandoQuanLy.Enabled = true;
        }

        private void EnableUser()
        {
            toolStrip1.Enabled = true;
            thanhCôngCụToolStripMenuItem.Enabled = true;
            foreach (ToolStripMenuItem menu in menuStrip1.Items)
            {
                menu.Enabled = true;
            }
            menuStrip1.Items[0].Enabled = true;
            int t=0;
            foreach (ToolStripItem toolstrip in toolStrip1.Items)
            {
               
                if( (t>=1) && (t<=5))
                    toolstrip.Enabled = false;
                else toolstrip.Enabled = true;
                t++;
            }

            foreach (ToolStripMenuItem mnuitem in hệThốngToolStripMenuItem.DropDownItems)
            {
                mnuitem.Enabled = true;
            }
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
            thoátToolStripMenuItem.Enabled = true;
            quảnLýToolStripMenuItem.Enabled = false;
            expandoBaoCao.Enabled = true;
            expandoQuanLy.Enabled = false;
            expandoNghiepVu.Enabled = true;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.IsDisposed || frm == null) ;
                else frm.Dispose();
            }
        }

        private void Disable()
        {
            foreach (ToolStripMenuItem menu in menuStrip1.Items)
            {
                menu.Enabled = false;
            }
            menuStrip1.Items[0].Enabled = true;
            foreach (ToolStripItem toolstrip in toolStrip1.Items)
            {
                toolstrip.Enabled = false;
            }
            foreach (ToolStripMenuItem mnuitem in hệThốngToolStripMenuItem.DropDownItems)
            {
                mnuitem.Enabled = false;
            }

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.IsDisposed || frm == null) ;
                else frm.Dispose();
            }
            toolStrip1.Enabled = false;
            thanhCôngCụToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            thoátToolStripMenuItem.Enabled = true;
            expandoQuanLy.Enabled = false;
            expandoNghiepVu.Enabled = false;
            expandoBaoCao.Enabled = false;
        }
        
        frmNhanVien nhanvien = null ;
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (nhanvien == null || nhanvien.IsDisposed)
            {
                nhanvien = new frmNhanVien();
                nhanvien.Show();
                nhanvien.MdiParent = this;
                nhanvien.WindowState = FormWindowState.Maximized;
            }
        }

        private void thanhCôngCụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thanhCôngCụToolStripMenuItem.Checked == true)
            {
                toolStrip1.Visible = false;
                thanhCôngCụToolStripMenuItem.Checked = false;
            }
            else
            {
                toolStrip1.Visible = true;
                thanhCôngCụToolStripMenuItem.Checked = true;
            }
            
        }

        private void thanhChứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thanhChứcNăngToolStripMenuItem.Checked == true)
            {
                taskPane1.Visible = false;
                thanhChứcNăngToolStripMenuItem.Checked = false;
            }
            else
            {
                taskPane1.Visible = true;
                thanhChứcNăngToolStripMenuItem.Checked = true;
            }
        }

        private void herizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        frmDaiLy dl = null;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dl == null || dl.IsDisposed)
            {
                dl = new frmDaiLy();
                dl.Show();
                dl.MdiParent = this;
                dl.WindowState = FormWindowState.Maximized;
            }
        }
        frmAnChiXuat xanchi = null;
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (xanchi == null || xanchi.IsDisposed)
            {
                xanchi = new frmAnChiXuat ();
                xanchi.Show();
                xanchi.MdiParent = this;
                xanchi.WindowState = FormWindowState.Maximized;
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap DangNhap = new frmDangNhap();
            if (DangNhap.ShowDialog() == DialogResult.OK)
            {
                String username = DangNhap.txtUserName.Text;
                String password = DangNhap.txtPassWord.Text;
                NguoiDungControl Ctrl = new NguoiDungControl();
                int ketqua = Ctrl.DangNhap(username, password);
                switch (ketqua)
                {
                    case 0:
                        MessageBox.Show("Nguoi dung nay ko co trong He thong!");
                        Disable();
                        break;
                    case 1:
                        MessageBox.Show("Sai mat khau!");
                        Disable();
                        break;
                    case 2:

                        PhanQuyen(staticClass.nguoidungStatic.Authorizator);
                        break;
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disable();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        frmHopDongDaiLy hd = null;
        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hd == null || hd.IsDisposed)
            {
                hd = new frmHopDongDaiLy ();
                hd.Show();
                hd.MdiParent = this;
                hd.WindowState = FormWindowState.Maximized;
            }
        }
        frmThuAnChi thu = null;
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (thu == null || thu.IsDisposed)
            {
                thu = new frmThuAnChi ();
                thu.Show();
                thu.MdiParent = this;
                thu.WindowState = FormWindowState.Maximized;
            }
        }
        frmTimKiemHopDongDaiLy timhd = null;
        private void taskItem13_Click(object sender, EventArgs e)
        {
            if (timhd == null || timhd.IsDisposed)
            {
                timhd = new frmTimKiemHopDongDaiLy();
                timhd.Show();
                timhd.MdiParent = this;
                timhd.WindowState = FormWindowState.Maximized;
            }
        }
        frmTimKiemKhachHang timkh = null ;
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (timkh == null || timkh.IsDisposed)
            {
                timkh = new frmTimKiemKhachHang();
                timkh.Show();
                timkh.MdiParent = this;
                timkh.WindowState = FormWindowState.Maximized;
            }
        }
        frmTimDaiLy timdl = null;
        private void taskItem11_Click(object sender, EventArgs e)
        {
            if (timdl == null || timdl.IsDisposed)
            {
                timdl = new frmTimDaiLy();
                timdl.Show();
                timdl.MdiParent = this;
                timdl.WindowState = FormWindowState.Maximized;
            }
        }
        frmTimKiemKhachHang kiemkh = null;
        private void taskItem10_Click(object sender, EventArgs e)
        {
            if (kiemkh == null || kiemkh.IsDisposed)
            {
                kiemkh = new frmTimKiemKhachHang();
                kiemkh.Show();
                kiemkh.MdiParent = this;
                kiemkh.WindowState = FormWindowState.Maximized;
            }
        }
        frmTimKiemNhanVien timnv = null;
        private void taskItem4_Click(object sender, EventArgs e)
        {
            if (timnv == null || timnv.IsDisposed)
            {
                timnv = new frmTimKiemNhanVien();
                timnv.Show();
                timnv.MdiParent = this;
                timnv.WindowState = FormWindowState.Maximized;
            }
        }
        frChucVu cvctrl = null;
        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cvctrl == null || cvctrl.IsDisposed)
            {
                cvctrl = new frChucVu();
                cvctrl.Show();
                cvctrl.MdiParent = this;
                cvctrl.WindowState = FormWindowState.Maximized;
            }
        }
        frmMucBaoHiem mucctrl = null;
        private void mứcPhíBảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mucctrl == null || mucctrl.IsDisposed)
            {
                mucctrl = new frmMucBaoHiem();
                mucctrl.Show();
                mucctrl.MdiParent = this;
                mucctrl.WindowState = FormWindowState.Maximized;
            }
        }
        frmQuyenSo qs = null;
        private void quyểnSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (qs == null || qs.IsDisposed)
            {
                qs = new frmQuyenSo();
                qs.Show();
                qs.MdiParent = this;
                qs.WindowState = FormWindowState.Maximized;
            }
        }
        //rpt_NhanVien_CrystalReport nhanvienrpt = null;
        frm_rpt_NhanVien nhanvienrpt = null;
        private void taskItem7_Click(object sender, EventArgs e)
        {
            if (nhanvienrpt == null || nhanvienrpt.IsDisposed)
            {
                nhanvienrpt = new frm_rpt_NhanVien();
                nhanvienrpt.Show();
                // tktheotinh.MdiParent = this;
                nhanvienrpt.WindowState = FormWindowState.Maximized;
            }
        }

        private void lậpGiấyChứngNhậnBHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        frm_rpt_KhachHang rptkh = null;
        private void taskItem6_Click(object sender, EventArgs e)
        {
            if (rptkh == null || rptkh.IsDisposed)
            {
                rptkh = new frm_rpt_KhachHang();
                rptkh.Show();
                // tktheotinh.MdiParent = this;
                rptkh.WindowState = FormWindowState.Maximized;
            }
        }
        frmGiayChungNhanBaoHiem anchictrl = null;
        private void ấnChỉToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (anchictrl == null || anchictrl.IsDisposed)
            {
                anchictrl = new frmGiayChungNhanBaoHiem();
                anchictrl.Show();
                anchictrl.MdiParent = this;
                anchictrl.WindowState = FormWindowState.Maximized;
            }
        }

        //private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    MessageBox.Show("Bạn có chắc chắn thoát khỏi chương trình này không");
        //}


       
        
              
     

     

   

        
    }
}