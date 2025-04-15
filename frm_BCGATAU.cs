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
    public partial class frm_BCGATAU : Form
    {
        public frm_BCGATAU()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();
        private void frm_BCGATAU_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("Select * from GATAU");
            BAOCAOGATAU baocao = new BAOCAOGATAU();
            baocao.SetDataSource(dta);
            BCGATAU.ReportSource = baocao;
        }
    }
}
