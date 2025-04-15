namespace BTN_QLIVETAU
{
    partial class frm_QUANLYKHACHHANG
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLI_VETAUDataSet2 = new BTN_QLIVETAU.QLI_VETAUDataSet2();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXemVe = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.kHACHHANGTableAdapter = new BTN_QLIVETAU.QLI_VETAUDataSet2TableAdapters.KHACHHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoGenerateColumns = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvKhachHang.DataSource = this.kHACHHANGBindingSource;
            this.dgvKhachHang.Location = new System.Drawing.Point(131, 166);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(927, 188);
            this.dgvKhachHang.TabIndex = 31;
            this.dgvKhachHang.SelectionChanged += new System.EventHandler(this.dgvKhachHang_SelectionChanged);
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            this.tenDangNhapDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 150;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLI_VETAUDataSet2;
            // 
            // qLI_VETAUDataSet2
            // 
            this.qLI_VETAUDataSet2.DataSetName = "QLI_VETAUDataSet2";
            this.qLI_VETAUDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(456, 98);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 35);
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXemVe
            // 
            this.btnXemVe.Location = new System.Drawing.Point(893, 563);
            this.btnXemVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemVe.Name = "btnXemVe";
            this.btnXemVe.Size = new System.Drawing.Size(97, 40);
            this.btnXemVe.TabIndex = 29;
            this.btnXemVe.Text = "Xem vé";
            this.btnXemVe.UseVisualStyleBackColor = true;
            this.btnXemVe.Click += new System.EventHandler(this.btnXemVe_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(679, 565);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 39);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(456, 565);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 39);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(230, 563);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 40);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(626, 465);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(52, 20);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.Text = "Email:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.AutoSize = true;
            this.txtSoDienThoai.Location = new System.Drawing.Point(626, 409);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(45, 20);
            this.txtSoDienThoai.TabIndex = 24;
            this.txtSoDienThoai.Text = "SDT:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Location = new System.Drawing.Point(231, 465);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(61, 20);
            this.txtHoTen.TabIndex = 23;
            this.txtHoTen.Text = "Họ tên:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.AutoSize = true;
            this.txtTenDangNhap.Location = new System.Drawing.Point(231, 409);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(120, 20);
            this.txtTenDangNhap.TabIndex = 22;
            this.txtTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(349, 457);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 26);
            this.textBox6.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(349, 402);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 26);
            this.textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(774, 406);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 26);
            this.textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(774, 457);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 26);
            this.textBox3.TabIndex = 18;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(198, 102);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(202, 26);
            this.txtTimKiem.TabIndex = 17;
            this.txtTimKiem.Text = "Tìm khách hàng";
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // frm_QUANLYKHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 741);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXemVe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "frm_QUANLYKHACHHANG";
            this.Text = "frm_QUANLYKHACHHANG";
            this.Load += new System.EventHandler(this.frm_QUANLYKHACHHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXemVe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtSoDienThoai;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.Label txtTenDangNhap;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private QLI_VETAUDataSet2 qLI_VETAUDataSet2;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLI_VETAUDataSet2TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}