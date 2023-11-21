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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
            //LoadTable();
        }
        #region Method
        void LoadTable()
        {
            DBConnection db = new DBConnection();
            List<Table> tableList = db.LoadTableList();
            foreach(Table item in tableList)
            {
                Button btn = new Button() { Width = db.TableWidth, Height = db.TableHeight};
                flpTable.Controls.Add(btn);
            }
        }
        #endregion
        #region Events
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.ShowDialog();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {

        }

        private void cb_addBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
