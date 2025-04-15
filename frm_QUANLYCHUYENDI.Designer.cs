namespace BTN_QLIVETAU
{
    partial class frm_QUANLYCHUYENDI
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
            this.txtGiaCoBan = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvChuyenDi = new System.Windows.Forms.DataGridView();
            this.maChuyenDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLichTrinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaCoBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUYENDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLI_VETAUDataSet1 = new BTN_QLIVETAU.QLI_VETAUDataSet1();
            this.cmbTau = new System.Windows.Forms.ComboBox();
            this.cmbLichTrinh = new System.Windows.Forms.ComboBox();
            this.cHUYENDITableAdapter = new BTN_QLIVETAU.QLI_VETAUDataSet1TableAdapters.CHUYENDITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGiaCoBan
            // 
            this.txtGiaCoBan.Location = new System.Drawing.Point(680, 379);
            this.txtGiaCoBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaCoBan.Name = "txtGiaCoBan";
            this.txtGiaCoBan.Size = new System.Drawing.Size(198, 26);
            this.txtGiaCoBan.TabIndex = 15;
            this.txtGiaCoBan.Text = "Nhập giá";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(886, 532);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(91, 40);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(716, 532);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 40);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(565, 532);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 40);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(406, 532);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 40);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // dgvChuyenDi
            // 
            this.dgvChuyenDi.AutoGenerateColumns = false;
            this.dgvChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenDi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChuyenDiDataGridViewTextBoxColumn,
            this.maLichTrinhDataGridViewTextBoxColumn,
            this.maTauDataGridViewTextBoxColumn,
            this.giaCoBanDataGridViewTextBoxColumn});
            this.dgvChuyenDi.DataSource = this.cHUYENDIBindingSource;
            this.dgvChuyenDi.Location = new System.Drawing.Point(233, 140);
            this.dgvChuyenDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvChuyenDi.Name = "dgvChuyenDi";
            this.dgvChuyenDi.RowHeadersWidth = 51;
            this.dgvChuyenDi.RowTemplate.Height = 24;
            this.dgvChuyenDi.Size = new System.Drawing.Size(873, 188);
            this.dgvChuyenDi.TabIndex = 10;
            this.dgvChuyenDi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenDi_CellContentClick);
            this.dgvChuyenDi.SelectionChanged += new System.EventHandler(this.dgvChuyenDi_SelectionChanged_1);
            // 
            // maChuyenDiDataGridViewTextBoxColumn
            // 
            this.maChuyenDiDataGridViewTextBoxColumn.DataPropertyName = "MaChuyenDi";
            this.maChuyenDiDataGridViewTextBoxColumn.HeaderText = "MaChuyenDi";
            this.maChuyenDiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maChuyenDiDataGridViewTextBoxColumn.Name = "maChuyenDiDataGridViewTextBoxColumn";
            this.maChuyenDiDataGridViewTextBoxColumn.ReadOnly = true;
            this.maChuyenDiDataGridViewTextBoxColumn.Width = 150;
            // 
            // maLichTrinhDataGridViewTextBoxColumn
            // 
            this.maLichTrinhDataGridViewTextBoxColumn.DataPropertyName = "MaLichTrinh";
            this.maLichTrinhDataGridViewTextBoxColumn.HeaderText = "MaLichTrinh";
            this.maLichTrinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maLichTrinhDataGridViewTextBoxColumn.Name = "maLichTrinhDataGridViewTextBoxColumn";
            this.maLichTrinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // maTauDataGridViewTextBoxColumn
            // 
            this.maTauDataGridViewTextBoxColumn.DataPropertyName = "MaTau";
            this.maTauDataGridViewTextBoxColumn.HeaderText = "MaTau";
            this.maTauDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maTauDataGridViewTextBoxColumn.Name = "maTauDataGridViewTextBoxColumn";
            this.maTauDataGridViewTextBoxColumn.Width = 150;
            // 
            // giaCoBanDataGridViewTextBoxColumn
            // 
            this.giaCoBanDataGridViewTextBoxColumn.DataPropertyName = "GiaCoBan";
            this.giaCoBanDataGridViewTextBoxColumn.HeaderText = "GiaCoBan";
            this.giaCoBanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.giaCoBanDataGridViewTextBoxColumn.Name = "giaCoBanDataGridViewTextBoxColumn";
            this.giaCoBanDataGridViewTextBoxColumn.Width = 150;
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
            // cmbTau
            // 
            this.cmbTau.FormattingEnabled = true;
            this.cmbTau.Location = new System.Drawing.Point(299, 435);
            this.cmbTau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTau.Name = "cmbTau";
            this.cmbTau.Size = new System.Drawing.Size(136, 28);
            this.cmbTau.TabIndex = 9;
            this.cmbTau.Text = "Chọn tàu";
            // 
            // cmbLichTrinh
            // 
            this.cmbLichTrinh.FormattingEnabled = true;
            this.cmbLichTrinh.Location = new System.Drawing.Point(299, 357);
            this.cmbLichTrinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLichTrinh.Name = "cmbLichTrinh";
            this.cmbLichTrinh.Size = new System.Drawing.Size(136, 28);
            this.cmbLichTrinh.TabIndex = 8;
            this.cmbLichTrinh.Text = "Chọn lịch trình";
            this.cmbLichTrinh.SelectedIndexChanged += new System.EventHandler(this.cmbLichTrinh_SelectedIndexChanged);
            // 
            // cHUYENDITableAdapter
            // 
            this.cHUYENDITableAdapter.ClearBeforeFill = true;
            // 
            // frm_QUANLYCHUYENDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 769);
            this.Controls.Add(this.txtGiaCoBan);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvChuyenDi);
            this.Controls.Add(this.cmbTau);
            this.Controls.Add(this.cmbLichTrinh);
            this.Name = "frm_QUANLYCHUYENDI";
            this.Text = "frm_QUANLYCHUYENDI";
            this.Load += new System.EventHandler(this.frm_QUANLYCHUYENDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiaCoBan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvChuyenDi;
        private System.Windows.Forms.ComboBox cmbTau;
        private System.Windows.Forms.ComboBox cmbLichTrinh;
        private QLI_VETAUDataSet1 qLI_VETAUDataSet1;
        private System.Windows.Forms.BindingSource cHUYENDIBindingSource;
        private QLI_VETAUDataSet1TableAdapters.CHUYENDITableAdapter cHUYENDITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenDiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLichTrinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaCoBanDataGridViewTextBoxColumn;
    }
}