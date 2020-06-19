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
    public partial class MHDatHang : Form
    {
        MHChinh backup;
        public MHDatHang(MHChinh back)
        {
            InitializeComponent();
            backup = back;
        }

        private void xacnhan_Click(object sender, EventArgs e)
        {
            XacNhan XN = new XacNhan(backup);
            this.Hide();
            XN.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            backup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimKiemDH TK = new TimKiemDH();
            TK.Show();
        }
    }
}
