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
            if (string.IsNullOrEmpty(label_TenDangNhap.Text) || string.IsNullOrEmpty(label_HoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Thêm vào bảng TAIKHOAN trước
                string sqlTaiKhoan = $"INSERT INTO TAIKHOAN (TenDangNhap, MatKhau) VALUES ('{label_TenDangNhap.Text}', 'default123')";
                ketNoi.ThucThi(sqlTaiKhoan);

                // Thêm vào bảng KHACHHANG
                string sqlKhachHang = $"INSERT INTO KHACHHANG (TenDangNhap, HoTen, SoDienThoai, Email) VALUES " +
                    $"('{label_TenDangNhap.Text}', N'{label_HoTen.Text}', '{label_SDT.Text}', '{label_Email.Text}')";
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
                string sql = $"UPDATE KHACHHANG SET HoTen = N'{label_HoTen.Text}', SoDienThoai = '{label_SDT.Text}', " +
                    $"Email = '{label_Email.Text}' WHERE TenDangNhap = '{label_TenDangNhap.Text}'";
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

            string tenDangNhap = dgvKhachHang.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();
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
                label_TenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                label_HoTen.Text = row.Cells["HoTen"].Value.ToString();
                label_SDT.Text = row.Cells["SoDienThoai"].Value?.ToString();
                label_Email.Text = row.Cells["Email"].Value?.ToString();
            }
        }
        private void XoaInput()
        {
            txtTimKiem.Clear(); // TextBox

            label_TenDangNhap.Text = ""; // nếu là Label
            label_HoTen.Text = "";
            label_SDT.Text = "";
            label_Email.Text = "";
        }

        
    }
}
