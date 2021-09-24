namespace DoAnNhomQLBH
{
    partial class FChiTietDonHang
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
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.maSanPhamLabel = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.dienThoaiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.dtpNgayDonHang = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gVCTDH = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVCTDH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.ForeColor = System.Drawing.Color.Blue;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(19, 35);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(74, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã đơn hàng:";
            // 
            // maSanPhamLabel
            // 
            this.maSanPhamLabel.AutoSize = true;
            this.maSanPhamLabel.ForeColor = System.Drawing.Color.Blue;
            this.maSanPhamLabel.Location = new System.Drawing.Point(19, 68);
            this.maSanPhamLabel.Name = "maSanPhamLabel";
            this.maSanPhamLabel.Size = new System.Drawing.Size(59, 13);
            this.maSanPhamLabel.TabIndex = 4;
            this.maSanPhamLabel.Text = "Sản Phẩm:";
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.ForeColor = System.Drawing.Color.Blue;
            this.diaChiLabel.Location = new System.Drawing.Point(359, 36);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(53, 13);
            this.diaChiLabel.TabIndex = 6;
            this.diaChiLabel.Text = "Số Lượng";
            // 
            // dienThoaiLabel
            // 
            this.dienThoaiLabel.AutoSize = true;
            this.dienThoaiLabel.ForeColor = System.Drawing.Color.Blue;
            this.dienThoaiLabel.Location = new System.Drawing.Point(20, 101);
            this.dienThoaiLabel.Name = "dienThoaiLabel";
            this.dienThoaiLabel.Size = new System.Drawing.Size(61, 13);
            this.dienThoaiLabel.TabIndex = 8;
            this.dienThoaiLabel.Text = "Thành tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(673, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CTDH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiamGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMaSP);
            this.groupBox1.Controls.Add(this.hoTenNhanVienLabel);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.txtMaDH);
            this.groupBox1.Controls.Add(this.maSanPhamLabel);
            this.groupBox1.Controls.Add(this.diaChiLabel);
            this.groupBox1.Controls.Add(this.dienThoaiLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(463, 102);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(200, 20);
            this.txtGiamGia.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(362, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giảm giá:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(463, 68);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(200, 20);
            this.txtSize.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(362, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Size: ";
            // 
            // cbMaSP
            // 
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(124, 65);
            this.cbMaSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(200, 21);
            this.cbMaSP.TabIndex = 9;
            this.cbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbMaSP_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(463, 36);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(124, 100);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(200, 20);
            this.txtThanhTien.TabIndex = 3;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Enabled = false;
            this.txtMaDH.Location = new System.Drawing.Point(124, 32);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(200, 20);
            this.txtMaDH.TabIndex = 3;
            // 
            // dtpNgayDonHang
            // 
            this.dtpNgayDonHang.Location = new System.Drawing.Point(186, 109);
            this.dtpNgayDonHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayDonHang.Name = "dtpNgayDonHang";
            this.dtpNgayDonHang.Size = new System.Drawing.Size(298, 20);
            this.dtpNgayDonHang.TabIndex = 5;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gVCTDH);
            this.groupBox3.Location = new System.Drawing.Point(10, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(778, 251);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // gVCTDH
            // 
            this.gVCTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVCTDH.Location = new System.Drawing.Point(9, 15);
            this.gVCTDH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gVCTDH.Name = "gVCTDH";
            this.gVCTDH.RowHeadersWidth = 62;
            this.gVCTDH.RowTemplate.Height = 28;
            this.gVCTDH.Size = new System.Drawing.Size(764, 219);
            this.gVCTDH.TabIndex = 0;
            this.gVCTDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVCTDH_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btDong);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btLuu);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 500);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 60);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btSearch
            // 
            this.btSearch.ForeColor = System.Drawing.Color.Blue;
            this.btSearch.Location = new System.Drawing.Point(452, 16);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(79, 34);
            this.btSearch.TabIndex = 10;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.ForeColor = System.Drawing.Color.Blue;
            this.btXoa.Location = new System.Drawing.Point(235, 16);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(76, 34);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.ForeColor = System.Drawing.Color.Blue;
            this.btSua.Location = new System.Drawing.Point(128, 16);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(76, 34);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btDong
            // 
            this.btDong.ForeColor = System.Drawing.Color.Blue;
            this.btDong.Location = new System.Drawing.Point(688, 15);
            this.btDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(78, 35);
            this.btDong.TabIndex = 7;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(562, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Hiển thị DS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.ForeColor = System.Drawing.Color.Blue;
            this.btLuu.Location = new System.Drawing.Point(341, 16);
            this.btLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(80, 34);
            this.btLuu.TabIndex = 4;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.ForeColor = System.Drawing.Color.Blue;
            this.btThem.Location = new System.Drawing.Point(19, 15);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(79, 35);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // FChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FChiTietDonHang";
            this.Text = "FOrderDetails";
            this.Activated += new System.EventHandler(this.FChiTietDonHang_Activated);
            this.Load += new System.EventHandler(this.FChiTietDonHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVCTDH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DateTimePicker dtpNgayDonHang;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label maSanPhamLabel;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.Label dienThoaiLabel;
        private System.Windows.Forms.DataGridView gVCTDH;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label3;
    }
}