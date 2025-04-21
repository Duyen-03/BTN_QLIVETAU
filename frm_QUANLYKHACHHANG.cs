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
    public partial class frm_QUANLYKHACHHANG : Form
    {
        public frm_QUANLYKHACHHANG()
        {
            InitializeComponent();
            TaiDanhSachKhachHang();
        }

        KETNOI_DULIEU ketNoi = new KETNOI_DULIEU();
        private void frm_QUANLYKHACHHANG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLI_VETAUDataSet2.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLI_VETAUDataSet2.KHACHHANG);

        }
        private void TaiDanhSachKhachHang()
        {
            string sql = "SELECT * FROM KHACHHANG";
            dgvKhachHang.DataSource = ketNoi.Lay_DuLieuBang(sql);
            ketNoi.HuyKetNoi();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Thêm vào bảng TAIKHOAN trước
                string sqlTaiKhoan = $"INSERT INTO TAIKHOAN (TenDangNhap, MatKhau) VALUES ('{txtTenDangNhap.Text}', 'default123')";
                ketNoi.ThucThi(sqlTaiKhoan);

                // Thêm vào bảng KHACHHANG
                string sqlKhachHang = $"INSERT INTO KHACHHANG (TenDangNhap, HoTen, SoDienThoai, Email) VALUES " +
                    $"('{txtTenDangNhap.Text}', N'{txtHoTen.Text}', '{txtSDT.Text}', '{txtEmail.Text}')";
                ketNoi.ThucThi(sqlKhachHang);

                MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachKhachHang();
                XoaInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string sql = $"UPDATE KHACHHANG SET HoTen = N'{txtHoTen.Text}', SoDienThoai = '{txtSDT.Text}', " +
                    $"Email = '{txtEmail.Text}' WHERE TenDangNhap = '{txtTenDangNhap.Text}'";
                ketNoi.ThucThi(sql);
                MessageBox.Show("Sửa khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachKhachHang();
                XoaInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenDangNhap = dgvKhachHang.SelectedRows[0].Cells["tenDangNhapDataGridViewTextBoxColumn"].Value.ToString();
            if (MessageBox.Show($"Bạn có chắc muốn xóa khách hàng {tenDangNhap}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Xóa vé trước do ràng buộc khóa ngoại
                    string sqlVe = $"DELETE FROM VETAU WHERE KhachHang = '{tenDangNhap}'";
                    ketNoi.ThucThi(sqlVe);

                    // Xóa khách hàng
                    string sqlKhachHang = $"DELETE FROM KHACHHANG WHERE TenDangNhap = '{tenDangNhap}'";
                    ketNoi.ThucThi(sqlKhachHang);

                    // Xóa tài khoản
                    string sqlTaiKhoan = $"DELETE FROM TAIKHOAN WHERE TenDangNhap = '{tenDangNhap}'";
                    ketNoi.ThucThi(sqlTaiKhoan);

                    MessageBox.Show("Xóa khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM KHACHHANG WHERE HoTen LIKE N'%{txtTimKiem.Text}%' OR SoDienThoai LIKE '%{txtTimKiem.Text}%' OR Email LIKE '%{txtTimKiem.Text}%'";
            dgvKhachHang.DataSource = ketNoi.Lay_DuLieuBang(sql);
            ketNoi.HuyKetNoi();
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                var row = dgvKhachHang.SelectedRows[0];
                txtTenDangNhap.Text = row.Cells["tenDangNhapDataGridViewTextBoxColumn"].Value.ToString();
                txtHoTen.Text = row.Cells["hoTenDataGridViewTextBoxColumn"].Value.ToString();
                txtSDT.Text = row.Cells["soDienThoaiDataGridViewTextBoxColumn"].Value?.ToString();
                txtEmail.Text = row.Cells["emailDataGridViewTextBoxColumn"].Value?.ToString();
            }
        }
        private void XoaInput()
        {
            txtTimKiem.Clear(); // TextBox

            txtTenDangNhap.Text = ""; // nếu là Label
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        
    }
}
