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
    public partial class frm_QUANLYCHUYENDI : Form
    {
        public frm_QUANLYCHUYENDI()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();
        private void frm_QUANLYCHUYENDI_Load(object sender, EventArgs e)
        {
            LoadChuyenDi();
            LoadComboBoxes();
        }

        private void LoadChuyenDi()
        {
            string sql = @"
                SELECT c.MaChuyenDi, c.GiaCoBan, l.MaLichTrinh, g1.TenGa AS GaDi, g2.TenGa AS GaDen, 
                       l.GioDi, l.GioDen, t.TenTau
                FROM CHUYENDI c
                JOIN LICHTRINH l ON c.MaLichTrinh = l.MaLichTrinh
                JOIN GATAU g1 ON l.GaDi = g1.MaGa
                JOIN GATAU g2 ON l.GaDen = g2.MaGa
                JOIN TAU t ON c.MaTau = t.MaTau";
            DataTable dta = kn.Lay_DuLieuBang(sql);
            dgvChuyenDi.DataSource = dta;
            kn.HuyKetNoi();
        }

        private void LoadComboBoxes()
        {
            // Load lịch trình
            string sqlLichTrinh = @"
                SELECT l.MaLichTrinh, (g1.TenGa + ' -> ' + g2.TenGa + ' (' + CONVERT(VARCHAR, l.GioDi, 120) + ')') AS HienThi
                FROM LICHTRINH l
                JOIN GATAU g1 ON l.GaDi = g1.MaGa
                JOIN GATAU g2 ON l.GaDen = g2.MaGa";
            DataTable dtLichTrinh = kn.Lay_DuLieuBang(sqlLichTrinh);
            cmbLichTrinh.DataSource = dtLichTrinh;
            cmbLichTrinh.DisplayMember = "HienThi";
            cmbLichTrinh.ValueMember = "MaLichTrinh";
            kn.HuyKetNoi();

            // Load tàu
            string sqlTau = "SELECT MaTau, TenTau FROM TAU";
            DataTable dtTau = kn.Lay_DuLieuBang(sqlTau);
            cmbTau.DataSource = dtTau;
            cmbTau.DisplayMember = "TenTau";
            cmbTau.ValueMember = "MaTau";
            kn.HuyKetNoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvChuyenDi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chuyến đi để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtGiaCoBan.Text, out decimal giaCoBan))
            {
                MessageBox.Show("Vui lòng nhập giá cơ bản hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbLichTrinh.SelectedValue == null || cmbTau.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lịch trình và tàu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string maChuyenDi = dgvChuyenDi.SelectedRows[0].Cells["MaChuyenDi"].Value.ToString();
                string sql = $"UPDATE CHUYENDI SET MaLichTrinh = '{cmbLichTrinh.SelectedValue}', " +
                             $"MaTau = '{cmbTau.SelectedValue}', GiaCoBan = {giaCoBan} WHERE MaChuyenDi = '{maChuyenDi}'";
                kn.ThucThi(sql);
                MessageBox.Show("Sửa chuyến đi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChuyenDi();
                LamMoiInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChuyenDi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chuyến đi để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maChuyenDi = dgvChuyenDi.SelectedRows[0].Cells["MaChuyenDi"].Value.ToString();
            string sqlCheck = $"SELECT COUNT(*) FROM VETAU WHERE MaChuyenDi = '{maChuyenDi}'";
            int count;
            try
            {
                count = Convert.ToInt32(kn.Lay_DuLieuBang(sqlCheck).Rows[0][0]);
            }
            catch
            {
                count = 0;
            }

            if (count > 0)
            {
                MessageBox.Show("Chuyến đi này đang được sử dụng trong vé tàu. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa chuyến đi {maChuyenDi}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = $"DELETE FROM CHUYENDI WHERE MaChuyenDi = '{maChuyenDi}'";
                    kn.ThucThi(sql);
                    MessageBox.Show("Xóa chuyến đi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChuyenDi();
                    LamMoiInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            LamMoiInput();
            LoadChuyenDi();
        }

        private void dgvChuyenDi_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvChuyenDi.SelectedRows.Count > 0)
            {
                var row = dgvChuyenDi.SelectedRows[0];
                cmbLichTrinh.SelectedValue = row.Cells["MaLichTrinh"].Value;
                cmbTau.Text = row.Cells["TenTau"].Value.ToString();
                txtGiaCoBan.Text = row.Cells["GiaCoBan"].Value.ToString();
            }
        }
        private void LamMoiInput()
        {
            txtGiaCoBan.Clear();
            cmbLichTrinh.SelectedIndex = -1;
            cmbTau.SelectedIndex = -1;
        }

        private void cmbLichTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtGiaCoBan.Text, out decimal giaCoBan))
            {
                MessageBox.Show("Vui lòng nhập giá cơ bản hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbLichTrinh.SelectedValue == null || cmbTau.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lịch trình và tàu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string sql = $"INSERT INTO CHUYENDI (MaLichTrinh, MaTau, GiaCoBan) VALUES " +
                             $"('{cmbLichTrinh.SelectedValue}', '{cmbTau.SelectedValue}', {giaCoBan})";
                kn.ThucThi(sql);
                MessageBox.Show("Thêm chuyến đi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChuyenDi();
                LamMoiInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChuyenDi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
