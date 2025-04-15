using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BTN_QLIVETAU
{
    public partial class frm_GATAU : Form
    {
        public frm_GATAU()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();
        public void Load_GaTau()
        {
            DataTable dta = kn.Lay_DuLieuBang("SELECT * FROM GATAU");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dta;
            if (dataGridView1.Columns.Contains("MaGa"))
            {
                dataGridView1.Columns["MaGa"].DisplayIndex = 0;
            }

            // Nếu muốn cột hành động luôn là cuối cùng
            if (dataGridView1.Columns.Contains("btn_Hanhdong"))
            {
                dataGridView1.Columns["btn_Hanhdong"].DisplayIndex = dataGridView1.Columns.Count - 1;
            }
        }

        private void frm_GATAU_Load(object sender, EventArgs e)

        {
            Load_GaTau();
            // TODO: This line of code loads data into the 'qLI_VETAUDataSet.GATAU' table. You can move, or remove it, as needed.
            this.gATAUTableAdapter.Fill(this.qLI_VETAUDataSet.GATAU);
            if (!dataGridView1.Columns.Contains("btn_Hanhdong"))
            {
                DataGridViewTextBoxColumn hanhDongCol = new DataGridViewTextBoxColumn();
                hanhDongCol.Name = "btn_Hanhdong";
                hanhDongCol.HeaderText = "Hành động";
                hanhDongCol.Width = 120;
                dataGridView1.Columns.Add(hanhDongCol);
            }

            dataGridView1.CellPainting -= dataGridView1_CellPainting;
            dataGridView1.CellPainting += dataGridView1_CellPainting;

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btn_Hanhdong")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                int width = (e.CellBounds.Width - 10) / 2;

                Rectangle rectEdit = new Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 5, width - 5, e.CellBounds.Height - 10);
                Rectangle rectDelete = new Rectangle(e.CellBounds.X + width + 10, e.CellBounds.Y + 5, width - 5, e.CellBounds.Height - 10);

                ButtonRenderer.DrawButton(e.Graphics, rectEdit, "Sửa", this.Font, false, PushButtonState.Default);
                ButtonRenderer.DrawButton(e.Graphics, rectDelete, "Xóa", this.Font, false, PushButtonState.Default);

                e.Handled = true;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btn_Hanhdong")
            {
                // Tạm thời hủy sự kiện CellClick trong lúc xử lý
                dataGridView1.CellClick -= dataGridView1_CellClick;

                Rectangle cellRect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point clickPoint = dataGridView1.PointToClient(Cursor.Position);
                int relativeX = clickPoint.X - cellRect.X;
                int buttonWidth = (cellRect.Width - 10) / 2;

                // Lấy giá trị mã ga
                int colIndexMaGa = dataGridView1.Columns["MaGa"].Index;
                string maGa = dataGridView1.Rows[e.RowIndex].Cells[colIndexMaGa].Value?.ToString();

                // Kiểm tra xem nhấn vào "Sửa" hay "Xóa"
                if (relativeX <= buttonWidth)  // Nút "Sửa"
                {
                    frm_UPDATEGA frm = new frm_UPDATEGA(maGa);
                    frm.ShowDialog();
                    Load_GaTau();  // Reload lại sau khi sửa
                }
                else if (relativeX > buttonWidth)  // Nút "Xóa"
                {
                    // Kiểm tra nếu Ga đang được sử dụng trong LICHTRINH
                    string sqlCheck = "SELECT COUNT(*) FROM LICHTRINH WHERE GaDi = '" + maGa + "' OR GaDen = '" + maGa + "'";
                    int count = Convert.ToInt32(kn.LayGiaTri(sqlCheck));  // Assuming `kn.LayGiaTri` gets the scalar value

                    if (count > 0)
                    {
                        // Nếu Ga đang được sử dụng, không cho phép xóa
                        MessageBox.Show("Ga này đang được sử dụng trong lịch trình tàu. Không thể xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Nếu không có tham chiếu trong LICHTRINH, thực hiện xóa
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ga này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            // Xóa ga khỏi cơ sở dữ liệu
                            string sqlXoa = "DELETE FROM GATAU WHERE MaGa = '" + maGa + "'";
                            kn.ThucThi(sqlXoa);
                            MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reload lại danh sách GaTau sau khi xóa
                            Load_GaTau();  // Cập nhật lại DataGridView
                            dataGridView1.ClearSelection(); // Xóa trạng thái chọn dòng
                        }
                    }
                }

                // Đăng ký lại sự kiện sau khi xử lý xong
                dataGridView1.CellClick += dataGridView1_CellClick;
            }
        }



        private void btn_THEM_Click(object sender, EventArgs e)
        {
            frm_UPDATEGA frm = new frm_UPDATEGA();  // Không cần truyền maGa
            frm.ShowDialog();
            Load_GaTau();
            return;
        }
    }
}
