using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN_QLIVETAU
{
    public partial class frm_SuaTau : Form
    {
        public frm_SuaTau()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();

        public frm_SuaTau(string maTau, string tenTau, string soToa)
        {
            InitializeComponent();
            TXT_MATAU.Text = maTau;
            TXT_TENTAU.Text = tenTau;
            TXT_SOTOA.Text = soToa;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xacnhan_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TXT_TENTAU.Text))
            {
                MessageBox.Show("Tên tàu không được để trống.");
                return;
            }

            if (!int.TryParse(TXT_SOTOA.Text.Trim(), out int soToa))
            {
                MessageBox.Show("Số toa phải là số nguyên.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn sửa tàu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = $"UPDATE TAU SET TenTau = N'{TXT_TENTAU.Text.Trim()}', SoToa = {TXT_SOTOA.Text.Trim()} WHERE MaTau = N'{TXT_MATAU.Text.Trim()}'";
                kn.ThucThi(sql);
                MessageBox.Show("Sửa thành công!");
                this.Close();
            }
        }
    }
}
