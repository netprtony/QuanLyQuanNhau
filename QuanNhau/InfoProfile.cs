using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanNhau
{
    public partial class InfoProfile : Form
    {
        DBConnection db = new DBConnection();
        public InfoProfile()
        {
            InitializeComponent();
        }

        private void btn_resetAcc_Click(object sender, EventArgs e)
        {
        }
    }
}
