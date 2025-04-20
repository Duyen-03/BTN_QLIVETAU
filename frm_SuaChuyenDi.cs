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
    public partial class frm_SuaChuyenDi : Form
    {
        public frm_SuaChuyenDi()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();
        private string originalMaLichTrinh;
        private string originalMaTau;
        private decimal originalGiaCoBan;

        public string MaChuyenDi { get; set; }

        private void frm_SuaChuyenDi_Load(object sender, EventArgs e)
        {
            CBO_LichTrinh.Enabled = true;
            CBO_Tau.Enabled = true;
            TXT_GiaCoBan.ReadOnly = false;
            TXT_MaChuyenDi.ReadOnly = true; // MaChuyenDi chỉ đọc

            LoadLichTrinhToComboBox();
            LoadTauToComboBox();
            HienThiThongTinChuyenDi();
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
            CBO_LichTrinh.DataSource = lichTrinhTable;
            CBO_LichTrinh.DisplayMember = "MoTa";
            CBO_LichTrinh.ValueMember = "MaLichTrinh";
        }

        private void LoadTauToComboBox()
        {
            DataTable tauTable = kn.Lay_DuLieuBang("SELECT MaTau, TenTau FROM TAU");
            CBO_Tau.DataSource = tauTable;
            CBO_Tau.DisplayMember = "TenTau";
            CBO_Tau.ValueMember = "MaTau";
        }

        private void HienThiThongTinChuyenDi()
        {
            string query = $"SELECT MaChuyenDi, MaLichTrinh, MaTau, GiaCoBan FROM CHUYENDI WHERE MaChuyenDi = '{MaChuyenDi}'";
            DataTable dta = kn.Lay_DuLieuBang(query);

            if (dta.Rows.Count > 0)
            {
                DataRow row = dta.Rows[0];
                TXT_MaChuyenDi.Text = row["MaChuyenDi"].ToString();
                CBO_LichTrinh.SelectedValue = row["MaLichTrinh"];
                CBO_Tau.SelectedValue = row["MaTau"];
                TXT_GiaCoBan.Text = row["GiaCoBan"].ToString();

                // Lưu trữ dữ liệu ban đầu
                originalMaLichTrinh = row["MaLichTrinh"].ToString();
                originalMaTau = row["MaTau"].ToString();
                originalGiaCoBan = decimal.Parse(row["GiaCoBan"].ToString());
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CBO_LichTrinh.Text) || string.IsNullOrEmpty(CBO_Tau.Text) || string.IsNullOrEmpty(TXT_GiaCoBan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLichTrinh = CBO_LichTrinh.SelectedValue.ToString();
            string maTau = CBO_Tau.SelectedValue.ToString();
            if (!decimal.TryParse(TXT_GiaCoBan.Text, out decimal giaCoBan))
            {
                MessageBox.Show("Giá cơ bản phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem có thay đổi dữ liệu không
            if (maLichTrinh == originalMaLichTrinh && maTau == originalMaTau && giaCoBan == originalGiaCoBan)
            {
                MessageBox.Show("Không có thay đổi nào được thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cập nhật dữ liệu nếu có thay đổi
            string sql_update = $"UPDATE CHUYENDI SET MaLichTrinh = '{maLichTrinh}', MaTau = '{maTau}', GiaCoBan = '{giaCoBan}' WHERE MaChuyenDi = '{MaChuyenDi}'";

            try
            {
                kn.ThucThi(sql_update);
                MessageBox.Show("Cập nhật chuyến đi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
