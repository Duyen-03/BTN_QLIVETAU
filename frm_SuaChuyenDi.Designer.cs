namespace BTN_QLIVETAU
{
    partial class frm_SuaChuyenDi
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
            this.CBO_LichTrinh = new System.Windows.Forms.ComboBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.TXT_MaChuyenDi = new System.Windows.Forms.TextBox();
            this.CBO_Tau = new System.Windows.Forms.ComboBox();
            this.TXT_GiaCoBan = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBO_LichTrinh
            // 
            this.CBO_LichTrinh.FormattingEnabled = true;
            this.CBO_LichTrinh.Location = new System.Drawing.Point(101, 51);
            this.CBO_LichTrinh.Name = "CBO_LichTrinh";
            this.CBO_LichTrinh.Size = new System.Drawing.Size(183, 24);
            this.CBO_LichTrinh.TabIndex = 0;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(221, 235);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // TXT_MaChuyenDi
            // 
            this.TXT_MaChuyenDi.Location = new System.Drawing.Point(437, 51);
            this.TXT_MaChuyenDi.Name = "TXT_MaChuyenDi";
            this.TXT_MaChuyenDi.Size = new System.Drawing.Size(168, 22);
            this.TXT_MaChuyenDi.TabIndex = 2;
            // 
            // CBO_Tau
            // 
            this.CBO_Tau.FormattingEnabled = true;
            this.CBO_Tau.Location = new System.Drawing.Point(101, 122);
            this.CBO_Tau.Name = "CBO_Tau";
            this.CBO_Tau.Size = new System.Drawing.Size(183, 24);
            this.CBO_Tau.TabIndex = 3;
            // 
            // TXT_GiaCoBan
            // 
            this.TXT_GiaCoBan.Location = new System.Drawing.Point(437, 122);
            this.TXT_GiaCoBan.Name = "TXT_GiaCoBan";
            this.TXT_GiaCoBan.Size = new System.Drawing.Size(168, 22);
            this.TXT_GiaCoBan.TabIndex = 4;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(421, 235);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 5;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // frm_SuaChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.TXT_GiaCoBan);
            this.Controls.Add(this.CBO_Tau);
            this.Controls.Add(this.TXT_MaChuyenDi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.CBO_LichTrinh);
            this.Name = "frm_SuaChuyenDi";
            this.Text = "frm_SuaChuyenDi";
            this.Load += new System.EventHandler(this.frm_SuaChuyenDi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBO_LichTrinh;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox TXT_MaChuyenDi;
        private System.Windows.Forms.ComboBox CBO_Tau;
        private System.Windows.Forms.TextBox TXT_GiaCoBan;
        private System.Windows.Forms.Button btn_Huy;
    }
}