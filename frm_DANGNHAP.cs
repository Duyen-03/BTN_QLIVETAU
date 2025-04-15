using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN_QLIVETAU
{
    public partial class frm_DANGNHAP : Form
    {
        public frm_DANGNHAP()
        {
            InitializeComponent();
        }
        KETNOI_DULIEU kn = new KETNOI_DULIEU();

        

        private void btnDangNhap_Click_2(object sender, EventArgs e)
        {
            kn.KetNoi_DuLieu();
            string id = txtTenDangNhap.Text;
            string pw = txtMatKhau.Text;
            string sql_login = "Select TenDangNhap, MatKhau from TAIKHOAN where TenDangNhap = @id and MatKhau = @pw";

            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pw", pw);
            SqlDataReader datRed = cmd.ExecuteReader();

            if (datRed.Read())
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Hiển thị form Main 
                Form frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

