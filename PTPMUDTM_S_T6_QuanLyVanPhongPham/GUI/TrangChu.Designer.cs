namespace QuanLyVPP1.GUI
{
    partial class fWorkSpace
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
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbHoaDon = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayVao = new System.Windows.Forms.DateTimePicker();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numGiamGia = new System.Windows.Forms.NumericUpDown();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDonHang = new System.Windows.Forms.GroupBox();
            this.flpHDKhachHang = new System.Windows.Forms.FlowLayoutPanel();
            this.thốngKêBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHÂNSỰToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kHOHÀNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHÂNVIÊNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỆTHỐNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numSoluongHH = new System.Windows.Forms.NumericUpDown();
            this.btnThemCus = new System.Windows.Forms.Button();
            this.cmbCatelory = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grbHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).BeginInit();
            this.grbDonHang.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluongHH)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            this.columnHeader3.Width = 59;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(9, 97);
            this.lsvHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(583, 327);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Hàng";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ĐV Tính";
            this.columnHeader2.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn Giá";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành Tiền";
            this.columnHeader5.Width = 67;
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.label6);
            this.grbHoaDon.Controls.Add(this.txbMaHD);
            this.grbHoaDon.Controls.Add(this.label5);
            this.grbHoaDon.Controls.Add(this.label4);
            this.grbHoaDon.Controls.Add(this.txbNhanVien);
            this.grbHoaDon.Controls.Add(this.label3);
            this.grbHoaDon.Controls.Add(this.dtpNgayVao);
            this.grbHoaDon.Controls.Add(this.btnThanhToan);
            this.grbHoaDon.Controls.Add(this.label2);
            this.grbHoaDon.Controls.Add(this.numGiamGia);
            this.grbHoaDon.Controls.Add(this.txbTotalPrice);
            this.grbHoaDon.Controls.Add(this.label1);
            this.grbHoaDon.Controls.Add(this.lsvHoaDon);
            this.grbHoaDon.Location = new System.Drawing.Point(488, 63);
            this.grbHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbHoaDon.Name = "grbHoaDon";
            this.grbHoaDon.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbHoaDon.Size = new System.Drawing.Size(603, 588);
            this.grbHoaDon.TabIndex = 5;
            this.grbHoaDon.TabStop = false;
            this.grbHoaDon.Text = "Hóa Đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 477);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "(%)";
            // 
            // txbMaHD
            // 
            this.txbMaHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbMaHD.Location = new System.Drawing.Point(450, 18);
            this.txbMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.ReadOnly = true;
            this.txbMaHD.Size = new System.Drawing.Size(62, 26);
            this.txbMaHD.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mã HD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nhân Viên:";
            // 
            // txbNhanVien
            // 
            this.txbNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbNhanVien.Location = new System.Drawing.Point(138, 55);
            this.txbNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNhanVien.Name = "txbNhanVien";
            this.txbNhanVien.ReadOnly = true;
            this.txbNhanVien.Size = new System.Drawing.Size(174, 26);
            this.txbNhanVien.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày Mở HĐ:";
            // 
            // dtpNgayVao
            // 
            this.dtpNgayVao.Enabled = false;
            this.dtpNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVao.Location = new System.Drawing.Point(450, 57);
            this.dtpNgayVao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayVao.Name = "dtpNgayVao";
            this.dtpNgayVao.Size = new System.Drawing.Size(126, 26);
            this.dtpNgayVao.TabIndex = 14;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(416, 477);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(162, 82);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Giảm Giá:";
            this.label2.Click += new System.EventHandler(this.cậpNhậtSảnPhẩmToolStripMenuItem_Click);
            // 
            // numGiamGia
            // 
            this.numGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGiamGia.Location = new System.Drawing.Point(189, 471);
            this.numGiamGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numGiamGia.Name = "numGiamGia";
            this.numGiamGia.Size = new System.Drawing.Size(126, 30);
            this.numGiamGia.TabIndex = 11;
            this.numGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(189, 514);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(168, 30);
            this.txbTotalPrice.TabIndex = 2;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 523);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng Tiền:";
            // 
            // grbDonHang
            // 
            this.grbDonHang.Controls.Add(this.flpHDKhachHang);
            this.grbDonHang.Location = new System.Drawing.Point(18, 63);
            this.grbDonHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDonHang.Name = "grbDonHang";
            this.grbDonHang.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDonHang.Size = new System.Drawing.Size(460, 588);
            this.grbDonHang.TabIndex = 4;
            this.grbDonHang.TabStop = false;
            this.grbDonHang.Text = "Đơn Hàng";
            // 
            // flpHDKhachHang
            // 
            this.flpHDKhachHang.Location = new System.Drawing.Point(9, 29);
            this.flpHDKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpHDKhachHang.Name = "flpHDKhachHang";
            this.flpHDKhachHang.Size = new System.Drawing.Size(436, 528);
            this.flpHDKhachHang.TabIndex = 0;
            // 
            // thốngKêBánHàngToolStripMenuItem
            // 
            this.thốngKêBánHàngToolStripMenuItem.Name = "thốngKêBánHàngToolStripMenuItem";
            this.thốngKêBánHàngToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.thốngKêBánHàngToolStripMenuItem.Text = "Thống Kê Bán Hàng";
            this.thốngKêBánHàngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêBánHàngToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // nHÂNSỰToolStripMenuItem
            // 
            this.nHÂNSỰToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.thốngKêBánHàngToolStripMenuItem});
            this.nHÂNSỰToolStripMenuItem.Name = "nHÂNSỰToolStripMenuItem";
            this.nHÂNSỰToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.nHÂNSỰToolStripMenuItem.Text = "QUẢN TRỊ";
            // 
            // tồnKhoToolStripMenuItem
            // 
            this.tồnKhoToolStripMenuItem.Name = "tồnKhoToolStripMenuItem";
            this.tồnKhoToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.tồnKhoToolStripMenuItem.Text = "Quản Lý Kho Hàng";
            this.tồnKhoToolStripMenuItem.Click += new System.EventHandler(this.tồnKhoToolStripMenuItem_Click);
            // 
            // kHOHÀNGToolStripMenuItem
            // 
            this.kHOHÀNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtSảnPhẩmToolStripMenuItem,
            this.tồnKhoToolStripMenuItem});
            this.kHOHÀNGToolStripMenuItem.Name = "kHOHÀNGToolStripMenuItem";
            this.kHOHÀNGToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.kHOHÀNGToolStripMenuItem.Text = "KHO HÀNG";
            // 
            // cậpNhậtSảnPhẩmToolStripMenuItem
            // 
            this.cậpNhậtSảnPhẩmToolStripMenuItem.Name = "cậpNhậtSảnPhẩmToolStripMenuItem";
            this.cậpNhậtSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.cậpNhậtSảnPhẩmToolStripMenuItem.Text = "Cập Nhật Sản Phẩm";
            this.cậpNhậtSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtSảnPhẩmToolStripMenuItem_Click);
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.thôngTinNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // nHÂNVIÊNToolStripMenuItem
            // 
            this.nHÂNVIÊNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhânViênToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.nHÂNVIÊNToolStripMenuItem.Name = "nHÂNVIÊNToolStripMenuItem";
            this.nHÂNVIÊNToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.nHÂNVIÊNToolStripMenuItem.Text = "NHÂN VIÊN";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // hỆTHỐNGToolStripMenuItem
            // 
            this.hỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.hỆTHỐNGToolStripMenuItem.Name = "hỆTHỐNGToolStripMenuItem";
            this.hỆTHỐNGToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.hỆTHỐNGToolStripMenuItem.Text = "TÀI KHOẢN";
            // 
            // thongToolStripMenuItem
            // 
            this.thongToolStripMenuItem.Name = "thongToolStripMenuItem";
            this.thongToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.thongToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            this.thongToolStripMenuItem.Click += new System.EventHandler(this.thongToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hỆTHỐNGToolStripMenuItem,
            this.nHÂNVIÊNToolStripMenuItem,
            this.kHOHÀNGToolStripMenuItem,
            this.nHÂNSỰToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1498, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Trợ Giúp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.numSoluongHH);
            this.panel1.Controls.Add(this.btnThemCus);
            this.panel1.Location = new System.Drawing.Point(1100, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 529);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(28, 335);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 111);
            this.panel2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(4, 5);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 204);
            this.listBox1.TabIndex = 1;
            // 
            // numSoluongHH
            // 
            this.numSoluongHH.Location = new System.Drawing.Point(4, 282);
            this.numSoluongHH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSoluongHH.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numSoluongHH.Name = "numSoluongHH";
            this.numSoluongHH.Size = new System.Drawing.Size(126, 26);
            this.numSoluongHH.TabIndex = 9;
            this.numSoluongHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThemCus
            // 
            this.btnThemCus.Location = new System.Drawing.Point(4, 228);
            this.btnThemCus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemCus.Name = "btnThemCus";
            this.btnThemCus.Size = new System.Drawing.Size(126, 45);
            this.btnThemCus.TabIndex = 8;
            this.btnThemCus.Text = "Thêm - Bớt";
            this.btnThemCus.UseVisualStyleBackColor = true;
            this.btnThemCus.Click += new System.EventHandler(this.btnThemCus_Click);
            // 
            // cmbCatelory
            // 
            this.cmbCatelory.FormattingEnabled = true;
            this.cmbCatelory.Location = new System.Drawing.Point(1104, 80);
            this.cmbCatelory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCatelory.Name = "cmbCatelory";
            this.cmbCatelory.Size = new System.Drawing.Size(379, 28);
            this.cmbCatelory.TabIndex = 0;
            this.cmbCatelory.SelectedIndexChanged += new System.EventHandler(this.cmbCatelory_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1335, 37);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 29);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Trợ Giúp";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // fWorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 663);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmbCatelory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbHoaDon);
            this.Controls.Add(this.grbDonHang);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "fWorkSpace";
            this.Text = "Quản Lý cửa hàng Văn Phòng Phẩm";
            this.grbHoaDon.ResumeLayout(false);
            this.grbHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).EndInit();
            this.grbDonHang.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluongHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox grbHoaDon;
        private System.Windows.Forms.GroupBox grbDonHang;
        private System.Windows.Forms.FlowLayoutPanel flpHDKhachHang;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nHÂNSỰToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tồnKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kHOHÀNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nHÂNVIÊNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỆTHỐNGToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCatelory;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Button btnThemCus;
        private System.Windows.Forms.NumericUpDown numSoluongHH;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.NumericUpDown numGiamGia;
        private System.Windows.Forms.ToolStripMenuItem thongToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayVao;
        private System.Windows.Forms.TextBox txbMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}