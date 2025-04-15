namespace BTN_QLIVETAU
{
    partial class frm_QuanLyTau
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
            this.TXT_SOTOA = new System.Windows.Forms.TextBox();
            this.TXT_TENTAU = new System.Windows.Forms.TextBox();
            this.TXT_MATAU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgvTau = new System.Windows.Forms.DataGridView();
            this.maTauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soToaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLI_VETAUDataSet4 = new BTN_QLIVETAU.QLI_VETAUDataSet4();
            this.tAUTableAdapter = new BTN_QLIVETAU.QLI_VETAUDataSet4TableAdapters.TAUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_SOTOA
            // 
            this.TXT_SOTOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SOTOA.Location = new System.Drawing.Point(301, 191);
            this.TXT_SOTOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_SOTOA.Name = "TXT_SOTOA";
            this.TXT_SOTOA.Size = new System.Drawing.Size(508, 28);
            this.TXT_SOTOA.TabIndex = 263;
            this.TXT_SOTOA.TextChanged += new System.EventHandler(this.TextBox_Modified);
            this.TXT_SOTOA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // TXT_TENTAU
            // 
            this.TXT_TENTAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TENTAU.Location = new System.Drawing.Point(301, 141);
            this.TXT_TENTAU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_TENTAU.Name = "TXT_TENTAU";
            this.TXT_TENTAU.Size = new System.Drawing.Size(508, 28);
            this.TXT_TENTAU.TabIndex = 264;
            this.TXT_TENTAU.TextChanged += new System.EventHandler(this.TextBox_Modified);
            this.TXT_TENTAU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // TXT_MATAU
            // 
            this.TXT_MATAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MATAU.Location = new System.Drawing.Point(301, 91);
            this.TXT_MATAU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_MATAU.Name = "TXT_MATAU";
            this.TXT_MATAU.Size = new System.Drawing.Size(508, 28);
            this.TXT_MATAU.TabIndex = 265;
            this.TXT_MATAU.TextChanged += new System.EventHandler(this.TextBox_Modified);
            this.TXT_MATAU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 260;
            this.label3.Text = "Mã tàu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 261;
            this.label4.Text = "Số toa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 262;
            this.label2.Text = "Tên tàu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(145, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 259;
            this.label1.Text = "Danh sách Tàu:";
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Lammoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Lammoi.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.Location = new System.Drawing.Point(978, 82);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(116, 44);
            this.btn_Lammoi.TabIndex = 257;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Timkiem.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timkiem.Location = new System.Drawing.Point(978, 174);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(116, 44);
            this.btn_Timkiem.TabIndex = 258;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = false;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(504, 628);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(180, 41);
            this.btn_Sua.TabIndex = 256;
            this.btn_Sua.Text = "Sửa chuyến tàu";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(222, 628);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(180, 41);
            this.btn_Them.TabIndex = 255;
            this.btn_Them.Text = "Thêm Chuyến Tàu";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(785, 628);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(180, 41);
            this.btn_Xoa.TabIndex = 254;
            this.btn_Xoa.Text = "Xoá chuyến tàu";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgvTau
            // 
            this.dgvTau.AutoGenerateColumns = false;
            this.dgvTau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTauDataGridViewTextBoxColumn,
            this.tenTauDataGridViewTextBoxColumn,
            this.soToaDataGridViewTextBoxColumn});
            this.dgvTau.DataSource = this.tAUBindingSource;
            this.dgvTau.Location = new System.Drawing.Point(147, 248);
            this.dgvTau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTau.Name = "dgvTau";
            this.dgvTau.ReadOnly = true;
            this.dgvTau.RowHeadersWidth = 51;
            this.dgvTau.RowTemplate.Height = 24;
            this.dgvTau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTau.Size = new System.Drawing.Size(947, 359);
            this.dgvTau.TabIndex = 253;
            this.dgvTau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTau_CellContentClick);
            this.dgvTau.SelectionChanged += new System.EventHandler(this.dgvTau_SelectionChanged);
            // 
            // maTauDataGridViewTextBoxColumn
            // 
            this.maTauDataGridViewTextBoxColumn.DataPropertyName = "MaTau";
            this.maTauDataGridViewTextBoxColumn.HeaderText = "MaTau";
            this.maTauDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maTauDataGridViewTextBoxColumn.Name = "maTauDataGridViewTextBoxColumn";
            this.maTauDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTauDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenTauDataGridViewTextBoxColumn
            // 
            this.tenTauDataGridViewTextBoxColumn.DataPropertyName = "TenTau";
            this.tenTauDataGridViewTextBoxColumn.HeaderText = "TenTau";
            this.tenTauDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenTauDataGridViewTextBoxColumn.Name = "tenTauDataGridViewTextBoxColumn";
            this.tenTauDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenTauDataGridViewTextBoxColumn.Width = 150;
            // 
            // soToaDataGridViewTextBoxColumn
            // 
            this.soToaDataGridViewTextBoxColumn.DataPropertyName = "SoToa";
            this.soToaDataGridViewTextBoxColumn.HeaderText = "SoToa";
            this.soToaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soToaDataGridViewTextBoxColumn.Name = "soToaDataGridViewTextBoxColumn";
            this.soToaDataGridViewTextBoxColumn.ReadOnly = true;
            this.soToaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tAUBindingSource
            // 
            this.tAUBindingSource.DataMember = "TAU";
            this.tAUBindingSource.DataSource = this.qLI_VETAUDataSet4;
            // 
            // qLI_VETAUDataSet4
            // 
            this.qLI_VETAUDataSet4.DataSetName = "QLI_VETAUDataSet4";
            this.qLI_VETAUDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAUTableAdapter
            // 
            this.tAUTableAdapter.ClearBeforeFill = true;
            // 
            // frm_QuanLyTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 710);
            this.Controls.Add(this.TXT_SOTOA);
            this.Controls.Add(this.TXT_TENTAU);
            this.Controls.Add(this.TXT_MATAU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Lammoi);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dgvTau);
            this.Name = "frm_QuanLyTau";
            this.Text = "frm_QuanLyTau";
            this.Load += new System.EventHandler(this.frm_QuanLyTau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_SOTOA;
        private System.Windows.Forms.TextBox TXT_TENTAU;
        private System.Windows.Forms.TextBox TXT_MATAU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgvTau;
        private QLI_VETAUDataSet4 qLI_VETAUDataSet4;
        private System.Windows.Forms.BindingSource tAUBindingSource;
        private QLI_VETAUDataSet4TableAdapters.TAUTableAdapter tAUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soToaDataGridViewTextBoxColumn;
    }
}