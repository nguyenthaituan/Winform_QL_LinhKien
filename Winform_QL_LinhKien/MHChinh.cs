using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_QL_LinhKien
{
    public partial class MHChinh : Form
    {
        public MHChinh()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            DangNhap DN = new DangNhap(this);
            this.Hide();
            DN.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Info info = new Info(this);
            this.Hide();
            info.Show();
        }

        private void lapDDH_Click(object sender, EventArgs e)
        {
            MHDatHang DH = new MHDatHang(this);
            this.Hide();
            DH.Show();
        }
    }
}
