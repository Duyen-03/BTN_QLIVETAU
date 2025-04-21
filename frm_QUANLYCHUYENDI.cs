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
    public partial class frm_QuanLyChuyenDi : Form
    {
        public frm_QuanLyChuyenDi()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();

        private void frm_QUANLYCHUYENDI_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            LoadLichTrinhToComboBox();
            LoadTauToComboBox();
        }

        private void LoadLichTrinhToComboBox()
        {
            string query = @"
            SELECT 
                L.MaLichTrinh,
                G1.TenGa + ' - ' + G2.TenGa + ', ' + 
                CONVERT(VARCHAR, L.GioDi, 108) + ' - ' + 
                CONVERT(VARCHAR, L.GioDen, 108) AS MoTa
            FROM 
                LICHTRINH L
                JOIN GATAU G1 ON L.GaDi = G1.MaGa
                JOIN GATAU G2 ON L.GaDen = G2.MaGa";
            DataTable lichTrinhTable = kn.Lay_DuLieuBang(query);
            CBO_LichTrinh.DisplayMember = "MoTa";
            CBO_LichTrinh.ValueMember = "MaLichTrinh";
            CBO_LichTrinh.DataSource = lichTrinhTable;
            CBO_LichTrinh.SelectedIndex = -1;
        }

        private void LoadTauToComboBox()
        {
            DataTable tauTable = kn.Lay_DuLieuBang("SELECT MaTau, TenTau FROM TAU");
            CBO_Tau.DisplayMember = "TenTau";
            CBO_Tau.ValueMember = "MaTau";
            CBO_Tau.DataSource = tauTable;
            CBO_Tau.SelectedIndex = -1;
        }

        private void HienThiDuLieu()
        {
            string query = "SELECT MaChuyenDi, MaLichTrinh, MaTau, GiaCoBan FROM CHUYENDI";
            DataTable dta = kn.Lay_DuLieuBang(query);
            dgv_DanhSachChuyenDi.DataSource = dta;
            dgv_DanhSachChuyenDi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgv_DanhSachChuyenDi.Rows.Count > 0)
            {
                dgv_DanhSachChuyenDi.Rows[0].Selected = true;
                HienThiChiTiet();
            }
        }

        private void HienThiChiTiet()
        {
            if (dgv_DanhSachChuyenDi.CurrentRow != null)
            {
                DataGridViewRow row = dgv_DanhSachChuyenDi.CurrentRow;
                TXT_MaChuyenDi.Text = row.Cells["maChuyenDiDataGridViewTextBoxColumn"].Value?.ToString();
                CBO_LichTrinh.SelectedValue = row.Cells["maLichTrinhDataGridViewTextBoxColumn"].Value;
                CBO_Tau.SelectedValue = row.Cells["maTauDataGridViewTextBoxColumn"].Value;
                TXT_GiaCoBan.Text = row.Cells["giaCoBanDataGridViewTextBoxColumn"].Value?.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CBO_LichTrinh.Text) || string.IsNullOrEmpty(CBO_Tau.Text) || string.IsNullOrEmpty(TXT_GiaCoBan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CBO_LichTrinh.SelectedValue == null)
            {
                MessageBox.Show("Lỗi: Chưa chọn lịch trình.");
                return;
            }

            if (CBO_Tau.SelectedValue == null)
            {
                MessageBox.Show("Lỗi: Chưa chọn tàu.");
                return;
            }

            string maLichTrinh = CBO_LichTrinh.SelectedValue.ToString();
            string maTau = CBO_Tau.SelectedValue.ToString();
            if (!decimal.TryParse(TXT_GiaCoBan.Text, out decimal giaCoBan))
            {
                MessageBox.Show("Giá cơ bản phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql_insert = $"INSERT INTO CHUYENDI (MaLichTrinh, MaTau, GiaCoBan) VALUES ('{maLichTrinh}', '{maTau}', '{giaCoBan}')";

            try
            {
                kn.ThucThi(sql_insert);
                MessageBox.Show("Thêm chuyến đi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDuLieu();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachChuyenDi.SelectedRows.Count > 0)
            {
                string maChuyenDi = dgv_DanhSachChuyenDi.SelectedRows[0].Cells["maChuyenDiDataGridViewTextBoxColumn"].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa chuyến đi có mã '{maChuyenDi}' không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string sql_xoa = $"DELETE FROM CHUYENDI WHERE MaChuyenDi = '{maChuyenDi}'";
                        kn.ThucThi(sql_xoa);
                        MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDuLieu();
                        LamMoi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachChuyenDi.SelectedRows.Count > 0)
            {
                string maChuyenDi = dgv_DanhSachChuyenDi.SelectedRows[0].Cells["maChuyenDiDataGridViewTextBoxColumn"].Value.ToString();
                frm_SuaChuyenDi frmSua = new frm_SuaChuyenDi();
                frmSua.MaChuyenDi = maChuyenDi;
                frmSua.ShowDialog();
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string maLichTrinh = CBO_LichTrinh.SelectedValue?.ToString();
            string query = "SELECT MaChuyenDi, MaLichTrinh, MaTau, GiaCoBan FROM CHUYENDI WHERE 1=1";

            if (!string.IsNullOrEmpty(maLichTrinh))
            {
                query += $" AND MaLichTrinh = '{maLichTrinh}'";
            }

            DataTable dta = kn.Lay_DuLieuBang(query);
            dgv_DanhSachChuyenDi.DataSource = dta;

            if (dgv_DanhSachChuyenDi.Rows.Count > 0)
            {
                dgv_DanhSachChuyenDi.Rows[0].Selected = true;
                HienThiChiTiet();
            }
            else
            {
                MessageBox.Show("Không tìm thấy chuyến đi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            HienThiDuLieu();
        }
        private void LamMoi()
        {
            TXT_MaChuyenDi.Text = string.Empty;
            CBO_LichTrinh.SelectedIndex = -1;
            CBO_Tau.SelectedIndex = -1;
            TXT_GiaCoBan.Text = string.Empty;
        }

        private void dgv_DanhSachChuyenDi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_DanhSachChuyenDi.CurrentCell = dgv_DanhSachChuyenDi.Rows[e.RowIndex].Cells[0];
                HienThiChiTiet();
            }
        }

       
    }
}
