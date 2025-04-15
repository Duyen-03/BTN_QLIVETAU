namespace BTN_QLIVETAU
{
    partial class frm_SuaTau
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
            this.TXT_MATAU = new System.Windows.Forms.TextBox();
            this.TXT_SOTOA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Thoat.Location = new System.Drawing.Point(522, 348);
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
            this.btn_Xacnhan.Location = new System.Drawing.Point(182, 348);
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
            this.TXT_TENTAU.Location = new System.Drawing.Point(266, 137);
            this.TXT_TENTAU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_TENTAU.Name = "TXT_TENTAU";
            this.TXT_TENTAU.Size = new System.Drawing.Size(354, 26);
            this.TXT_TENTAU.TabIndex = 62;
            // 
            // TXT_MATAU
            // 
            this.TXT_MATAU.Enabled = false;
            this.TXT_MATAU.Location = new System.Drawing.Point(266, 62);
            this.TXT_MATAU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_MATAU.Name = "TXT_MATAU";
            this.TXT_MATAU.Size = new System.Drawing.Size(354, 26);
            this.TXT_MATAU.TabIndex = 63;
            // 
            // TXT_SOTOA
            // 
            this.TXT_SOTOA.Location = new System.Drawing.Point(266, 212);
            this.TXT_SOTOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_SOTOA.Name = "TXT_SOTOA";
            this.TXT_SOTOA.Size = new System.Drawing.Size(354, 26);
            this.TXT_SOTOA.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mã Tàu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tên tàu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Số toa:";
            // 
            // frm_SuaTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xacnhan);
            this.Controls.Add(this.TXT_TENTAU);
            this.Controls.Add(this.TXT_MATAU);
            this.Controls.Add(this.TXT_SOTOA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "frm_SuaTau";
            this.Text = "frm_SuaTau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xacnhan;
        private System.Windows.Forms.TextBox TXT_TENTAU;
        private System.Windows.Forms.TextBox TXT_MATAU;
        private System.Windows.Forms.TextBox TXT_SOTOA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}