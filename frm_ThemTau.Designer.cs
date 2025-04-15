namespace BTN_QLIVETAU
{
    partial class frm_ThemTau
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xacnhan = new System.Windows.Forms.Button();
            this.TXT_TENTAU = new System.Windows.Forms.TextBox();
            this.TXT_SOTOA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Thoat.Location = new System.Drawing.Point(522, 310);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(99, 41);
            this.btn_Thoat.TabIndex = 58;
            this.btn_Thoat.Text = "Hủy";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xacnhan
            // 
            this.btn_Xacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Xacnhan.Location = new System.Drawing.Point(183, 310);
            this.btn_Xacnhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xacnhan.Name = "btn_Xacnhan";
            this.btn_Xacnhan.Size = new System.Drawing.Size(110, 41);
            this.btn_Xacnhan.TabIndex = 57;
            this.btn_Xacnhan.Text = "Xác nhận";
            this.btn_Xacnhan.UseVisualStyleBackColor = false;
            this.btn_Xacnhan.Click += new System.EventHandler(this.btn_Xacnhan_Click);
            // 
            // TXT_TENTAU
            // 
            this.TXT_TENTAU.Location = new System.Drawing.Point(267, 99);
            this.TXT_TENTAU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_TENTAU.Name = "TXT_TENTAU";
            this.TXT_TENTAU.Size = new System.Drawing.Size(354, 26);
            this.TXT_TENTAU.TabIndex = 61;
            // 
            // TXT_SOTOA
            // 
            this.TXT_SOTOA.Location = new System.Drawing.Point(267, 173);
            this.TXT_SOTOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_SOTOA.Name = "TXT_SOTOA";
            this.TXT_SOTOA.Size = new System.Drawing.Size(354, 26);
            this.TXT_SOTOA.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tên tàu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Số toa:";
            // 
            // frm_ThemTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xacnhan);
            this.Controls.Add(this.TXT_TENTAU);
            this.Controls.Add(this.TXT_SOTOA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "frm_ThemTau";
            this.Text = "frm_ThemTau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xacnhan;
        private System.Windows.Forms.TextBox TXT_TENTAU;
        private System.Windows.Forms.TextBox TXT_SOTOA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}