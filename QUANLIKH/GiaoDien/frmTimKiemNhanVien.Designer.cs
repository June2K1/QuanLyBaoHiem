namespace QUANLIKH.GiaoDien
{
    partial class frmTimKiemNhanVien
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemNhanVien));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbChonDiaChi = new System.Windows.Forms.ComboBox();
            this.txtTenNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttontimkh = new DevComponents.DotNetBar.ButtonX();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            this.cmbChonPhai = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MANVQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOVATEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new QUANLIKH.Librarý.DataGridViewCalendarColumn();
            this.PHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGANHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.Luu = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtDiaChi);
            this.splitContainer1.Panel1.Controls.Add(this.cmbChonDiaChi);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.buttontimkh);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPhai);
            this.splitContainer1.Panel1.Controls.Add(this.cmbChonPhai);
            this.splitContainer1.Panel1.Controls.Add(this.labelX3);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Panel2.Controls.Add(this.bn);
            this.splitContainer1.Size = new System.Drawing.Size(792, 513);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Location = new System.Drawing.Point(523, 131);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(134, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // cmbChonDiaChi
            // 
            this.cmbChonDiaChi.FormattingEnabled = true;
            this.cmbChonDiaChi.Items.AddRange(new object[] {
            "NONE",
            "AND",
            "OR",
            "AND NOT",
            "OR NOT"});
            this.cmbChonDiaChi.Location = new System.Drawing.Point(462, 131);
            this.cmbChonDiaChi.Name = "cmbChonDiaChi";
            this.cmbChonDiaChi.Size = new System.Drawing.Size(55, 21);
            this.cmbChonDiaChi.TabIndex = 4;
            this.cmbChonDiaChi.SelectedIndexChanged += new System.EventHandler(this.cmbChonDiaChi_SelectedIndexChanged);
            // 
            // txtTenNhanVien
            // 
            // 
            // 
            // 
            this.txtTenNhanVien.Border.Class = "TextBoxBorder";
            this.txtTenNhanVien.Location = new System.Drawing.Point(330, 86);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(147, 20);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // buttontimkh
            // 
            this.buttontimkh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttontimkh.Checked = true;
            this.buttontimkh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttontimkh.Image = global::QUANLIKH.Properties.Resources.find;
            this.buttontimkh.Location = new System.Drawing.Point(583, 58);
            this.buttontimkh.Name = "buttontimkh";
            this.buttontimkh.Size = new System.Drawing.Size(74, 51);
            this.buttontimkh.TabIndex = 50;
            this.buttontimkh.Text = " ";
            this.buttontimkh.Click += new System.EventHandler(this.buttontimkh_Click);
            // 
            // cmbPhai
            // 
            this.cmbPhai.FormattingEnabled = true;
            this.cmbPhai.Location = new System.Drawing.Point(213, 128);
            this.cmbPhai.Name = "cmbPhai";
            this.cmbPhai.Size = new System.Drawing.Size(146, 21);
            this.cmbPhai.TabIndex = 3;
            // 
            // cmbChonPhai
            // 
            this.cmbChonPhai.FormattingEnabled = true;
            this.cmbChonPhai.Items.AddRange(new object[] {
            "NONE",
            "AND",
            "OR",
            "AND NOT",
            "OR NOT"});
            this.cmbChonPhai.Location = new System.Drawing.Point(152, 128);
            this.cmbChonPhai.Name = "cmbChonPhai";
            this.cmbChonPhai.Size = new System.Drawing.Size(55, 21);
            this.cmbChonPhai.TabIndex = 2;
            this.cmbChonPhai.SelectedIndexChanged += new System.EventHandler(this.cmbChonPhai_SelectedIndexChanged);
            // 
            // labelX3
            // 
            this.labelX3.ForeColor = System.Drawing.Color.Blue;
            this.labelX3.Location = new System.Drawing.Point(409, 129);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(47, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Địa Chỉ";
            // 
            // labelX2
            // 
            this.labelX2.ForeColor = System.Drawing.Color.Blue;
            this.labelX2.Location = new System.Drawing.Point(112, 128);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(34, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Phái";
            // 
            // labelX1
            // 
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(250, 86);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Họ Và Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(246, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM NHÂN VIÊN QUẢN LÝ";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANVQL,
            this.HOVATEN,
            this.NGAYSINH,
            this.PHAI,
            this.CMND,
            this.DIACHI,
            this.DIENTHOAI,
            this.FAX,
            this.TAIKHOAN,
            this.NGANHANG,
            this.MACHUCVU});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 52);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(792, 285);
            this.dgv.TabIndex = 7;
            // 
            // MANVQL
            // 
            this.MANVQL.DataPropertyName = "MANVQL";
            this.MANVQL.HeaderText = "Mã NVQL";
            this.MANVQL.Name = "MANVQL";
            // 
            // HOVATEN
            // 
            this.HOVATEN.DataPropertyName = "HOVATEN";
            this.HOVATEN.HeaderText = "Họ và Tên";
            this.HOVATEN.Name = "HOVATEN";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NGAYSINH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PHAI
            // 
            this.PHAI.DataPropertyName = "PHAI";
            this.PHAI.HeaderText = "Phái";
            this.PHAI.Name = "PHAI";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "Số CMND";
            this.CMND.Name = "CMND";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện Thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // FAX
            // 
            this.FAX.DataPropertyName = "FAX";
            this.FAX.HeaderText = "Fax";
            this.FAX.Name = "FAX";
            // 
            // TAIKHOAN
            // 
            this.TAIKHOAN.DataPropertyName = "TAIKHOAN";
            this.TAIKHOAN.HeaderText = "Tài Khoản";
            this.TAIKHOAN.Name = "TAIKHOAN";
            // 
            // NGANHANG
            // 
            this.NGANHANG.DataPropertyName = "NGANHANG";
            this.NGANHANG.HeaderText = "Ngân Hàng";
            this.NGANHANG.Name = "NGANHANG";
            // 
            // MACHUCVU
            // 
            this.MACHUCVU.DataPropertyName = "MACHUCVU";
            this.MACHUCVU.HeaderText = "Mã Chức Vụ";
            this.MACHUCVU.Name = "MACHUCVU";
            // 
            // bn
            // 
            this.bn.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.DeleteItem = null;
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.Luu});
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(792, 52);
            this.bn.TabIndex = 6;
            this.bn.Text = "bindingNavigatorKhachHang";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.Blue;
            this.bindingNavigatorAddNewItem.Image = global::QUANLIKH.Properties.Resources.themmoi32x321;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(37, 49);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 49);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 49);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 49);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 49);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 49);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.Blue;
            this.bindingNavigatorDeleteItem.Image = global::QUANLIKH.Properties.Resources._53;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 49);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Luu
            // 
            this.Luu.ForeColor = System.Drawing.Color.Blue;
            this.Luu.Image = global::QUANLIKH.Properties.Resources.Save;
            this.Luu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(36, 49);
            this.Luu.Text = "Lưu";
            this.Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmTimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 513);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTimKiemNhanVien";
            this.Text = "frmTimKiemNhanVien";
            this.Load += new System.EventHandler(this.frmTimKiemNhanVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton Luu;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANVQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOVATEN;
        private QUANLIKH.Librarý.DataGridViewCalendarColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGANHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACHUCVU;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX buttontimkh;
        private System.Windows.Forms.ComboBox cmbPhai;
        private System.Windows.Forms.ComboBox cmbChonPhai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNhanVien;
        private System.Windows.Forms.ComboBox cmbChonDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
    }
}