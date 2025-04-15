namespace BTN_QLIVETAU
{
    partial class frm_BCGATAU
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
            this.BCGATAU = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BCGATAU
            // 
            this.BCGATAU.ActiveViewIndex = -1;
            this.BCGATAU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BCGATAU.Cursor = System.Windows.Forms.Cursors.Default;
            this.BCGATAU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BCGATAU.Location = new System.Drawing.Point(0, 0);
            this.BCGATAU.Name = "BCGATAU";
            this.BCGATAU.Size = new System.Drawing.Size(800, 450);
            this.BCGATAU.TabIndex = 0;
            // 
            // frm_BCGATAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCGATAU);
            this.Name = "frm_BCGATAU";
            this.Text = "frm_BCGATAU";
            this.Load += new System.EventHandler(this.frm_BCGATAU_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer BCGATAU;
    }
}