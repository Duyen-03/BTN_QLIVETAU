namespace BTN_QLIVETAU
{
    partial class frm_BCKHACHHANG
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
            this.BCKHACHHANG = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BCKHACHHANG
            // 
            this.BCKHACHHANG.ActiveViewIndex = -1;
            this.BCKHACHHANG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BCKHACHHANG.Cursor = System.Windows.Forms.Cursors.Default;
            this.BCKHACHHANG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BCKHACHHANG.Location = new System.Drawing.Point(0, 0);
            this.BCKHACHHANG.Name = "BCKHACHHANG";
            this.BCKHACHHANG.Size = new System.Drawing.Size(1062, 576);
            this.BCKHACHHANG.TabIndex = 0;
            // 
            // frm_BCKHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 576);
            this.Controls.Add(this.BCKHACHHANG);
            this.Name = "frm_BCKHACHHANG";
            this.Text = "frm_BCKHACHHANG";
            this.Load += new System.EventHandler(this.frm_BCKHACHHANG_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer BCKHACHHANG;
    }
}