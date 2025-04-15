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
    public partial class frm_BCKHACHHANG : Form
    {
        public frm_BCKHACHHANG()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();
        private void frm_BCKHACHHANG_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("Select * from KHACHHANG");
            BAOCAOKHACHHANG baocao = new BAOCAOKHACHHANG();
            baocao.SetDataSource(dta);
            BCKHACHHANG.ReportSource = baocao;
        }
    }
}
