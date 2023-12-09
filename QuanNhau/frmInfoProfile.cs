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
    public partial class frmInfoProfile : Form
    {
        DBConnection db = new DBConnection();
        Account acc = new Account();
        public frmInfoProfile()
        {
            
            InitializeComponent();
            
        }

        private void btn_resetAcc_Click(object sender, EventArgs e)
        {
            if ((bool)db.getScalar("exec FUNC_CheckPassOld('" + tb_userName.Text + "', '" + tb_passOld.Text + "')"))
                if(tb_passNew.Text == tb_rePassNew.Text)
                {
                    int k = db.getNonQuery("exec USP_UpdateAccount '" + tb_disName.Text + "', '" + tb_userName.Text + "', '" + tb_passNew.Text + "', '"+0+"'");
                    if (k == 1) MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo cập nhật");
                }
                else
                {
                    Control ctr = (Control)sender;
                    if (ctr.Text.Trim().Length == 0)
                        this.errorProvider1.SetError(ctr, "Mật khẩu không khớp");
                }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_userName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Không được bỏ trống");
            else
                this.errorProvider1.Clear();
        }

        private void frmInfoProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
