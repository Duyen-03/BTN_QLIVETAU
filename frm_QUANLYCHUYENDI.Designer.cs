namespace BTN_QLIVETAU
{
    partial class frm_QuanLyChuyenDi
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
            this.TXT_MaChuyenDi = new System.Windows.Forms.TextBox();
            this.dgv_DanhSachChuyenDi = new System.Windows.Forms.DataGridView();
            this.maChuyenDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLichTrinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaCoBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUYENDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLI_VETAUDataSet1 = new BTN_QLIVETAU.QLI_VETAUDataSet1();
            this.btn_Them = new System.Windows.Forms.Button();
            this.CBO_LichTrinh = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.TXT_GiaCoBan = new System.Windows.Forms.TextBox();
            this.CBO_Tau = new System.Windows.Forms.ComboBox();
            this.cHUYENDITableAdapter = new BTN_QLIVETAU.QLI_VETAUDataSet1TableAdapters.CHUYENDITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChuyenDi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_MaChuyenDi
            // 
            this.TXT_MaChuyenDi.Location = new System.Drawing.Point(396, 46);
            this.TXT_MaChuyenDi.Name = "TXT_MaChuyenDi";
            this.TXT_MaChuyenDi.Size = new System.Drawing.Size(140, 22);
            this.TXT_MaChuyenDi.TabIndex = 0;
            this.TXT_MaChuyenDi.Text = "Nhập mã chuyến đi";
            // 
            // dgv_DanhSachChuyenDi
            // 
            this.dgv_DanhSachChuyenDi.AutoGenerateColumns = false;
            this.dgv_DanhSachChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachChuyenDi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChuyenDiDataGridViewTextBoxColumn,
            this.maLichTrinhDataGridViewTextBoxColumn,
            this.maTauDataGridViewTextBoxColumn,
            this.giaCoBanDataGridViewTextBoxColumn});
            this.dgv_DanhSachChuyenDi.DataSource = this.cHUYENDIBindingSource;
            this.dgv_DanhSachChuyenDi.Location = new System.Drawing.Point(12, 200);
            this.dgv_DanhSachChuyenDi.Name = "dgv_DanhSachChuyenDi";
            this.dgv_DanhSachChuyenDi.RowHeadersWidth = 51;
            this.dgv_DanhSachChuyenDi.RowTemplate.Height = 24;
            this.dgv_DanhSachChuyenDi.Size = new System.Drawing.Size(1050, 222);
            this.dgv_DanhSachChuyenDi.TabIndex = 1;
            this.dgv_DanhSachChuyenDi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachChuyenDi_CellClick);
            // 
            // maChuyenDiDataGridViewTextBoxColumn
            // 
            this.maChuyenDiDataGridViewTextBoxColumn.DataPropertyName = "MaChuyenDi";
            this.maChuyenDiDataGridViewTextBoxColumn.HeaderText = "MaChuyenDi";
            this.maChuyenDiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maChuyenDiDataGridViewTextBoxColumn.Name = "maChuyenDiDataGridViewTextBoxColumn";
            this.maChuyenDiDataGridViewTextBoxColumn.ReadOnly = true;
            this.maChuyenDiDataGridViewTextBoxColumn.Width = 125;
            // 
            // maLichTrinhDataGridViewTextBoxColumn
            // 
            this.maLichTrinhDataGridViewTextBoxColumn.DataPropertyName = "MaLichTrinh";
            this.maLichTrinhDataGridViewTextBoxColumn.HeaderText = "MaLichTrinh";
            this.maLichTrinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLichTrinhDataGridViewTextBoxColumn.Name = "maLichTrinhDataGridViewTextBoxColumn";
            this.maLichTrinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // maTauDataGridViewTextBoxColumn
            // 
            this.maTauDataGridViewTextBoxColumn.DataPropertyName = "MaTau";
            this.maTauDataGridViewTextBoxColumn.HeaderText = "MaTau";
            this.maTauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTauDataGridViewTextBoxColumn.Name = "maTauDataGridViewTextBoxColumn";
            this.maTauDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaCoBanDataGridViewTextBoxColumn
            // 
            this.giaCoBanDataGridViewTextBoxColumn.DataPropertyName = "GiaCoBan";
            this.giaCoBanDataGridViewTextBoxColumn.HeaderText = "GiaCoBan";
            this.giaCoBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaCoBanDataGridViewTextBoxColumn.Name = "giaCoBanDataGridViewTextBoxColumn";
            this.giaCoBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHUYENDIBindingSource
            // 
            this.cHUYENDIBindingSource.DataMember = "CHUYENDI";
            this.cHUYENDIBindingSource.DataSource = this.qLI_VETAUDataSet1;
            // 
            // qLI_VETAUDataSet1
            // 
            this.qLI_VETAUDataSet1.DataSetName = "QLI_VETAUDataSet1";
            this.qLI_VETAUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(46, 487);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // CBO_LichTrinh
            // 
            this.CBO_LichTrinh.FormattingEnabled = true;
            this.CBO_LichTrinh.Location = new System.Drawing.Point(58, 44);
            this.CBO_LichTrinh.Name = "CBO_LichTrinh";
            this.CBO_LichTrinh.Size = new System.Drawing.Size(121, 24);
            this.CBO_LichTrinh.TabIndex = 3;
            this.CBO_LichTrinh.Text = "Chọn lịch trình";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(234, 487);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(444, 487);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(656, 487);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(75, 23);
            this.btn_LamMoi.TabIndex = 6;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(777, 72);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 7;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // TXT_GiaCoBan
            // 
            this.TXT_GiaCoBan.Location = new System.Drawing.Point(396, 141);
            this.TXT_GiaCoBan.Name = "TXT_GiaCoBan";
            this.TXT_GiaCoBan.Size = new System.Drawing.Size(140, 22);
            this.TXT_GiaCoBan.TabIndex = 8;
            this.TXT_GiaCoBan.Text = "Nhập giá cơ bản";
            // 
            // CBO_Tau
            // 
            this.CBO_Tau.FormattingEnabled = true;
            this.CBO_Tau.Location = new System.Drawing.Point(58, 139);
            this.CBO_Tau.Name = "CBO_Tau";
            this.CBO_Tau.Size = new System.Drawing.Size(121, 24);
            this.CBO_Tau.TabIndex = 9;
            this.CBO_Tau.Text = "Chọn tàu";
            // 
            // cHUYENDITableAdapter
            // 
            this.cHUYENDITableAdapter.ClearBeforeFill = true;
            // 
            // frm_QuanLyChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 615);
            this.Controls.Add(this.CBO_Tau);
            this.Controls.Add(this.TXT_GiaCoBan);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.CBO_LichTrinh);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DanhSachChuyenDi);
            this.Controls.Add(this.TXT_MaChuyenDi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_QuanLyChuyenDi";
            this.Text = "frm_QuanLyChuyenDi";
            this.Load += new System.EventHandler(this.frm_QUANLYCHUYENDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChuyenDi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_MaChuyenDi;
        private System.Windows.Forms.DataGridView dgv_DanhSachChuyenDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenDiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLichTrinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaCoBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cHUYENDIBindingSource;
        private QLI_VETAUDataSet1 qLI_VETAUDataSet1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox CBO_LichTrinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox TXT_GiaCoBan;
        private System.Windows.Forms.ComboBox CBO_Tau;
        private QLI_VETAUDataSet1TableAdapters.CHUYENDITableAdapter cHUYENDITableAdapter;
    }
}