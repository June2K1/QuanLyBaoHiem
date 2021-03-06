using System.Windows.Forms;
namespace QUANLIKH.GiaoDien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (MessageBox.Show("Bạn có muốn thật sự thoát khỏi chương trình không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTĐạiLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉNhậpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mứcPhíBảoHiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyểnSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmĐạiLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmNVQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTôToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêẤnChỉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhCôngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhChứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.thốngKêBáoCáoToolStripMenuItem,
            this.hiểnThịToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.Login;
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.Logout;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.thoat;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tTKháchHàngToolStripMenuItem,
            this.tTĐạiLýToolStripMenuItem,
            this.ấnChỉToolStripMenuItem,
            this.ấnChỉToolStripMenuItem1,
            this.hợpĐồngToolStripMenuItem,
            this.quyểnSốToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // tTKháchHàngToolStripMenuItem
            // 
            this.tTKháchHàngToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.khachhang32x32;
            this.tTKháchHàngToolStripMenuItem.Name = "tTKháchHàngToolStripMenuItem";
            this.tTKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.tTKháchHàngToolStripMenuItem.Text = "Thông Tin Khách Hàng";
            this.tTKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tTĐạiLýToolStripMenuItem
            // 
            this.tTĐạiLýToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.nhacungcap32x32;
            this.tTĐạiLýToolStripMenuItem.Name = "tTĐạiLýToolStripMenuItem";
            this.tTĐạiLýToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.tTĐạiLýToolStripMenuItem.Text = "Thông Tin Đại Lý";
            this.tTĐạiLýToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ấnChỉToolStripMenuItem
            // 
            this.ấnChỉToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcVụToolStripMenuItem});
            this.ấnChỉToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.nhanvienquanly32x32;
            this.ấnChỉToolStripMenuItem.Name = "ấnChỉToolStripMenuItem";
            this.ấnChỉToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.ấnChỉToolStripMenuItem.Text = "Thông Tin Nhân Viên ";
            this.ấnChỉToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.chứcVụToolStripMenuItem.Text = "Chức Vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // ấnChỉToolStripMenuItem1
            // 
            this.ấnChỉToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ấnChỉNhậpToolStripMenuItem1,
            this.ấnChỉXuấtToolStripMenuItem1,
            this.mứcPhíBảoHiểmToolStripMenuItem});
            this.ấnChỉToolStripMenuItem1.Image = global::QUANLIKH.Properties.Resources.anchi;
            this.ấnChỉToolStripMenuItem1.Name = "ấnChỉToolStripMenuItem1";
            this.ấnChỉToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.ấnChỉToolStripMenuItem1.Text = "Ấn Chỉ";
            this.ấnChỉToolStripMenuItem1.Click += new System.EventHandler(this.ấnChỉToolStripMenuItem1_Click);
            // 
            // ấnChỉNhậpToolStripMenuItem1
            // 
            this.ấnChỉNhậpToolStripMenuItem1.Image = global::QUANLIKH.Properties.Resources.xuatachi32;
            this.ấnChỉNhậpToolStripMenuItem1.Name = "ấnChỉNhậpToolStripMenuItem1";
            this.ấnChỉNhậpToolStripMenuItem1.Size = new System.Drawing.Size(215, 26);
            this.ấnChỉNhậpToolStripMenuItem1.Text = "Ấn Chỉ Xuất";
            this.ấnChỉNhậpToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // ấnChỉXuấtToolStripMenuItem1
            // 
            this.ấnChỉXuấtToolStripMenuItem1.Image = global::QUANLIKH.Properties.Resources.thuachi32;
            this.ấnChỉXuấtToolStripMenuItem1.Name = "ấnChỉXuấtToolStripMenuItem1";
            this.ấnChỉXuấtToolStripMenuItem1.Size = new System.Drawing.Size(215, 26);
            this.ấnChỉXuấtToolStripMenuItem1.Text = "Ấn Chỉ Sử Dụng";
            // 
            // mứcPhíBảoHiểmToolStripMenuItem
            // 
            this.mứcPhíBảoHiểmToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.mucbh;
            this.mứcPhíBảoHiểmToolStripMenuItem.Name = "mứcPhíBảoHiểmToolStripMenuItem";
            this.mứcPhíBảoHiểmToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.mứcPhíBảoHiểmToolStripMenuItem.Text = "Mức Phí Bảo Hiểm";
            this.mứcPhíBảoHiểmToolStripMenuItem.Click += new System.EventHandler(this.mứcPhíBảoHiểmToolStripMenuItem_Click);
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.hopdongdaily;
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.hợpĐồngToolStripMenuItem.Text = "Hợp Đồng Đại Lý";
            this.hợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.hợpĐồngToolStripMenuItem_Click);
            // 
            // quyểnSốToolStripMenuItem
            // 
            this.quyểnSốToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.quyenso32;
            this.quyểnSốToolStripMenuItem.Name = "quyểnSốToolStripMenuItem";
            this.quyểnSốToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.quyểnSốToolStripMenuItem.Text = "Quyển Số";
            this.quyểnSốToolStripMenuItem.Click += new System.EventHandler(this.quyểnSốToolStripMenuItem_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmKháchHàngToolStripMenuItem,
            this.tìmKiếmĐạiLýToolStripMenuItem,
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem,
            this.tìmKiếmNVQLToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // tìmKiếmKháchHàngToolStripMenuItem
            // 
            this.tìmKiếmKháchHàngToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.timkiemkh32;
            this.tìmKiếmKháchHàngToolStripMenuItem.Name = "tìmKiếmKháchHàngToolStripMenuItem";
            this.tìmKiếmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.tìmKiếmKháchHàngToolStripMenuItem.Text = "Tìm Kiếm Khách Hàng";
            this.tìmKiếmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.taskItem10_Click);
            // 
            // tìmKiếmĐạiLýToolStripMenuItem
            // 
            this.tìmKiếmĐạiLýToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.timkiemdaily;
            this.tìmKiếmĐạiLýToolStripMenuItem.Name = "tìmKiếmĐạiLýToolStripMenuItem";
            this.tìmKiếmĐạiLýToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.tìmKiếmĐạiLýToolStripMenuItem.Text = "Tìm Kiếm Đại Lý";
            this.tìmKiếmĐạiLýToolStripMenuItem.Click += new System.EventHandler(this.taskItem11_Click);
            // 
            // tìmKiếmHợpĐồngĐạiLýToolStripMenuItem
            // 
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.timkiemmoi;
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem.Name = "tìmKiếmHợpĐồngĐạiLýToolStripMenuItem";
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem.Text = "Tìm Kiếm Hợp Đồng Đại Lý";
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem.Click += new System.EventHandler(this.taskItem13_Click);
            // 
            // tìmKiếmNVQLToolStripMenuItem
            // 
            this.tìmKiếmNVQLToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.timkiemmoi31;
            this.tìmKiếmNVQLToolStripMenuItem.Name = "tìmKiếmNVQLToolStripMenuItem";
            this.tìmKiếmNVQLToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.tìmKiếmNVQLToolStripMenuItem.Text = "Tìm Kiếm Nhân Viên Quản Lý";
            this.tìmKiếmNVQLToolStripMenuItem.Click += new System.EventHandler(this.taskItem4_Click);
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            this.thốngKêBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem,
            this.thốngKêTôToolStripMenuItem,
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem,
            this.thốngKêẤnChỉToolStripMenuItem,
            this.thốngKêNhânViênToolStripMenuItem});
            this.thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            this.thốngKêBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.thốngKêBáoCáoToolStripMenuItem.Text = "Thống Kê - Báo Cáo";
            // 
            // thốngKêDoanhThuĐạiLýToolStripMenuItem
            // 
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.thongkedoanhthu32;
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem.Name = "thốngKêDoanhThuĐạiLýToolStripMenuItem";
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem.Text = "Thống kê Doanh Thu Đại Lý";
            // 
            // thốngKêTôToolStripMenuItem
            // 
            this.thốngKêTôToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.ttkhmuatheodvct32x32;
            this.thốngKêTôToolStripMenuItem.Name = "thốngKêTôToolStripMenuItem";
            this.thốngKêTôToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.thốngKêTôToolStripMenuItem.Text = "Thống Kê Khách Hàng Mua Bảo Hiểm";
            this.thốngKêTôToolStripMenuItem.Click += new System.EventHandler(this.taskItem6_Click);
            // 
            // thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem
            // 
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.hopdonghethan32x32;
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem.Name = "thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem";
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem.Text = "TK Giấy Chứng Nhận Hết Hạn";
            // 
            // thốngKêẤnChỉToolStripMenuItem
            // 
            this.thốngKêẤnChỉToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ấnChỉNhậpToolStripMenuItem,
            this.ấnChỉXuấtToolStripMenuItem,
            this.ấnChỉTồnToolStripMenuItem});
            this.thốngKêẤnChỉToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.anchi32x32;
            this.thốngKêẤnChỉToolStripMenuItem.Name = "thốngKêẤnChỉToolStripMenuItem";
            this.thốngKêẤnChỉToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.thốngKêẤnChỉToolStripMenuItem.Text = "Thống Kê Ấn Chỉ";
            // 
            // ấnChỉNhậpToolStripMenuItem
            // 
            this.ấnChỉNhậpToolStripMenuItem.Name = "ấnChỉNhậpToolStripMenuItem";
            this.ấnChỉNhậpToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.ấnChỉNhậpToolStripMenuItem.Text = "Ấn Chỉ Xuất";
            // 
            // ấnChỉXuấtToolStripMenuItem
            // 
            this.ấnChỉXuấtToolStripMenuItem.Name = "ấnChỉXuấtToolStripMenuItem";
            this.ấnChỉXuấtToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.ấnChỉXuấtToolStripMenuItem.Text = "Ấn Chỉ Sử Dụng";
            // 
            // ấnChỉTồnToolStripMenuItem
            // 
            this.ấnChỉTồnToolStripMenuItem.Name = "ấnChỉTồnToolStripMenuItem";
            this.ấnChỉTồnToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.ấnChỉTồnToolStripMenuItem.Text = "Ấn Chỉ Tồn";
            // 
            // thốngKêNhânViênToolStripMenuItem
            // 
            this.thốngKêNhânViênToolStripMenuItem.Name = "thốngKêNhânViênToolStripMenuItem";
            this.thốngKêNhânViênToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.thốngKêNhânViênToolStripMenuItem.Text = "Thống Kê Nhân Viên";
            this.thốngKêNhânViênToolStripMenuItem.Click += new System.EventHandler(this.taskItem7_Click);
            // 
            // hiểnThịToolStripMenuItem
            // 
            this.hiểnThịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhCôngCụToolStripMenuItem,
            this.thanhChứcNăngToolStripMenuItem});
            this.hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            this.hiểnThịToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.hiểnThịToolStripMenuItem.Text = "Hiển Thị ";
            // 
            // thanhCôngCụToolStripMenuItem
            // 
            this.thanhCôngCụToolStripMenuItem.Name = "thanhCôngCụToolStripMenuItem";
            this.thanhCôngCụToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.thanhCôngCụToolStripMenuItem.Text = "Thanh Công Cụ";
            this.thanhCôngCụToolStripMenuItem.Click += new System.EventHandler(this.thanhCôngCụToolStripMenuItem_Click);
            // 
            // thanhChứcNăngToolStripMenuItem
            // 
            this.thanhChứcNăngToolStripMenuItem.Name = "thanhChứcNăngToolStripMenuItem";
            this.thanhChứcNăngToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.thanhChứcNăngToolStripMenuItem.Text = "Thanh Chức Năng";
            this.thanhChứcNăngToolStripMenuItem.Click += new System.EventHandler(this.thanhChứcNăngToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // herizontalToolStripMenuItem
            // 
            this.herizontalToolStripMenuItem.Name = "herizontalToolStripMenuItem";
            this.herizontalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.herizontalToolStripMenuItem.Text = "Horizontal";
            this.herizontalToolStripMenuItem.Click += new System.EventHandler(this.herizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1206, 59);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Tìm Khách Hàng";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Thistle;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 56);
            this.toolStripButton1.Text = " Khách Hàng";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton4.Image = global::QUANLIKH.Properties.Resources.nhanvienquanly32x32;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(99, 56);
            this.toolStripButton4.Text = "Nhân Viên QL";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton2.Image = global::QUANLIKH.Properties.Resources.nhacungcap32x32;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 56);
            this.toolStripButton2.Text = "TT Đại Lý";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(127, 56);
            this.toolStripButton3.Text = "Hợp Đồng Đại Lý";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.hợpĐồngToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton5.Image = global::QUANLIKH.Properties.Resources.xuatachi32;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(90, 56);
            this.toolStripButton5.Text = "Xuất Ấn Chỉ";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton6.Image = global::QUANLIKH.Properties.Resources.thuachi32;
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(84, 56);
            this.toolStripButton6.Text = "Thu Ấn Chỉ";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton7.Image = global::QUANLIKH.Properties.Resources.timkiemkh32;
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(122, 56);
            this.toolStripButton7.Text = "Tìm Khách Hàng";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.Click += new System.EventHandler(this.taskItem10_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUANLIKH.Properties.Resources.logoVDong;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 788);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "QUẢN LÝ KHÁCH HÀNG MUA BẢO HIỂM";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem tTKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tTĐạiLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmĐạiLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmHợpĐồngĐạiLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuĐạiLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTôToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêẤnChỉToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉTồnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉNhậpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhCôngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhChứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmNVQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private ToolStripMenuItem mứcPhíBảoHiểmToolStripMenuItem;
        private ToolStripMenuItem quyểnSốToolStripMenuItem;
        private ToolStripMenuItem thốngKêNhânViênToolStripMenuItem;
    }
}